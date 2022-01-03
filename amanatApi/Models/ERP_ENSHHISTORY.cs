using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ENSHHISTORY
    {
        public int ID { get; set; }
        public int ENSHID { get; set; }
        public int? OLDASSETID { get; set; }
        public int? NEWASSETID { get; set; }
        public int CREATOR { get; set; }
        public long CREATEDATE { get; set; }
    }
}
