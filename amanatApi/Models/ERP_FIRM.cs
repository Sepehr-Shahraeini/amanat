using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_FIRM
    {
        public ERP_FIRM()
        {
            ERP_FIRMMEMBERs = new HashSet<ERP_FIRMMEMBER>();
        }

        public int ID { get; set; }
        public int IDENTITYNO { get; set; }
        public string NATIONALNO { get; set; }
        public string NAME { get; set; }
        public string SUBJECT { get; set; }
        public int? COUNTRYID { get; set; }
        public long? SABTDATE { get; set; }
        public double? SARMAYE { get; set; }
        public string BRAND { get; set; }
        public int? STATUS { get; set; }
        public int? STATEID { get; set; }
        public string STATE { get; set; }
        public int? CITYID { get; set; }
        public string CITY { get; set; }
        public string STREET { get; set; }
        public string ALLEY { get; set; }
        public string PLAK { get; set; }
        public int? POSTALCODE { get; set; }

        public virtual ICollection<ERP_FIRMMEMBER> ERP_FIRMMEMBERs { get; set; }
    }
}
