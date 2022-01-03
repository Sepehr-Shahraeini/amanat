using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ROLE
    {
        public ERP_ROLE()
        {
            ERP_ROLEACCESSes = new HashSet<ERP_ROLEACCESS>();
            ERP_USERROLEs = new HashSet<ERP_USERROLE>();
        }

        public int ID { get; set; }
        public int? APPLICATION { get; set; }
        public string DESCRIPTION { get; set; }
        public string TITLE { get; set; }
        public int? AMINAMVAL { get; set; }
        public int? ANBARDAR { get; set; }
        public int? ADMIN { get; set; }
        public int? AMINAMVALKOL { get; set; }
        public int? ANBARDARKOL { get; set; }
        public int? REPAIR { get; set; }
        public int? SHOP { get; set; }
        public int? RECEIVING { get; set; }
        public int? REQUEST { get; set; }

        public virtual ICollection<ERP_ROLEACCESS> ERP_ROLEACCESSes { get; set; }
        public virtual ICollection<ERP_USERROLE> ERP_USERROLEs { get; set; }
    }
}
