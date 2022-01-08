using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_CMPD_TOOL
    {
        public int PK { get; set; }
        public int FK_CMPD_TASK { get; set; }
        public int FK_ERP_CODING { get; set; }
        public int QUANTITY { get; set; }
        public string DESCRIPTION { get; set; }

        public virtual NET_CMPD_TASK FK_CMPD_TASKNavigation { get; set; }
        public virtual ERP_CODING FK_ERP_CODINGNavigation { get; set; }
    }
}
