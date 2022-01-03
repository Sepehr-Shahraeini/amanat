using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTSETTING
    {
        public byte[] ID { get; set; }
        public string TITLE { get; set; }
        public int? CREATORID { get; set; }
        public int? ROOTLOCATION { get; set; }
        public int ISGENERAL { get; set; }
        public byte[] REPORTID { get; set; }
    }
}
