using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_CONTROLPOINT
    {
        public int ID { get; set; }
        public int CODEID { get; set; }
        public int LOCATIONID { get; set; }
        public double? MINSTOCKPOINT { get; set; }
        public double? MAXSTOCKPOINT { get; set; }
        public double? REORDERPOINT { get; set; }
        public double? ECONOMICSMOUNT { get; set; }
    }
}
