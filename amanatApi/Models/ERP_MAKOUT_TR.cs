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
        public int? REQUESTDATE { get; set; }
        public int? OLD_REQUESTDATE { get; set; }
        public int? RECDATE { get; set; }
        public int? OLD_RECDATE { get; set; }
        public int? APPROVEDATE { get; set; }
        public int? OLD_APPROVEDATE { get; set; }
        public string LETTERSUBJECT { get; set; }
        public string OLD_LETTERSUBJECT { get; set; }
        public int? LETTERDATE { get; set; }
        public int? OLD_LETTERDATE { get; set; }
        public string LETTERNO { get; set; }
        public string OLD_LETTERNO { get; set; }
        public int? REASON { get; set; }
        public int? OLD_REASON { get; set; }
        public int? EXITDATE { get; set; }
        public int? OLD_EXITDATE { get; set; }
        public int? DEADLINE { get; set; }
        public int? OLD_DEADLINE { get; set; }
        public string DESCRIPTION { get; set; }
        public string OLD_DESCRIPTION { get; set; }
    }
}
