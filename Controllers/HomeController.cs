using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Reflection;
using India_Mart_Api.Model;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;

namespace India_Mart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
       
        private readonly IHttpClientFactory httpClientFactory;
        private readonly ApplicationDbContext _dbContext;
        public HomeController(IHttpClientFactory httpClientFactory, ApplicationDbContext dbContext)
        {
            this.httpClientFactory = httpClientFactory;
            this._dbContext = dbContext;
        }

        [HttpGet("GetCrmData")]
        public async Task<IActionResult> GetCrmData([FromQuery] string start_date, [FromQuery] string end_date)
        {
            if (!DateTime.TryParse(start_date, out var startDate) ||
        !DateTime.TryParse(end_date, out var endDate))
            {
                return BadRequest("Invalid date format. Use a valid date format.");
            }

            if ((endDate - startDate).TotalDays > 7)
            {
                return BadRequest("The date range should not exceed 7 days.");
            }
            string url = $"https://mapi.indiamart.com/wservce/crm/crmListing/v2/?glusr_crm_key={Your_Key}&start_time={start_date}&end_time={end_date}";
            var client = httpClientFactory.CreateClient();

            try
            {
                var httpResponseMessage = await client.GetAsync(url);

                httpResponseMessage.EnsureSuccessStatusCode();

                var rawResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                JObject jObject = JObject.Parse(rawResponse);

                if (jObject["CODE"]?.ToString() == "200" && jObject["STATUS"]?.ToString() == "SUCCESS")
                {
                    JArray jArray = (JArray)(jObject.GetValue("RESPONSE"));
                    var crmRecords = new List<CrmRecord>();

                    foreach (JObject item in jArray)
                    {
                        var crmRecord = new CrmRecord
                        {
                            UNIQUE_QUERY_ID = item["UNIQUE_QUERY_ID"]?.ToString(),
                            QUERY_TYPE = item["QUERY_TYPE"]?.ToString(),
                            QUERY_TIME = item["QUERY_TIME"]?.ToString(),
                            SENDER_NAME = item["SENDER_NAME"]?.ToString(),
                            SENDER_MOBILE = item["SENDER_MOBILE"]?.ToString(),
                            SENDER_EMAIL = item["SENDER_EMAIL"]?.ToString(),
                            SUBJECT = item["SUBJECT"]?.ToString(),
                            SENDER_COMPANY = item["SENDER_COMPANY"]?.ToString(),
                            SENDER_ADDRESS = item["SENDER_ADDRESS"]?.ToString(),
                            SENDER_CITY = item["SENDER_CITY"]?.ToString(),
                            SENDER_STATE = item["SENDER_STATE"]?.ToString(),
                            SENDER_PINCODE = item["SENDER_PINCODE"]?.ToString(),
                            SENDER_COUNTRY_ISO = item["SENDER_COUNTRY_ISO"]?.ToString(),
                            SENDER_MOBILE_ALT = item["SENDER_MOBILE_ALT"]?.ToString(),
                            SENDER_PHONE = item["SENDER_PHONE"]?.ToString(),
                            SENDER_PHONE_ALT = item["SENDER_PHONE_ALT"]?.ToString(),
                            SENDER_EMAIL_ALT = item["SENDER_EMAIL_ALT"]?.ToString(),
                            QUERY_PRODUCT_NAME = item["QUERY_PRODUCT_NAME"]?.ToString(),
                            QUERY_MESSAGE = item["QUERY_MESSAGE"]?.ToString(),
                            QUERY_MCAT_NAME = item["QUERY_MCAT_NAME"]?.ToString(),
                            CALL_DURATION = item["CALL_DURATION"]?.ToString(),
                            RECEIVER_MOBILE = item["RECEIVER_MOBILE"]?.ToString(),
                            RECEIVER_CATALOG = item["RECEIVER_CATALOG"]?.ToString(),
                        };

                        crmRecords.Add(crmRecord);
                    }

                    // Save to database
                    await _dbContext.CrmRecords.AddRangeAsync(crmRecords);
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    return BadRequest("API response was not successful.");
                }

                return Ok("Data successfully stored in the database.");
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, $"HTTP request error: {ex.Message}");
            }
            catch (JsonException ex)
            {
                return StatusCode(500, $"JSON deserialization error: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}

