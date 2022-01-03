using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MSGATTACH
    {
        public string DESCRPTION { get; set; }
        public int ID { get; set; }
        public int MSGID { get; set; }
        public string ATTACHURL { get; set; }
        public string ATTACHFILENAME { get; set; }

        public virtual ERP_MSG MSG { get; set; }
    }
}
