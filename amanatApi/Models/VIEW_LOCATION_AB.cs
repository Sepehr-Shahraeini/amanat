using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_LOCATION_AB
    {
        public int ID { get; set; }
        public int? PARENTID { get; set; }
        public string TITLE { get; set; }
        public int? ROOT { get; set; }
        public string FULLCODE { get; set; }
        public long? NFULLCODE { get; set; }
        public string TITLE2 { get; set; }
        public string LOCATIONTYPE_STR { get; set; }
    }
}
