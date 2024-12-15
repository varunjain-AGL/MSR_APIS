namespace MSR_APIS.Models
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
        public int StatusCode { get; set; }
    }

    public class TierRequest
    {
        public string Tier { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }
    public class LoyaltyBadgeResult
    {
        public string error_code { get; set; }
        public string error_message { get; set; }
        public List<dynamic> result { get; set; }
    }

    public class GetCity
    {
        public string CityName { get; set; }
    }

    public class EmailTemplate
    {
        public string Booking_ID { get; set; }
        public string Parking_Name { get; set; }
        public string Address { get; set; }
        public string Parking_Partner { get; set; }
        public string Types { get; set; }
        public string Customer_Email { get; set; }
        public string Mobile_Number { get; set; }
        public string Short_Description { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Assignment_Group { get; set; }
        public string Channels { get; set; }
        public string Locations { get; set; }
        public string issueType { get; set; }
        public string FeedbackImageFirst { get; set; }
        public string FeedbackImageSecond { get; set; }
        public string FeedbackImageThird { get; set; }
    }

}
