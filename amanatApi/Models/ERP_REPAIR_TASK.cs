using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_REPAIR_TASK
    {
        public ERP_REPAIR_TASK()
        {
            ERP_REPAIR_MATERIALs = new HashSet<ERP_REPAIR_MATERIAL>();
            ERP_REPAIR_RMATERIALs = new HashSet<ERP_REPAIR_RMATERIAL>();
            ERP_REPAIR_TASK_OPERATORs = new HashSet<ERP_REPAIR_TASK_OPERATOR>();
        }

        public int ID { get; set; }
        public int REPAIRPACKAGEID { get; set; }
        public string NO { get; set; }
        public int? TASKTYPEID { get; set; }
        public string REMARK { get; set; }
        public int IS_PREDICTED { get; set; }
        public int? PROBLEMID { get; set; }
        public double? COST { get; set; }
        public int? OPERATORID { get; set; }
        public string OPERATOR { get; set; }
        public long? DATE_SCHEDULESTART { get; set; }
        public long? DATE_SCHEDULEEND { get; set; }
        public long? DATE_ACTUALSTART { get; set; }
        public long? DATE_ACTUALEND { get; set; }
        public long? DELAY_REASONID { get; set; }
        public string DELAY_REMARK { get; set; }
        public int? DURATION_SCHEDULED { get; set; }
        public int? DURATION_ACTUAL { get; set; }
        public int? RELATEDTASKID { get; set; }
        public double? COST_MATERIAL { get; set; }
        public int? WORKSHOPID { get; set; }
        public string WORKSHOP { get; set; }
        public string WORKSHOPADDRESS { get; set; }
        public string WORKSHOPPHONE { get; set; }
        public float? COSTEJARE { get; set; }
        public int? REFID { get; set; }
        public int? FAKEID { get; set; }

        public virtual ERP_ASSET_DEFECT PROBLEM { get; set; }
        public virtual ERP_REPAIRPACKAGE REPAIRPACKAGE { get; set; }
        public virtual ICollection<ERP_REPAIR_MATERIAL> ERP_REPAIR_MATERIALs { get; set; }
        public virtual ICollection<ERP_REPAIR_RMATERIAL> ERP_REPAIR_RMATERIALs { get; set; }
        public virtual ICollection<ERP_REPAIR_TASK_OPERATOR> ERP_REPAIR_TASK_OPERATORs { get; set; }
    }
}
