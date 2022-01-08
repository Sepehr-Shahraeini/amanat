using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_MPD_TASK_TOOL
    {
        public int PK { get; set; }
        public int FK_NET_MPD_TASK { get; set; }
        public int FK_ERP_CODING { get; set; }
        public int QUANTITY { get; set; }
        public string DESCRIPTION { get; set; }

        public virtual ERP_CODING FK_ERP_CODINGNavigation { get; set; }
        public virtual NET_MPD FK_NET_MPD_TASKNavigation { get; set; }
    }
}
