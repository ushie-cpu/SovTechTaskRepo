using System.Collections.Generic;

namespace SwapiChuckApi.Models.Dtos
{
    public class SearchMetaDataDto<T>
    {
        public string api { get; set; }
        public T result { get; set; }
    }
}
