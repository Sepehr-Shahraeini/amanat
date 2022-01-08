using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_MAKOUT_REMAIN
    {
        public int ID { get; set; }
        public int SANADID { get; set; }
        public string REQLOCTITLE { get; set; }
        public string REQLOCCODE { get; set; }
        public int? DEADLINE { get; set; }
        public int? REMAIN { get; set; }
        public int ISCONTINUAL { get; set; }
        public int ISTRANSFERED { get; set; }
    }
}
