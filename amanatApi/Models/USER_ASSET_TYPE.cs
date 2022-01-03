using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class USER_ASSET_TYPE
    {
        public int ID { get; set; }
        public int USERID { get; set; }
        public int ASSETTYPEID { get; set; }

        public virtual ERP_USER USER { get; set; }
    }
}
