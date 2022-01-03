using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTUSERSELECTEDCOLUMN
    {
        public byte[] ID { get; set; }
        public byte[] REPORTITEMID { get; set; }
        public int? USERID { get; set; }
        public byte[] REPORTXID { get; set; }
        public int ORDERINDEX { get; set; }
        public string PIVOTGRIDLOCATION { get; set; }
        public string PIVOTSUMMARTTYPE { get; set; }
        public string SUMMARYTYPE { get; set; }
        public int? COLUMNWIDTH { get; set; }
        public double? COLUMNPERCENTWIDTH { get; set; }
        public string COLUMNFONTNAME { get; set; }
        public string COLUMNHEADERFONTNAME { get; set; }
        public int COLUMNFONTSIZE { get; set; }
        public int COLUMNHEADERFONTSIZE { get; set; }
        public int COUMNFONTBOLD { get; set; }
        public int COLUMNHEADERFONTBOLD { get; set; }
        public string TEMPLATENAME { get; set; }
        public int TAJMI { get; set; }
        public string TAJMISUMMARYTYPE { get; set; }
        public byte[] REPORTSETTINGID { get; set; }
        public string BRANCHKEY { get; set; }
    }
}
