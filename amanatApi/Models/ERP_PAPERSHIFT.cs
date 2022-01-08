using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_PAPERSHIFT
    {
        public int ID { get; set; }
        public int PAPERID { get; set; }
        public int DATE_CREATE { get; set; }
        public int CREATOR { get; set; }
        public int OLDRECID { get; set; }
        public int NEWRECID { get; set; }
        public int? OLDLOCID { get; set; }
        public int? NEWLOCID { get; set; }
    }
}
