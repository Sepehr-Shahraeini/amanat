using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_PROGRAM
    {
        public NET_CMPD_PROGRAM()
        {
            NET_CMPD_CHECKs = new HashSet<NET_CMPD_CHECK>();
            NET_CMPD_GROUPs = new HashSet<NET_CMPD_GROUP>();
            NET_CMPD_TASKs = new HashSet<NET_CMPD_TASK>();
        }

        public int PK { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public int FK_MPD_CAT { get; set; }
        public int? REV { get; set; }
        public int DATE_CREATE { get; set; }
        public int? DATE_ISSUE { get; set; }
        public int? CY_PER_Y { get; set; }

        public virtual NET_MPD_CAT FK_MPD_CATNavigation { get; set; }
        public virtual ICollection<NET_CMPD_CHECK> NET_CMPD_CHECKs { get; set; }
        public virtual ICollection<NET_CMPD_GROUP> NET_CMPD_GROUPs { get; set; }
        public virtual ICollection<NET_CMPD_TASK> NET_CMPD_TASKs { get; set; }
    }
}
