using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class HELPER_MAKOUT_PART
    {
        public int ID { get; set; }
        public int MAKOUTID { get; set; }
        public int PARTID { get; set; }
        public string TITLE { get; set; }
        public int? RETURNDATE { get; set; }
        public int? DEADLINE { get; set; }
        public int SANADID { get; set; }
        public int? REMAIN { get; set; }
        public int STATUS { get; set; }
        public string STATUS_STR { get; set; }
        public int? EXITDATE { get; set; }
        public int? REASON { get; set; }
        public string REASON_STR { get; set; }
        public int? RECID { get; set; }
        public string RECNAME { get; set; }
        public string RECPID { get; set; }
        public int? REQLOCID { get; set; }
        public string REQLOCTITLE { get; set; }
        public string REQLOCCODE { get; set; }
        public string LETTERSUBJECT { get; set; }
        public int? LETTERDATE { get; set; }
        public string LETTERNO { get; set; }
        public int? APPROVERID { get; set; }
        public string APPROVERNAME { get; set; }
        public string APPROVERPID { get; set; }
        public int? APPROVEDATE { get; set; }
        public int ISCONTINUAL { get; set; }
    }
}
