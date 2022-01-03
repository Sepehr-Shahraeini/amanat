using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_REPAIR_TASK_OPERATOR
    {
        public int ID { get; set; }
        public int? OPERATORID { get; set; }
        public string OPERATOR { get; set; }
        public string REMARK { get; set; }
        public int TASKID { get; set; }
        public int? DURATION_SCHEDULE { get; set; }
        public int? DURATION_ACTUAL { get; set; }
        public float? COST { get; set; }
        public int? DELAY_REASON { get; set; }

        public virtual ERP_REPAIR_TASK TASK { get; set; }
    }
}
