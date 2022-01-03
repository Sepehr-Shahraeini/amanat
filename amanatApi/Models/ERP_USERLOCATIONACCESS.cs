using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_USERLOCATIONACCESS
    {
        public int ID { get; set; }
        public int USERID { get; set; }
        public int LOCATIONID { get; set; }
        public int ROLE { get; set; }
        public int? MAIN { get; set; }

        public virtual ERP_USER USER { get; set; }
    }
}
