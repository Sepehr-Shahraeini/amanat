using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MAKOUT_PART
    {
        public int ID { get; set; }
        public int MAKOUTID { get; set; }
        public int PARTID { get; set; }
        public int? RETURNDATE { get; set; }
        public int? DEADLINE { get; set; }

        public virtual ERP_MAKOUT MAKOUT { get; set; }
    }
}
