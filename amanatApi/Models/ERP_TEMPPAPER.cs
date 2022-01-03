using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_TEMPPAPER
    {
        public ERP_TEMPPAPER()
        {
            ERP_TEMPPAPERITEMs = new HashSet<ERP_TEMPPAPERITEM>();
        }

        public int ID { get; set; }
        public string NO { get; set; }
        public long PAPERDATE { get; set; }
        public int CREATOR { get; set; }
        public int? REC { get; set; }
        public int? RECLOCATION { get; set; }
        public int? SEN { get; set; }
        public int? SENLOCATION { get; set; }
        public string EMITTER { get; set; }
        public int? RES { get; set; }
        public int? RESLOCATION { get; set; }
        public int? AMIN { get; set; }
        public int? AMINLOCATION { get; set; }
        public string DESCRIPTION { get; set; }
        public string INVOICE_NO { get; set; }
        public string AWB { get; set; }

        public virtual ICollection<ERP_TEMPPAPERITEM> ERP_TEMPPAPERITEMs { get; set; }
    }
}
