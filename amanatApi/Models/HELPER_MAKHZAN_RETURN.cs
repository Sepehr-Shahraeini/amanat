using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class HELPER_MAKHZAN_RETURN
    {
        public int ID { get; set; }
        public int SANADID { get; set; }
        public int? REQLOCID { get; set; }
        public int? APPROVERID { get; set; }
        public int? RECID { get; set; }
        public int? REQUESTDATE { get; set; }
        public int? RECDATE { get; set; }
        public int? APPROVEDATE { get; set; }
        public string LETTERSUBJECT { get; set; }
        public int? LETTERDATE { get; set; }
        public string LETTERNO { get; set; }
        public int? REASON { get; set; }
        public int? EXITDATE { get; set; }
        public int? DEADLINE { get; set; }
        public int? RETURNDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public int ISCONTINUAL { get; set; }
        public int? PARENTID { get; set; }
        public int? CREATEDATE { get; set; }
        public int ISTRANSFERED { get; set; }
        public int? LAST_RETURNDATE { get; set; }
        public int MAKOUTID { get; set; }
        public int MOP_ID { get; set; }
        public long? RN { get; set; }
    }
}
