using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_REPORTTABLE
    {
        public byte[] OLDID { get; set; }
        public string TABLENAME { get; set; }
        public byte[] OLDREPORTID { get; set; }
        public string ALIAS { get; set; }
        public int? REPORTID { get; set; }
        public int ID { get; set; }
    }
}
