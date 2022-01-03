using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ONOFFHISTORY
    {
        public int ID { get; set; }
        public int ASSETID { get; set; }
        public int? PARENTASSETID { get; set; }
        public int CONDITION { get; set; }
        public double? CYCLE { get; set; }
        public double? TIME { get; set; }
        public int? PAPERITEMID { get; set; }
        public int? REASON { get; set; }
        public string REMARK { get; set; }
        public int ONOFF_STATUS { get; set; }
        public long ONOFF_DATE { get; set; }
        public int CREATOR { get; set; }
        public DateTime? CREATEDATE { get; set; }
        public int? REPAIRPACKAGE { get; set; }
        public int? ALTERNATE { get; set; }
        public int? MATERIALID { get; set; }

        public virtual ERP_ASSET ALTERNATENavigation { get; set; }
        public virtual ERP_ASSET ASSET { get; set; }
        public virtual ERP_ASSET PARENTASSET { get; set; }
        public virtual ERP_REPAIRPACKAGE REPAIRPACKAGENavigation { get; set; }
    }
}
