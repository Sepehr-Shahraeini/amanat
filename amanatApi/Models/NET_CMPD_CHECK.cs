using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_CHECK
    {
        public NET_CMPD_CHECK()
        {
            NET_CMPD_CHECK_SEQs = new HashSet<NET_CMPD_CHECK_SEQ>();
        }

        public int PK { get; set; }
        public string TITLE { get; set; }
        public int FK_CMPD_PROGRAM { get; set; }
        public int INTERVAL_CYCLE { get; set; }
        public int INTERVAL_CALENDAR { get; set; }
        public int CALENDAR_TYPE { get; set; }
        public int? SEQ_PERIOD { get; set; }
        public int? SEQ_TOTAL { get; set; }

        public virtual ERP_OPTION CALENDAR_TYPENavigation { get; set; }
        public virtual NET_CMPD_PROGRAM FK_CMPD_PROGRAMNavigation { get; set; }
        public virtual ICollection<NET_CMPD_CHECK_SEQ> NET_CMPD_CHECK_SEQs { get; set; }
    }
}
