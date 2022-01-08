using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_ABS_ALL
    {
        public int ID { get; set; }
        public string LABEL { get; set; }
        public long? NLABEL { get; set; }
        public string NAME { get; set; }
        public string SNBN { get; set; }
        public int? CODEID { get; set; }
        public string PN { get; set; }
        public string MODEL { get; set; }
        public int? BRAND { get; set; }
        public string BRAND_STR { get; set; }
        public int ASSETTYPE { get; set; }
        public string LATINNAME { get; set; }
        public int? COUNTRY { get; set; }
        public string COUNTRY_STR { get; set; }
        public double? QUANTITY { get; set; }
        public int? QUANTITYUNIT { get; set; }
        public double? VALUE { get; set; }
        public int? CURRENCY { get; set; }
        public long? PRODATE { get; set; }
        public long? EXPDATE { get; set; }
        public long? PURCHASEDATE { get; set; }
        public long? OPERATIONDATE { get; set; }
        public int? RECEIVERID { get; set; }
        public int? KEEPINGLOCATIONID { get; set; }
        public int? ROOTLOCATION { get; set; }
        public int ISACTIVE { get; set; }
        public int? RECLOCATIONID { get; set; }
        public double REMAIN { get; set; }
        public int? CONDITION { get; set; }
        public string CONDITION_STR { get; set; }
        public int? PARENTID { get; set; }
        public int? EXTRACTFROMID { get; set; }
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
        public int CSUM { get; set; }
        public int IS_EXITED { get; set; }
        public double? LENGTHX { get; set; }
        public double? DIAMETER { get; set; }
        public double? AREA { get; set; }
        public double? CAPACITY { get; set; }
        public double? WEIGHT { get; set; }
        public double? FORCE { get; set; }
        public double? PRESSURE { get; set; }
        public double? POWER { get; set; }
        public int? COLOR { get; set; }
        public double? COURSE { get; set; }
        public double? VOLTAGE { get; set; }
        public double? AMPER { get; set; }
        public double? RESISTANCE { get; set; }
        public int? MATERIAL { get; set; }
        public string USAGE_STR { get; set; }
        public string MATERIAL_STR { get; set; }
        public string COLOR_STR { get; set; }
        public int? USAGE { get; set; }
        public int? RECLOCATION_TYPE { get; set; }
    }
}
