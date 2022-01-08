using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_REPAIR_RMATERIAL
    {
        public int ID { get; set; }
        public int? REPAIRPACKAGEID { get; set; }
        public int? TASKID { get; set; }
        public string NO { get; set; }
        public string REFTITLE { get; set; }
        public string REFCATEGORY { get; set; }
        public string PACKAGE_NO { get; set; }
        public int? TASK_ASSETID { get; set; }
        public string TASK_ASSETLABEL { get; set; }
        public long? TASK_ASSETNLABEL { get; set; }
        public string TASK_ASSET_NAME { get; set; }
        public int? TASK_DATE_ACTUALEND { get; set; }
        public int TASK_ASSETCODEID { get; set; }
        public string TASK_ASSETCODE { get; set; }
        public int CODEID { get; set; }
        public string CODE { get; set; }
        public string CODETITLE { get; set; }
        public string REMARK { get; set; }
        public double? QUANTITY { get; set; }
        public string ASSET_NAME { get; set; }
        public int? ASSETID { get; set; }
        public double? COST { get; set; }
        public string ASSET_PN { get; set; }
        public string ASSET_MODEL { get; set; }
        public string ASSET_SNBN { get; set; }
        public string ASSET_BRAND_STR { get; set; }
        public string ASSET_LABEL { get; set; }
        public int? FAKEID { get; set; }
        public int? PASSETID { get; set; }
        public int? DATE_CLOSED { get; set; }
    }
}
