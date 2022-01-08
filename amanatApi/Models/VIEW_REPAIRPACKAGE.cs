using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_REPAIRPACKAGE
    {
        public int ID { get; set; }
        public int? CREATE_DATE { get; set; }
        public string NO { get; set; }
        public double? COST { get; set; }
        public double? TAKHFIF { get; set; }
        public double? HAML { get; set; }
        public double? MALIAT { get; set; }
        public int? DATE_SCHEDULESTART { get; set; }
        public int? DATE_SCHEDULEEND { get; set; }
        public int? DATE_ACTUALSTART { get; set; }
        public int? DATE_ACTUALEND { get; set; }
        public int? DURATION_SCHEDULE { get; set; }
        public int? DURATION_ACTUAL { get; set; }
        public string REMARK { get; set; }
        public string INVOICE_NO { get; set; }
        public int? DATE_INVOICE { get; set; }
        public int? DELAY_REASON { get; set; }
        public string DELAY_REASON_TITLE { get; set; }
        public string DELAY_REMARK { get; set; }
        public int? MANAGERID { get; set; }
        public string MANAGER_PID { get; set; }
        public string MANAGER_NAME { get; set; }
        public string WORKSHOP { get; set; }
        public string WORKSHOP_ADDRESS { get; set; }
        public string WORKSHOP_PHONE { get; set; }
        public int? APPROVERID { get; set; }
        public string APPROVER_PID { get; set; }
        public string APPROVER_NAME { get; set; }
        public int? OPERATORID { get; set; }
        public string OPERATOR_NAME { get; set; }
        public string OPERATOR_PID { get; set; }
        public int? TAHVILDAHANDEID { get; set; }
        public string TAHVILDAHANDE_PID { get; set; }
        public string TAHVILDAHANDE_NAME { get; set; }
        public int? RECEIVERID { get; set; }
        public string RECEIVER_PID { get; set; }
        public string RECEIVER_NAME { get; set; }
        public int ASSETID { get; set; }
        public string ASSET_LABEL { get; set; }
        public string ASSET_NAME { get; set; }
        public long? ASSET_NLABEL { get; set; }
        public string ASSET_SNBN { get; set; }
        public int ASSET_CODEID { get; set; }
        public string ASSET_CODE { get; set; }
        public string ASSET_PN { get; set; }
        public string ASSET_MODEL { get; set; }
        public int? ASSET_BRAND { get; set; }
        public string ASSET_BRAND_STR { get; set; }
        public int? ASSET_COUNTRY { get; set; }
        public string ASSET_COUNTRY_STR { get; set; }
        public string ASSET_SHASI { get; set; }
        public string ASSET_MOTOR { get; set; }
        public string ASSET_ENTEZAMI { get; set; }
        public string MAHRAMANENO { get; set; }
        public string ASSET_SABTI_ASLI { get; set; }
        public string ASSET_SABTI_FAREI { get; set; }
        public long? ASSET_PRODATE { get; set; }
        public int ASSET_RECEIVERID { get; set; }
        public string ASSET_REC_PID { get; set; }
        public string ASSET_REC_NAME { get; set; }
        public int ASSET_RECLOCATIONID { get; set; }
        public string ASSET_RECLOCATION_CODE { get; set; }
        public string ASSET_RECLOCATION_TITLE { get; set; }
        public int ASSET_ROOTLOCATION { get; set; }
        public double? REPAIR_TOTALCOST { get; set; }
        public double? ASSET_TAHVIL_COUNTER { get; set; }
        public int? ASSET_CONDITION { get; set; }
        public int? REASON { get; set; }
        public string REASON_TITLE { get; set; }
        public string REASON_REMARK { get; set; }
        public float? COSTMATERIAL { get; set; }
        public float? COSTEJARE { get; set; }
        public int? IS_OUTSOURCE { get; set; }
        public string OUTSOURCE_STR { get; set; }
        public int? WORKSHOPID { get; set; }
        public string WORKSHOP_TITLE { get; set; }
        public string WORKSHOP_NAME { get; set; }
        public int? DATE_TAHVIL { get; set; }
        public int? DATE_RECEIVE { get; set; }
        public int? DATE_APPROVE { get; set; }
        public int CREATOR { get; set; }
        public string CREATOR_PID { get; set; }
        public string CREATOR_NAME { get; set; }
        public int CREATORLOC { get; set; }
        public string CREATORLOC_CODE { get; set; }
        public string CREATORLOC_TITLE { get; set; }
        public int? DATE_CLOSED { get; set; }
        public int IS_CLOSED { get; set; }
        public int STATUS { get; set; }
        public string STATUS_STR { get; set; }
        public int? DAYS_FROMSTART { get; set; }
        public int? DAYS_TOEND { get; set; }
        public int? DAYS_DELAY_START { get; set; }
        public int? DAYS_DELAY_END { get; set; }
        public double? NETCOST { get; set; }
        public int REPAIRTYPE { get; set; }
        public string REPAIRTYPE_STR { get; set; }
        public string XPARTS { get; set; }
    }
}
