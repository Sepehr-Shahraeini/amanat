using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MAKOUT
    {
        public ERP_MAKOUT()
        {
            ERP_MAKOUT_PARTs = new HashSet<ERP_MAKOUT_PART>();
        }

        public int ID { get; set; }
        public int SANADID { get; set; }
        public int? REQLOCID { get; set; }
        public int? APPROVERID { get; set; }
        public int? RECID { get; set; }
        public long? REQUESTDATE { get; set; }
        public long? RECDATE { get; set; }
        public long? APPROVEDATE { get; set; }
        public string LETTERSUBJECT { get; set; }
        public long? LETTERDATE { get; set; }
        public string LETTERNO { get; set; }
        public int? REASON { get; set; }
        public long? EXITDATE { get; set; }
        public long? DEADLINE { get; set; }
        public long? RETURNDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public int ISCONTINUAL { get; set; }
        public int? PARENTID { get; set; }
        public long? CREATEDATE { get; set; }
        public int ISTRANSFERED { get; set; }

        public virtual ERP_MAKHZAN SANAD { get; set; }
        public virtual ICollection<ERP_MAKOUT_PART> ERP_MAKOUT_PARTs { get; set; }
    }
}
