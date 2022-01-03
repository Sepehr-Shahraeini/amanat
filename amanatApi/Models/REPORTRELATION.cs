using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTRELATION
    {
        public byte[] ID { get; set; }
        public byte[] REPORTITEMID1 { get; set; }
        public byte[] REPORTITEMID2 { get; set; }
        public string REPORTITEM1_FUNCTION { get; set; }
        public string REPORTITEM2_FUNCTION { get; set; }
    }
}
