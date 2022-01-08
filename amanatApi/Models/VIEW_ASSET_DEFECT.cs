using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_DEFECT
    {
        public int ID { get; set; }
        public int ASSETID { get; set; }
        public string LABEL { get; set; }
        public string NAME { get; set; }
        public string KHODRO_MOTOR { get; set; }
        public string KHODRO_SHASI { get; set; }
        public string KHODRO_ENTEZAMI { get; set; }
        public string AMLAK_SABTI_ASLI { get; set; }
        public string AMLAK_SABTI_FAREI { get; set; }
        public int? BRAND { get; set; }
        public string BRAND_TITLE { get; set; }
        public string MODEL { get; set; }
        public string PN { get; set; }
        public string SNBN { get; set; }
        public int? RECEIVERID { get; set; }
        public string REC_NAME { get; set; }
        public string REC_PID { get; set; }
        public int? RECLOCATIONID { get; set; }
        public string RECLOC_CODE { get; set; }
        public string RECLOC_TITLE { get; set; }
        public int? ROOTLOCATION { get; set; }
        public int? COUNTRY { get; set; }
        public int CODETYPE { get; set; }
        public string COUNTRY_TITLE { get; set; }
        public int DATE_REPORTED { get; set; }
        public int REPORTERID { get; set; }
        public int? PROBLEMID { get; set; }
        public string PROBLEM_CATEGORY { get; set; }
        public string PROBLEM_TITLE { get; set; }
        public int? PROBLEM_CODETYPE { get; set; }
        public string PROBLEM_REMARK { get; set; }
        public string REMARK { get; set; }
        public string NO { get; set; }
        public int? TASKID { get; set; }
        public string TASKNO { get; set; }
        public string PACKAGE_NO { get; set; }
        public int? REPAIRPACKAGEID { get; set; }
        public int NETCOST { get; set; }
        public int? DATE_ACTUALEND { get; set; }
        public int? PACKAGE_DATE_CLOSED { get; set; }
        public int? PACKAGE_IS_CLOSED { get; set; }
        public int? STATUS { get; set; }
        public string STATUS_STR { get; set; }
        public int? DATE_FIXED { get; set; }
        public int? APPREVERID { get; set; }
        public string APPROVER_NAME { get; set; }
        public string APPROVER_PID { get; set; }
    }
}
