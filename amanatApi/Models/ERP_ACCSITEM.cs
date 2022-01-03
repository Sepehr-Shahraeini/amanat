using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ACCSITEM
    {
        public int RADIF { get; set; }
        public int KOL { get; set; }
        public int MOEIN { get; set; }
        public int TAFZILI1 { get; set; }
        public int TAFZILI2 { get; set; }
        public int TAFZILI3 { get; set; }
        public int ACCNO { get; set; }
        public double BEDEHKAR { get; set; }
        public double BESTANKAR { get; set; }
        public int TASHKHIS { get; set; }
        public int SANADID { get; set; }
        public int? PAPERITEMID { get; set; }
        public int ID { get; set; }

        public virtual ERP_PAPERITEM PAPERITEM { get; set; }
        public virtual ERP_ACCSANAD SANAD { get; set; }
    }
}
