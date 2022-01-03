using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTX
    {
        public byte[] ID { get; set; }
        public string TITLE { get; set; }
        public int ISGENERAL { get; set; }
        public int? CREATOR { get; set; }
        public string TABLENAME { get; set; }
        public byte[] SQLCOMMND { get; set; }
        public int SHOWCODESELECTION { get; set; }
        public int TAJMI { get; set; }
        public int CODELIMITED { get; set; }
        public int? PK { get; set; }
    }
}
