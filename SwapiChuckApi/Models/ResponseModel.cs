using System.Collections.Generic;

namespace SwapiChuckApi.Models
{
    public class ResponseModel
    {
        public bool IsSucessful { get; set; } = true;
        public object Result { get; set; }
        public string Message { get; set; }
        public List<string> Error { get; set; }

        public ResponseModel()
        {
            Error = new List<string>();
        }
    }
}
 