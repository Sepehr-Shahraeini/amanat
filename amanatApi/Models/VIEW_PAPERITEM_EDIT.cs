using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_PAPERITEM_EDIT
    {
        public int ID { get; set; }
        public int PAPERID { get; set; }
        public double QUANTITY { get; set; }
        public double REMAIN { get; set; }
        public int ASSETID { get; set; }
        public double PRICE { get; set; }
        public double ORIGINAL_PRICE { get; set; }
        public int ASSETTYPE { get; set; }
        public int? QUANTITYUNIT { get; set; }
        public string DESCRIPTION { get; set; }
        public string REMARK { get; set; }
        public string QUANTITYUNIT_STR { get; set; }
        public int? CODEID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public decimal? LABEL { get; set; }
        public int? BRAND { get; set; }
        public string BRAND_STR { get; set; }
        public string SNBN { get; set; }
        public string PN { get; set; }
        public string MODEL { get; set; }
        public string AMLAK_SABTI_ASLI { get; set; }
        public string AMLAK_SABTI_FAREI { get; set; }
        public string AMLAK_VARAGHE_MALEKIAT { get; set; }
        public string KHODRO_ENTEZAMI { get; set; }
        public string KHODRO_MOTOR { get; set; }
        public string KHODRO_SHASI { get; set; }
        public string PHONE_NO { get; set; }
        public int? COUNTRY { get; set; }
        public string COUNTRY_STR { get; set; }
        public double? VALUE { get; set; }
        public int? CONDITION { get; set; }
        public string CONDITION_STR { get; set; }
        public int? SENDERLOCATIONID { get; set; }
        public int? LOCATIONTYPE { get; set; }
        public string SEN_LOCATIONCODE { get; set; }
        public string CURRENCY_STR { get; set; }
    }
}
