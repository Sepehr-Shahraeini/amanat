using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ASSET_DEFECT
    {
        public ERP_ASSET_DEFECT()
        {
            ERP_REPAIR_TASKs = new HashSet<ERP_REPAIR_TASK>();
        }

        public int ID { get; set; }
        public int ASSETID { get; set; }
        public int DATE_REPORTED { get; set; }
        public int REPORTERID { get; set; }
        public int? PROBLEMID { get; set; }
        public string REMARK { get; set; }
        public string NO { get; set; }
        public int? TASKID { get; set; }
        public int? DATE_FIXED { get; set; }
        public int? APPREVERID { get; set; }
        public int? PACKAGEID { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
        public virtual ERP_REPAIR_PROBLEM PROBLEM { get; set; }
        public virtual ICollection<ERP_REPAIR_TASK> ERP_REPAIR_TASKs { get; set; }
    }
}
