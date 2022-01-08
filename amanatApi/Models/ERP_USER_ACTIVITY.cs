using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_USER_ACTIVITY
    {
        public int ID { get; set; }
        public int? APPLICATION { get; set; }
        public int USERID { get; set; }
        public int DATE_CREATE { get; set; }
        public string ACTIVITY { get; set; }
        public string REMARK { get; set; }
        public int? ENTITYID { get; set; }
        public string ENTITYNO { get; set; }
        public string USERNAME { get; set; }
        public string USERPID { get; set; }
        public string IP { get; set; }
        public string MAC { get; set; }
        public DateTime? DATE_CREATE_G { get; set; }
        public int? LOCATIONID { get; set; }
        public string REQUEST { get; set; }
    }
}
