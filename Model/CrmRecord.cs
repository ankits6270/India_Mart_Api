namespace India_Mart_Api.Model
{
    public class CrmRecord
    {
        public int Id { get; set; } // Primary Key
        public string UNIQUE_QUERY_ID { get; set; }
        public string QUERY_TYPE { get; set; }
        public string QUERY_TIME { get; set; }
        public string SENDER_NAME { get; set; }
        public string SENDER_MOBILE { get; set; }
        public string SENDER_EMAIL { get; set; }
        public string SUBJECT { get; set; }
        public string SENDER_COMPANY { get; set; }
        public string SENDER_ADDRESS { get; set; }
        public string SENDER_CITY { get; set; }
        public string SENDER_STATE { get; set; }
        public string SENDER_PINCODE { get; set; }
        public string SENDER_COUNTRY_ISO { get; set; }
        public string SENDER_MOBILE_ALT { get; set; }
        public string SENDER_PHONE { get; set; }
        public string SENDER_PHONE_ALT { get; set; }
        public string SENDER_EMAIL_ALT { get; set; }
        public string QUERY_PRODUCT_NAME { get; set; }
        public string QUERY_MESSAGE { get; set; }
        public string QUERY_MCAT_NAME { get; set; }
        public string CALL_DURATION { get; set; }
        public string RECEIVER_MOBILE { get; set; }
        public string RECEIVER_CATALOG { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }

}
