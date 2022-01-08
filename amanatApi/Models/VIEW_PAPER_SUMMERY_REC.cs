using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_PAPER_SUMMERY_REC
    {
        public int PAPERTYPE { get; set; }
        public int? RECLOCATIONID { get; set; }
        public double QUANTITY { get; set; }
        public int ASSETID { get; set; }
        public int? CODEID { get; set; }
        public string ASSETNAME { get; set; }
        public int? PAPERDATE { get; set; }
        public string DYEAR { get; set; }
        public string DMONTH { get; set; }
    }
}
