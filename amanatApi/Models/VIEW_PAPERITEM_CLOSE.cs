using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_PAPERITEM_CLOSE
    {
        public int PI_ID { get; set; }
        public int P_ID { get; set; }
        public double PI_QUANTITY { get; set; }
        public int PI_ASSETID { get; set; }
        public int? PI_SENDERID { get; set; }
        public string PI_SENDER_PID { get; set; }
        public string PI_SENDER_NAME { get; set; }
        public int? PI_SENDERLOCATIONID { get; set; }
        public string PI_SENDERLOCATION_TITLE { get; set; }
        public string PI_SENDERLOCATION_CODE { get; set; }
        public int? PI_SENDERROOTLOCATIONID { get; set; }
        public int? PI_QUANTITYUNIT { get; set; }
        public string PI_DESCRIPTION { get; set; }
        public string PI_QUANTITYUNIT_STR { get; set; }
        public string ASSET_NAME { get; set; }
        public decimal? ASSET_LABEL { get; set; }
        public int? ASSET_BRAND { get; set; }
        public string ASSET_BRAND_STR { get; set; }
        public string ASSET_SNBN { get; set; }
        public string ASSET_PN { get; set; }
        public string ASSET_MODEL { get; set; }
        public string ASSET_SABTI_ASLI { get; set; }
        public string ASSET_SABTI_FAREI { get; set; }
        public string ASSET_VARAGHE_MALEKIAT { get; set; }
        public string ASSET_ENTEZAMI { get; set; }
        public string ASSET_MOTOR { get; set; }
        public string ASSET_SHASI { get; set; }
        public string ASSET_PHONE_NO { get; set; }
        public int? ASSET_COUNTRY { get; set; }
        public string ASSET_COUNTRY_STR { get; set; }
        public double? ASSET_VALUE { get; set; }
    }
}
