using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_MAKHZAN
    {
        public int ID { get; set; }
        public string LABEL { get; set; }
        public long? NLABEL { get; set; }
        public string NAME { get; set; }
        public string SNBN { get; set; }
        public int? CODEID { get; set; }
        public int CODETYPE { get; set; }
        public string CODE { get; set; }
        public int? EARNINGTYPE { get; set; }
        public string OLDOWNER { get; set; }
        public long? PURCHASEDATE { get; set; }
        public long? OPERATIONDATE { get; set; }
        public long? LETTERDATE { get; set; }
        public string LETTERNO { get; set; }
        public string LETTERSUBJECT { get; set; }
        public string SELLERNAME { get; set; }
        public string SELLERPHONE { get; set; }
        public string SELLERADDRESS { get; set; }
        public string DESCRIPTION { get; set; }
        public int? RECEIVERID { get; set; }
        public string REC_NAME { get; set; }
        public string REC_PID { get; set; }
        public int? ROOTLOCATION { get; set; }
        public int? RECLOCATIONID { get; set; }
        public string RECLOCATION_CODE { get; set; }
        public string RECLOCATION_TITLE { get; set; }
        public int? CONDITION { get; set; }
        public string CONDITION_TITLE { get; set; }
        public string TRACKINGNO { get; set; }
        public string AMLAK_SABTI_ASLI { get; set; }
        public string AMLAK_SABTI_FAREI { get; set; }
        public string AMLAK_VARAGHE_MALEKIAT { get; set; }
        public string KHODRO_MOTOR { get; set; }
        public string KHODRO_SHASI { get; set; }
        public string KHODRO_ENTEZAMI { get; set; }
        public int? KHODRO_NOTYPE { get; set; }
        public string PHONE_NO { get; set; }
        public string AMLAK_POSTALCODE { get; set; }
        public long? CREATEDATE { get; set; }
        public int? MAKHZAN_STATUS { get; set; }
        public int? MAKHZAN_NO { get; set; }
        public int? MAKHZAN_ID { get; set; }
    }
}
