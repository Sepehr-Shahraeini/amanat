using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_TASK
    {
        public NET_CMPD_TASK()
        {
            NET_CMPD_LASTDONEs = new HashSet<NET_CMPD_LASTDONE>();
            NET_CMPD_MATs = new HashSet<NET_CMPD_MAT>();
            NET_CMPD_TASK_SEQs = new HashSet<NET_CMPD_TASK_SEQ>();
            NET_CMPD_TOOLs = new HashSet<NET_CMPD_TOOL>();
        }

        public int PK { get; set; }
        public int FK_MPD_TASK { get; set; }
        public string DESCRIPTION { get; set; }
        public int? INTERVAL_CYCLE { get; set; }
        public double? INTERVAL_TIME { get; set; }
        public int? CALENDAR_TYPE { get; set; }
        public double? TASK_MH { get; set; }
        public double? PREPRATION_MH { get; set; }
        public double? ACCESS_MH { get; set; }
        public int FK_CMPD_PROG { get; set; }

        public virtual NET_CMPD_PROGRAM FK_CMPD_PROGNavigation { get; set; }
        public virtual NET_MPD FK_MPD_TASKNavigation { get; set; }
        public virtual ICollection<NET_CMPD_LASTDONE> NET_CMPD_LASTDONEs { get; set; }
        public virtual ICollection<NET_CMPD_MAT> NET_CMPD_MATs { get; set; }
        public virtual ICollection<NET_CMPD_TASK_SEQ> NET_CMPD_TASK_SEQs { get; set; }
        public virtual ICollection<NET_CMPD_TOOL> NET_CMPD_TOOLs { get; set; }
    }
}
