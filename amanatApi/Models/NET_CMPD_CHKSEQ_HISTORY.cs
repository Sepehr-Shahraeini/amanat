using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_CHKSEQ_HISTORY
    {
        public int PK { get; set; }
        public int FK_ASSET { get; set; }
        public int FK_CHECK_SEQ { get; set; }
        public int? DATE_PLANNED_BEGIN { get; set; }
        public int? DATE_PLANNED_END { get; set; }
        public int DATE_ACTUAL_BEGIN { get; set; }
        public int DATE_ACTUAL_END { get; set; }
        public int ACTUAL_CYCLE { get; set; }
        public int? ACTUAL_TIME { get; set; }

        public virtual ERP_ASSET FK_ASSETNavigation { get; set; }
        public virtual NET_CMPD_CHECK_SEQ FK_CHECK_SEQNavigation { get; set; }
    }
}
