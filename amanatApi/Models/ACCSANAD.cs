using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ACCSANAD
    {
        public ACCSANAD()
        {
            ACCSITEMs = new HashSet<ACCSITEM>();
        }

        public byte[] ID { get; set; }
        public int NO { get; set; }
        public string TITLE { get; set; }
        public string SANADTYPE { get; set; }
        public int SANADDATE { get; set; }
        public int SANADCONDITION { get; set; }
        public int TOTAL { get; set; }
        public string BASEDON { get; set; }
        public int CREATEDATE { get; set; }
        public string CREATEUSER { get; set; }
        public int UPDATEDATE { get; set; }
        public string UPDATEUSER { get; set; }
        public int SENT { get; set; }
        public string APPROVEDUSER { get; set; }
        public int APPROVEDDATE { get; set; }
        public int YEAR { get; set; }
        public int ORGANIZATION { get; set; }
        public int LOCATION { get; set; }
        public int APPROVED { get; set; }
        public byte[] BASEDONID { get; set; }

        public virtual ICollection<ACCSITEM> ACCSITEMs { get; set; }
    }
}
