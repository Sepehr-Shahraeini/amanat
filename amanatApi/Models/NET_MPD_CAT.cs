using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_MPD_CAT
    {
        public NET_MPD_CAT()
        {
            NET_CMPD_PROGRAMs = new HashSet<NET_CMPD_PROGRAM>();
            NET_MPDs = new HashSet<NET_MPD>();
        }

        public int PK { get; set; }
        public int? REVESION { get; set; }
        public int? DATE_PUBLISHED { get; set; }
        public int? DATE_ISSUE { get; set; }
        public string TITLE { get; set; }
        public int? ISSUE { get; set; }
        public int? FK_CATEGORY { get; set; }

        public virtual ICollection<NET_CMPD_PROGRAM> NET_CMPD_PROGRAMs { get; set; }
        public virtual ICollection<NET_MPD> NET_MPDs { get; set; }
    }
}
