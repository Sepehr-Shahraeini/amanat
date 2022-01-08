using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_CODINGACCESS
    {
        public int ID { get; set; }
        public int? USERID { get; set; }
        public int? LOCATIONID { get; set; }
        public string LOCATION_FULLCODE { get; set; }
        public int CODEID { get; set; }
        public string FULLCODE { get; set; }
        public int? LIMITBEGIN { get; set; }
        public int? LIMITEND { get; set; }
        public int ACCESSLEVEL { get; set; }
    }
}
