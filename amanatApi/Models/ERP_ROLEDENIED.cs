using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ROLEDENIED
    {
        public int ID { get; set; }
        public int USERID { get; set; }
        public string FORMKEY { get; set; }
        public string OBJECTKEY { get; set; }
        public string PUBLICKEY { get; set; }
        public string FORMCAPTION { get; set; }
        public string OBJECTCAPTION { get; set; }
    }
}
