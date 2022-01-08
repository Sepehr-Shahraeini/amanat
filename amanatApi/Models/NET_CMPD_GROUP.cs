using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_GROUP
    {
        public int PK { get; set; }
        public int FK_NET_CMP_PROG { get; set; }
        public int? FK_ERP_CODING { get; set; }
        public int? FK_MAKE { get; set; }
        public int? FK_MODEL { get; set; }
        public string DESCRIPTION { get; set; }

        public virtual ERP_CODING FK_ERP_CODINGNavigation { get; set; }
        public virtual NET_CMPD_PROGRAM FK_NET_CMP_PROGNavigation { get; set; }
    }
}
