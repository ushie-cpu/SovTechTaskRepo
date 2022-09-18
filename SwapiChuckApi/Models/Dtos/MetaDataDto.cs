﻿using System.Collections.Generic;

namespace SwapiChuckApi.Models.Dtos
{
    public class MetaDataDto<T>
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<T> results { get; set; }
    }
}
