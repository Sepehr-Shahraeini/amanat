using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ROLEACCESS
    {
        public int ID { get; set; }
        public int ROLEID { get; set; }
        public string FORMKEY { get; set; }
        public string OBJECTKEY { get; set; }
        public string PUBLICKEY { get; set; }
        public string FORMCAPTION { get; set; }
        public string OBJECTCAPTION { get; set; }

        public virtual ERP_ROLE ROLE { get; set; }
    }
}
