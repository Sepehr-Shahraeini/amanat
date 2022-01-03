using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MAKOUT_TR
    {
        public int ID { get; set; }
        public int OUTID { get; set; }
        public int? REQLOCID { get; set; }
        public int? OLD_REQLOCID { get; set; }
        public int? APPROVERID { get; set; }
        public int? OLD_APPROVERID { get; set; }
        public int? RECID { get; set; }
        public int? OLD_RECID { get; set; }
        public long? REQUESTDATE { get; set; }
        public long? OLD_REQUESTDATE { get; set; }
        public long? RECDATE { get; set; }
        public long? OLD_RECDATE { get; set; }
        public long? APPROVEDATE { get; set; }
        public long? OLD_APPROVEDATE { get; set; }
        public string LETTERSUBJECT { get; set; }
        public string OLD_LETTERSUBJECT { get; set; }
        public long? LETTERDATE { get; set; }
        public long? OLD_LETTERDATE { get; set; }
        public string LETTERNO { get; set; }
        public string OLD_LETTERNO { get; set; }
        public int? REASON { get; set; }
        public int? OLD_REASON { get; set; }
        public long? EXITDATE { get; set; }
        public long? OLD_EXITDATE { get; set; }
        public long? DEADLINE { get; set; }
        public long? OLD_DEADLINE { get; set; }
        public string DESCRIPTION { get; set; }
        public string OLD_DESCRIPTION { get; set; }
    }
}
