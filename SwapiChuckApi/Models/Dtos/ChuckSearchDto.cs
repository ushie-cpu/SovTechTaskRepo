using System.Collections.Generic;

namespace SwapiChuckApi.Models.Dtos
{
    public class ChuckSearchMetaDataDto<T>
    {
        public int Total { get; set; }
        public List<JokesDto> Result { get; set; }
    }
}
