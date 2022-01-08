using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_FIRMMEMBER
    {
        public int ID { get; set; }
        public int FIRMID { get; set; }
        public string NAME { get; set; }
        public string LNAME { get; set; }
        public string FATHERNAME { get; set; }
        public int? BIRTHDATE { get; set; }
        public int? NID { get; set; }
        public string TEL { get; set; }
        public string MOBILE { get; set; }
        public int? SEMATID { get; set; }
        public double? SHAREAMOUNT { get; set; }
        public int? SIGNRIGHT { get; set; }
        public int? SIGNRIGHT_BEGIN { get; set; }
        public int? SIGNRIGHT_END { get; set; }
        public int? STATUS { get; set; }
        public string ADDRESS { get; set; }
        public int? FAKEID { get; set; }

        public virtual ERP_FIRM FIRM { get; set; }
    }
}
