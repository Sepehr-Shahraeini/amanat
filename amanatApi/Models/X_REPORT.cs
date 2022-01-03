using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class X_REPORT
    {
        public byte[] ID { get; set; }
        public string TITLE { get; set; }
        public int CREATOR { get; set; }
        public byte[] SETTING { get; set; }
        public int PUBLICREPORT { get; set; }
        public string TABLENAME { get; set; }
        public string CATEGORY { get; set; }
        public int TAJMI { get; set; }
    }
}
