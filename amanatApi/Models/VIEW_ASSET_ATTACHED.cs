using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_ATTACHED
    {
        public int ASSET_ID { get; set; }
        public int? ASSET_CODEID { get; set; }
        public int? ASSET_PARENTID { get; set; }
        public string ASSET_LABEL { get; set; }
        public string ASSET_NAME { get; set; }
        public string ASSET_MOTOR { get; set; }
        public string ASSET_SHASI { get; set; }
        public string ASSET_ENTEZAMI { get; set; }
        public string ASSET_SABTI_ASLI { get; set; }
        public string ASSET_SABTI_FAREI { get; set; }
        public string ASSET_PHONE_NO { get; set; }
        public string ASSET_VARAGHE_MALEKIAT { get; set; }
        public int? ASSET_BRAND { get; set; }
        public string ASSET_BRAND_STR { get; set; }
        public string ASSET_MODEL { get; set; }
        public string ASSET_PN { get; set; }
        public string ASSET_SNBN { get; set; }
        public int? RECEIVERID { get; set; }
        public string ASSET_REC_NAME { get; set; }
        public string ASSET_REC_PID { get; set; }
        public int? RECLOCATIONID { get; set; }
        public string ASSET_RECLOCATION_CODE { get; set; }
        public string ASSET_RECLOCATION_TITLE { get; set; }
        public int? ROOTLOCATION { get; set; }
        public int? COUNTRY { get; set; }
        public string COUNTRY_TITLE { get; set; }
        public int CODETYPE { get; set; }
        public string PARENT_NAME { get; set; }
        public string PARENT_LABEL { get; set; }
        public string PARENT_REC_PID { get; set; }
        public string PARENT_REC_NAME { get; set; }
        public string PARENT_RECLOC_CODE { get; set; }
        public string PARENT_RECLOC_TITLE { get; set; }
        public int? PARENT_REC_ID { get; set; }
        public int? PARENT_RECLOC_ID { get; set; }
        public string PACKAGE_NO { get; set; }
        public int? ONPACKAGE_DATE_CLOSED { get; set; }
        public int? ONPACKAGEID { get; set; }
        public int? ONPAPERID { get; set; }
        public string ONPAPERNO { get; set; }
        public int? ONPAPERDATE { get; set; }
        public double? QUANTITY { get; set; }
        public int? OPEN_PACKAGE { get; set; }
    }
}
