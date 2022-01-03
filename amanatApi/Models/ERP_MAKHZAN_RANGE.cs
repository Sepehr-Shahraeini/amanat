using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MAKHZAN_RANGE
    {
        public int ID { get; set; }
        public int CATEGORYID { get; set; }
        public int NO_FROM { get; set; }
        public int NO_TO { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
