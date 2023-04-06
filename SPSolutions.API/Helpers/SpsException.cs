namespace SPSolutions.API.Helpers
{
    public class SpsException
    {
        public SpsException(int statusCode, string message, string details)
        {
            StatusCode = statusCode;
            Details = details;
            Message = message;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}