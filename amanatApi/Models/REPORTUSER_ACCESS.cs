using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTUSER_ACCESS
    {
        public int ID { get; set; }
        public int REPORTID { get; set; }
        public int LOCATIONID { get; set; }
        public int? SELECTED { get; set; }
        public int? EXPANDED { get; set; }
        public int? STATUS { get; set; }

        public virtual REPORTUSER REPORT { get; set; }
    }
}
