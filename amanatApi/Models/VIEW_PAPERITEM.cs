using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_PAPERITEM
    {
        public int PI_ID { get; set; }
        public int PI_PAPERID { get; set; }
        public int PI_CODEID { get; set; }
        public string PI_CODE { get; set; }
        public string PI_ASSETTITLE { get; set; }
        public double PI_QUANTITY { get; set; }
        public float? PI_INIT_QTY { get; set; }
        public int PI_ASSETID { get; set; }
        public string PI_ASSETLABEL { get; set; }
        public double PI_PRICE { get; set; }
        public string PI_REASON { get; set; }
        public int? STATUS { get; set; }
        public string STATUS_STR { get; set; }
        public int? STATUS_BY { get; set; }
        public string STATUS_BY_NAME { get; set; }
        public string STATUS_BY_PIDS { get; set; }
        public int? STATUS_DATE { get; set; }
        public string STATUS_DATE_F { get; set; }
        public int? PI_RELATEDPAPERITEM { get; set; }
        public int? PI_RELATEDPAPER_FULLNO { get; set; }
        public int? PI_RECID { get; set; }
        public string PI_REC_PID { get; set; }
        public string PI_REC_NAME { get; set; }
        public int? PI_RECLOCATIONID { get; set; }
        public string PI_RECLOCATION_TITLE { get; set; }
        public string PI_RECLOCATION_CODE { get; set; }
        public int? PI_SENDERID { get; set; }
        public string PI_SENDER_PID { get; set; }
        public string PI_SENDER_NAME { get; set; }
        public int? PI_SENDERLOCATIONID { get; set; }
        public string PI_SENDERLOCATION_TITLE { get; set; }
        public string PI_SENDERLOCATION_CODE { get; set; }
        public int? PI_SENDERROOTLOCATIONID { get; set; }
        public int? PI_PN_ID { get; set; }
        public int? PI_PN_STR { get; set; }
        public string PI_PN { get; set; }
        public int? PI_QUANTITYUNIT { get; set; }
        public string PI_QUANTITYUNIT_STR { get; set; }
        public int? PI_REQUESTITEM_ID { get; set; }
        public int? PI_REQUEST_FULLNO { get; set; }
        public int? PI_TEMP_DELIVERYITEM_ID { get; set; }
        public int? PI_TEMP_DELIVERY_FULLNO { get; set; }
        public int? PI_CONDITION { get; set; }
        public string PI_CONDITION_STR { get; set; }
        public int? PI_TASKID { get; set; }
        public int? PI_TASK_STR { get; set; }
        public int PI_DELETED { get; set; }
        public string PI_DELETEREASON { get; set; }
        public string PI_DESCRIPTION { get; set; }
        public string PI_MODEL { get; set; }
        public string PI_BRAND { get; set; }
        public int? PI_DELIVERYDATE { get; set; }
        public string PI_SNBN { get; set; }
        public int? KASR_RETURN_DATE { get; set; }
        public string KASR_RETURN_DATE_F { get; set; }
        public int KASR_RETURNED { get; set; }
        public string KASR_RETURNED_STR { get; set; }
    }
}
