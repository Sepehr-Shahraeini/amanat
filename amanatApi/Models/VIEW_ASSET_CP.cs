using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_CP
    {
        public string ASSET_CODE { get; set; }
        public int ASSET_CODEID { get; set; }
        public string ASSET_NAME { get; set; }
        public int ASSET_RECLOCATIONID { get; set; }
        public string ASSET_RECLOCATION_CODE { get; set; }
        public string ASSET_RECLOCATION_TITLE { get; set; }
        public double? AVAILABLEQTY { get; set; }
        public double? MINSTOCKPOINT { get; set; }
        public double? MAXSTOCKPOINT { get; set; }
        public double? REORDERPOINT { get; set; }
        public double? ECONOMICSMOUNT { get; set; }
        public int ALERT_STATUS { get; set; }
    }
}
