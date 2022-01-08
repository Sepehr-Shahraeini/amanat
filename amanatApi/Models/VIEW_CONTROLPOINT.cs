using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_CONTROLPOINT
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int? PARENTID { get; set; }
        public string FULLCODE { get; set; }
        public double? ECONOMICSMOUNT { get; set; }
        public int? CP_ID { get; set; }
        public int? LOCATIONID { get; set; }
        public string LOCATION_TITLE { get; set; }
        public string LOCATION_CODE { get; set; }
        public double? MAXSTOCKPOINT { get; set; }
        public double? MINSTOCKPOINT { get; set; }
        public double? REORDERPOINT { get; set; }
    }
}
