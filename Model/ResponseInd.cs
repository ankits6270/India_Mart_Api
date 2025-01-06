using System.Text.Json.Serialization;

namespace India_Mart_Api.Model
{
    public class ResponseInd
    {
        [JsonPropertyName("UNIQUE_QUERY_ID")]
        public string UNIQUE_QUERY_ID { get; set; } = "";

        [JsonPropertyName("QUERY_TYPE")]
        public string QUERY_TYPE { get; set; } = "";

        [JsonPropertyName("QUERY_TIME")]
        public string QUERY_TIME { get; set; } = "";

        [JsonPropertyName("SENDER_NAME")]
        public string SENDER_NAME { get; set; } = "";

        [JsonPropertyName("SENDER_MOBILE")]
        public string SENDER_MOBILE { get; set; } = "";

        [JsonPropertyName("SENDER_EMAIL")]
        public string SENDER_EMAIL { get; set; } = "";

        [JsonPropertyName("SUBJECT")]
        public string SUBJECT { get; set; } = "";

        [JsonPropertyName("SENDER_COMPANY")]
        public string SENDER_COMPANY { get; set; } = "";

        [JsonPropertyName("SENDER_ADDRESS")]
        public string SENDER_ADDRESS { get; set; } = "";

        [JsonPropertyName("SENDER_CITY")]
        public string SENDER_CITY { get; set; } = "";

        [JsonPropertyName("SENDER_STATE")]
        public string SENDER_STATE { get; set; } = "";

        [JsonPropertyName("SENDER_PINCODE")]
        public string SENDER_PINCODE { get; set; } = "";

        [JsonPropertyName("SENDER_COUNTRY_ISO")]
        public string SENDER_COUNTRY_ISO { get; set; } = "";

        [JsonPropertyName("SENDER_MOBILE_ALT")]
        public string SENDER_MOBILE_ALT { get; set; } = "";

        [JsonPropertyName("SENDER_PHONE")]
        public string SENDER_PHONE { get; set; } = "";

        [JsonPropertyName("SENDER_PHONE_ALT")]
        public string SENDER_PHONE_ALT { get; set; } = "";

        [JsonPropertyName("SENDER_EMAIL_ALT")]
        public string SENDER_EMAIL_ALT { get; set; } = "";

        [JsonPropertyName("QUERY_PRODUCT_NAME")]
        public string QUERY_PRODUCT_NAME { get; set; } = "";

        [JsonPropertyName("QUERY_MESSAGE")]
        public string QUERY_MESSAGE { get; set; } = "";

        [JsonPropertyName("QUERY_MCAT_NAME")]
        public string QUERY_MCAT_NAME { get; set; } = "";

        [JsonPropertyName("CALL_DURATION")]
        public string CALL_DURATION { get; set; } = "";

        [JsonPropertyName("RECEIVER_MOBILE")]
        public string RECEIVER_MOBILE { get; set; } = "";

        [JsonPropertyName("RECEIVER_CATALOG")]
        public string RECEIVER_CATALOG { get; set; } = "";
    }
}
