using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTUSER_FILTER
    {
        public int ID { get; set; }
        public int TABLEID { get; set; }
        public string FILTER_NAME { get; set; }
        public string FILTER_VALUE { get; set; }
        public string VALUE_TYPE { get; set; }

        public virtual REPORTUSER_TABLE TABLE { get; set; }
    }
}
