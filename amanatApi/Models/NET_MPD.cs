using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_MPD
    {
        public NET_MPD()
        {
            NET_CMPD_TASKs = new HashSet<NET_CMPD_TASK>();
            NET_MPD_APPLICABILITies = new HashSet<NET_MPD_APPLICABILITY>();
            NET_MPD_TASK_MATs = new HashSet<NET_MPD_TASK_MAT>();
            NET_MPD_TASK_TOOLs = new HashSet<NET_MPD_TASK_TOOL>();
        }

        public int PK { get; set; }
        public int? FK_MPD_CAT { get; set; }
        public string TASKNO { get; set; }
        public int? SYSTEM { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public double? TASK_MH { get; set; }
        public double? PREPRATION_MH { get; set; }
        public double? ACCESS_MH { get; set; }
        public int? INTERVAL_CYCLE { get; set; }
        public float? INTERVAL_TIME { get; set; }
        public int? CALENDAR_TYPE { get; set; }
        public int? SUBSYSTEM { get; set; }
        public int? PART { get; set; }

        public virtual NET_MPD_CAT FK_MPD_CATNavigation { get; set; }
        public virtual ERP_OPTION PARTNavigation { get; set; }
        public virtual ERP_OPTION SUBSYSTEMNavigation { get; set; }
        public virtual ERP_OPTION SYSTEMNavigation { get; set; }
        public virtual ICollection<NET_CMPD_TASK> NET_CMPD_TASKs { get; set; }
        public virtual ICollection<NET_MPD_APPLICABILITY> NET_MPD_APPLICABILITies { get; set; }
        public virtual ICollection<NET_MPD_TASK_MAT> NET_MPD_TASK_MATs { get; set; }
        public virtual ICollection<NET_MPD_TASK_TOOL> NET_MPD_TASK_TOOLs { get; set; }
    }
}
