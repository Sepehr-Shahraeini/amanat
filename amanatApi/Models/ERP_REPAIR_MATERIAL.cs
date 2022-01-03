using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_REPAIR_MATERIAL
    {
        public int ID { get; set; }
        public int? REPAIRPACKAGEID { get; set; }
        public int? TASKID { get; set; }
        public int CODEID { get; set; }
        public string REMARK { get; set; }
        public double? QUANTITY { get; set; }
        public string TITLE { get; set; }
        public int? ASSETID { get; set; }
        public double? COST { get; set; }
        public string PN { get; set; }
        public string MODEL { get; set; }
        public string SNBN { get; set; }
        public int? FAKEID { get; set; }
        public int? PASSETID { get; set; }
        public int? BRAND { get; set; }
        public string BRAND_STR { get; set; }
        public int? PAPERITEM { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
        public virtual ERP_CODING CODE { get; set; }
        public virtual ERP_ASSET PASSET { get; set; }
        public virtual ERP_REPAIRPACKAGE REPAIRPACKAGE { get; set; }
        public virtual ERP_REPAIR_TASK TASK { get; set; }
    }
}
