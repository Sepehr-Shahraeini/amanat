using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_CODING_TEMP
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int CODE { get; set; }
        public string FULLCODE { get; set; }
        public int? PARENTID { get; set; }
        public int CODETYPE { get; set; }
        public double? DEPRATE { get; set; }
        public int? DEPTYPE { get; set; }
        public int? ASSETTYPE { get; set; }
        public int MODEL { get; set; }
        public int SN { get; set; }
        public int FACTORY { get; set; }
        public int LATINNAME { get; set; }
        public int PN { get; set; }
    }
}
