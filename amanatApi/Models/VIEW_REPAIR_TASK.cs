using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_REPAIR_TASK
    {
        public int ID { get; set; }
        public int REPAIRPACKAGEID { get; set; }
        public string NO { get; set; }
        public int? TASKTYPEID { get; set; }
        public string REMARK { get; set; }
        public int IS_PREDICTED { get; set; }
        public int? PROBLEMID { get; set; }
        public string PROBLEMREMARK { get; set; }
        public string PROBLEMNO { get; set; }
        public string PROBLEM_TITLE { get; set; }
        public double? COST { get; set; }
        public int? OPERATORID { get; set; }
        public string OPERATOR_NAME { get; set; }
        public string OPERATOR_PID { get; set; }
        public string OPERATOR { get; set; }
        public int? DATE_SCHEDULESTART { get; set; }
        public int? DATE_SCHEDULEEND { get; set; }
        public int? DATE_ACTUALSTART { get; set; }
        public int? DATE_ACTUALEND { get; set; }
        public int? DELAY_REASONID { get; set; }
        public string DELAYREASON_TITLE { get; set; }
        public string DELAY_REMARK { get; set; }
        public int? DURATION_SCHEDULED { get; set; }
        public int? DURATION_ACTUAL { get; set; }
        public int? RELATEDTASKID { get; set; }
        public string RELATEDTASK_NO { get; set; }
        public double? COST_MATERIAL { get; set; }
        public int? WORKSHOPID { get; set; }
        public string WORKSHOP { get; set; }
        public string WORKSHOPADDRESS { get; set; }
        public string WORKSHOPPHONE { get; set; }
        public float? COSTEJARE { get; set; }
        public int? REFID { get; set; }
        public string REFTITLE { get; set; }
        public string REFCATEGORY { get; set; }
        public int? REFCODEID { get; set; }
        public string REFCODETITLE { get; set; }
        public string REFCODE { get; set; }
        public int? FAKEID { get; set; }
        public string PACKAGE_NO { get; set; }
        public int ASSET_ID { get; set; }
        public string ASSET_LABEL { get; set; }
        public long? ASSET_NLABEL { get; set; }
        public string ASSET_NAME { get; set; }
        public int? PACKAGE_DATE_CLOSED { get; set; }
        public int PACKAGE_IS_CLOSED { get; set; }
        public double? NETCOST { get; set; }
    }
}
