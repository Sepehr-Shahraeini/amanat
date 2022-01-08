using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_TASK_SEQ
    {
        public int FK_SEQ { get; set; }
        public int FK_CMPD_TASK { get; set; }
        public string DESCRIPTION { get; set; }
        public int PK { get; set; }

        public virtual NET_CMPD_TASK FK_CMPD_TASKNavigation { get; set; }
        public virtual NET_CMPD_CHECK_SEQ FK_SEQNavigation { get; set; }
    }
}
