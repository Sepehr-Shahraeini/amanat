using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_TEMPPAPERITEM
    {
        public int ID { get; set; }
        public int TEMPPAPERID { get; set; }
        public int? CODEID { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public double? QUANTITY { get; set; }
        public string SNBN { get; set; }
        public string MODEL { get; set; }
        public string PN { get; set; }
        public int? BRAND { get; set; }
        public int? COUNTRY { get; set; }
        public int? FAKEID { get; set; }

        public virtual ERP_TEMPPAPER TEMPPAPER { get; set; }
    }
}
