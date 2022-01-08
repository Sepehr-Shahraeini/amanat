using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_LASTDONE
    {
        public int PK { get; set; }
        public int FK_CMPD_TASK { get; set; }
        public int FK_ASSET { get; set; }
        public int LD_CYCLE { get; set; }
        public int LD_DATE { get; set; }
        public int? LD_PACKAGE { get; set; }
        public int? LD_WO { get; set; }
        public string DESCRIPTION { get; set; }

        public virtual ERP_ASSET FK_ASSETNavigation { get; set; }
        public virtual NET_CMPD_TASK FK_CMPD_TASKNavigation { get; set; }
    }
}
