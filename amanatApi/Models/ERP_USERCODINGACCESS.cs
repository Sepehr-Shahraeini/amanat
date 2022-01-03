using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_USERCODINGACCESS
    {
        public int ID { get; set; }
        public int CODEID { get; set; }
        public int USERID { get; set; }
        public int ROLE { get; set; }

        public virtual ERP_USER USER { get; set; }
    }
}
