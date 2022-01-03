using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MAKHZAN_PART
    {
        public int ID { get; set; }
        public int? SANADID { get; set; }
        public int PARTID { get; set; }
        public string DOCUMENTNO { get; set; }
        public long? DATE_DOCUMENT { get; set; }
        public string DESCRIPTION { get; set; }
        public int? ASSETID { get; set; }

        public virtual ERP_MAKHZAN SANAD { get; set; }
    }
}
