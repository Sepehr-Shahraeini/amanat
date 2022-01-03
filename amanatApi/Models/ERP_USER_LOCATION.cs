using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_USER_LOCATION
    {
        public int ID { get; set; }
        public int LOCATIONID { get; set; }
        public int USERID { get; set; }
        public int IS_ANBARDAR { get; set; }
        public int IS_ANBARDAR_KOL { get; set; }
        public int IS_ANBARDAR_ROOT { get; set; }
        public int IS_AMINAMVAL { get; set; }
        public int IS_AMINAMVAL_KOL { get; set; }
        public int IS_AMINAMVAL_ROOT { get; set; }
        public int IS_TADAROKAT { get; set; }
        public int IS_KHARID { get; set; }
        public int IS_ADMIN { get; set; }
        public int IS_GROUP_MAN { get; set; }
        public int IS_USER_MAN { get; set; }
        public int ACTIVE { get; set; }

        public virtual ERP_USER USER { get; set; }
    }
}
