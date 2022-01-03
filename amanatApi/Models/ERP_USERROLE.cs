using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_USERROLE
    {
        public int ID { get; set; }
        public int ROLEID { get; set; }
        public int? USERID { get; set; }
        public int? GROUPID { get; set; }
        public long? DATE_BEGIN { get; set; }
        public long? DATE_END { get; set; }
        public int ISACTIVE { get; set; }

        public virtual ERP_ROLE ROLE { get; set; }
        public virtual ERP_USER USER { get; set; }
    }
}
