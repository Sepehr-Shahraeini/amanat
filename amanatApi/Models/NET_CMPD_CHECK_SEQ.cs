using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_CHECK_SEQ
    {
        public NET_CMPD_CHECK_SEQ()
        {
            NET_CMPD_CHKSEQ_HISTORies = new HashSet<NET_CMPD_CHKSEQ_HISTORY>();
            NET_CMPD_TASK_SEQs = new HashSet<NET_CMPD_TASK_SEQ>();
        }

        public int PK { get; set; }
        public int FK_CMPD_CHECK { get; set; }
        public int SEQ { get; set; }
        public string TITLE { get; set; }

        public virtual NET_CMPD_CHECK FK_CMPD_CHECKNavigation { get; set; }
        public virtual ICollection<NET_CMPD_CHKSEQ_HISTORY> NET_CMPD_CHKSEQ_HISTORies { get; set; }
        public virtual ICollection<NET_CMPD_TASK_SEQ> NET_CMPD_TASK_SEQs { get; set; }
    }
}
