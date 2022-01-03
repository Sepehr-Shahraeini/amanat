using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MAKHZAN
    {
        public ERP_MAKHZAN()
        {
            ERP_MAKHZAN_PARTs = new HashSet<ERP_MAKHZAN_PART>();
            ERP_MAKOUTs = new HashSet<ERP_MAKOUT>();
        }

        public int ID { get; set; }
        public int? ASSETID { get; set; }
        public int SANADTYPE { get; set; }
        public int NO { get; set; }
        public int? RECID { get; set; }
        public int? APPROVERID { get; set; }
        public int? SENDERLOCATIONID { get; set; }
        public long? RECDATE { get; set; }
        public long? APPROVEDATE { get; set; }
        public string LETTERSUBJECT { get; set; }
        public long? LETTERDATE { get; set; }
        public string LETTERNO { get; set; }
        public string MOJAVEZKHARIDNO { get; set; }
        public string SOORATJALASENO { get; set; }
        public string DESCRIPTION { get; set; }
        public string PARTS { get; set; }
        public long? LAST_EXIT { get; set; }
        public long? LAST_RETURN { get; set; }

        public virtual ICollection<ERP_MAKHZAN_PART> ERP_MAKHZAN_PARTs { get; set; }
        public virtual ICollection<ERP_MAKOUT> ERP_MAKOUTs { get; set; }
    }
}
