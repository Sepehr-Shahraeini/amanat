using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ACCSANAD
    {
        public ERP_ACCSANAD()
        {
            ERP_ACCSITEMs = new HashSet<ERP_ACCSITEM>();
        }

        public string NO { get; set; }
        public string TITLE { get; set; }
        public int? SANADTYPE { get; set; }
        public long SANADDATE { get; set; }
        public int SANADCONDITION { get; set; }
        public double? TOTAL { get; set; }
        public int? PAPERID { get; set; }
        public long CREATEDATE { get; set; }
        public int CREATEUSER { get; set; }
        public int? APPROVEDUSER { get; set; }
        public long? APPROVEDDATE { get; set; }
        public int YEAR { get; set; }
        public int? ORGANIZATION { get; set; }
        public int LOCATION { get; set; }
        public int APPROVED { get; set; }
        public int ID { get; set; }

        public virtual ERP_PAPER PAPER { get; set; }
        public virtual ICollection<ERP_ACCSITEM> ERP_ACCSITEMs { get; set; }
    }
}
