using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ACCSITEM
    {
        public byte[] ID { get; set; }
        public int RADIF { get; set; }
        public int KOL { get; set; }
        public int MOEIN { get; set; }
        public int TAFZILI1 { get; set; }
        public int TAFZILI2 { get; set; }
        public int TAFZILI3 { get; set; }
        public int ACCNO { get; set; }
        public int BEDEHKAR { get; set; }
        public int BESTANKAR { get; set; }
        public int TASHKHIS { get; set; }
        public byte[] SANADID { get; set; }
        public byte[] RELATEDPAPERITEM { get; set; }
        public int? RELATEDASSETID { get; set; }

        public virtual ACCSANAD SANAD { get; set; }
    }
}
