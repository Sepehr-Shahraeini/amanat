using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_CODINGACCESS
    {
        public int ID { get; set; }
        public int? USERID { get; set; }
        public int? LOCATIONID { get; set; }
        public int CODEID { get; set; }
        public int? LIMITBEGIN { get; set; }
        public int? LIMITEND { get; set; }
        public int ACCESSLEVEL { get; set; }
    }
}
