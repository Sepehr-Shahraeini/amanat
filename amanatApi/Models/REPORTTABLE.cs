using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTTABLE
    {
        public byte[] ID { get; set; }
        public string TABLENAME { get; set; }
        public byte[] OLD_REPORTID { get; set; }
        public string ALIAS { get; set; }
        public int PK { get; set; }
        public int? REPORTID { get; set; }
        public string TITLE { get; set; }
        public int? FAKEID { get; set; }
        public int? FAKEPARENTID { get; set; }
    }
}
