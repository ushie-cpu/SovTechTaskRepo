namespace SwapiChuckApi.Models
{
    public class ApiRequestModel
    {
        public RequestType type { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }

    public enum RequestType
    {
        POST,
        GET,
        PUT,
        DELETE
    }
}
