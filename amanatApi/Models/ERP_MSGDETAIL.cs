using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MSGDETAIL
    {
        public int VISITED { get; set; }
        public int? DATE_VISIT { get; set; }
        public int REPLIED { get; set; }
        public int? DATE_REPLY { get; set; }
        public int FORWARDED { get; set; }
        public int ARCHIVED { get; set; }
        public int ID { get; set; }
        public int MSGID { get; set; }
        public int RECEIVER { get; set; }

        public virtual ERP_MSG MSG { get; set; }
        public virtual ERP_USER RECEIVERNavigation { get; set; }
    }
}
