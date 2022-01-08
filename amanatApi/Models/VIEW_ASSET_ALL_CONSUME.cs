﻿using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_ALL_CONSUME
    {
        public int ASSET_ID { get; set; }
        public string ASSET_LABEL { get; set; }
        public long? ASSET_NLABEL { get; set; }
        public string ASSET_NAME { get; set; }
        public string ASSET_SNBN { get; set; }
        public int? ASSET_CODEID { get; set; }
        public string ASSET_CODE { get; set; }
        public string ASSET_PN { get; set; }
        public string ASSET_MODEL { get; set; }
        public int? ASSET_BRAND { get; set; }
        public string ASSET_BRAND_STR { get; set; }
        public int ASSET_ASSETTYPE { get; set; }
        public string ASSET_ASSETTYPE_STR { get; set; }
        public int? ASSET_LABELTYPE { get; set; }
        public string ASSET_LABELTYPE_STR { get; set; }
        public string ASSET_OLDLABEL { get; set; }
        public string ASSET_LATINNAME { get; set; }
        public int? ASSET_COUNTRY { get; set; }
        public string ASSET_COUNTRY_STR { get; set; }
        public double? ASSET_QUANTITY { get; set; }
        public int? ASSET_QUANTITYUNIT { get; set; }
        public string ASSET_QUANTITYUNIT_STR { get; set; }
        public double? ASSET_QUALITY { get; set; }
        public int? ASSET_VALUETYPE { get; set; }
        public string ASSET_VALUETYPE_STR { get; set; }
        public double? ASSET_VALUE { get; set; }
        public double? ASSET_ARZI { get; set; }
        public int? ASSET_CURRENCY { get; set; }
        public string ASSET_CURRENCY_STR { get; set; }
        public double? ASSET_EXCHANGERATE { get; set; }
        public int? ASSET_EARNINGTYPE { get; set; }
        public string ASSET_EARNINGTYPE_STR { get; set; }
        public string ASSET_OLDOWNER { get; set; }
        public double? ASSET_BOOKVALUE { get; set; }
        public double? ASSET_SAVEDAMOUNT { get; set; }
        public double? ASSET_USEFULAGE { get; set; }
        public long? ASSET_PRODATE { get; set; }
        public long? ASSET_EXPDATE { get; set; }
        public DateTime? ASSET_PRODATEG { get; set; }
        public DateTime? ASSET_EXPDATEG { get; set; }
        public long? ASSET_PURCHASEDATE { get; set; }
        public long? ASSET_OPERATIONDATE { get; set; }
        public long? ASSET_LETTERDATE { get; set; }
        public string ASSET_LETTERNO { get; set; }
        public string ASSET_LETTERSUBJECT { get; set; }
        public string ASSET_SELLERNAME { get; set; }
        public string ASSET_SELLERPHONE { get; set; }
        public string ASSET_SELLERADDRESS { get; set; }
        public string ASSET_WARANTY { get; set; }
        public long? ASSET_WARANTYBEGINDATE { get; set; }
        public long? ASSET_WARANTYENDDATE { get; set; }
        public string ASSET_DESCRIPTION { get; set; }
        public int? ASSET_RECEIVERID { get; set; }
        public string ASSET_REC_PID { get; set; }
        public string ASSET_REC_NAME { get; set; }
        public int? ASSET_KEEPINGLOCATIONID { get; set; }
        public int? ASSET_ROOTLOCATION { get; set; }
        public string ASSET_ROOT_CODE { get; set; }
        public string ASSET_ROOT_TITLE { get; set; }
        public int ASSET_ISACTIVE { get; set; }
        public int? ASSET_RECLOCATIONID { get; set; }
        public string ASSET_RECLOCATION_CODE { get; set; }
        public string ASSET_RECLOCATION_PARENTCODE { get; set; }
        public int? ASSET_RECLOC_LENGTH { get; set; }
        public string ASSET_RECLOCATION_TITLE { get; set; }
        public int? RECLOCATION_TYPE { get; set; }
        public string LOC5_CODE { get; set; }
        public string LOC5_TITLE { get; set; }
        public string LOC7_CODE { get; set; }
        public string LOC7_TITLE { get; set; }
        public double ASSET_REMAIN { get; set; }
        public int? ASSET_CONDITION { get; set; }
        public string ASSET_CONDITION_STR { get; set; }
        public long? ASSET_CALCDATE { get; set; }
        public int? ASSET_MAINOWNER { get; set; }
        public int? ASSET_ID2 { get; set; }
        public int? ASSET_PARENTID { get; set; }
        public string ASSET_PARENT_LABEL { get; set; }
        public string ASSET_PARENT_SNBN { get; set; }
        public int? ASSET_EXTRACTFROMID { get; set; }
        public string ASSET_EXTRACTFROM_LABEL { get; set; }
        public string ASSET_EXTRACTFROM_SNBN { get; set; }
        public int? ASSET_MAINPLAKFAREIID { get; set; }
        public int? ASSET_PLAKASLITEMPLATEID { get; set; }
        public string ASSET_TRACKINGNO { get; set; }
        public int? ASSET_LASTPAPERITEMID { get; set; }
        public int? ASSET_SHELFFROM { get; set; }
        public int? ASSET_SHELFTO { get; set; }
        public long? ASSET_EXITDATE { get; set; }
        public int? ASSET_EXITREASON { get; set; }
        public string ASSET_EXITTO { get; set; }
        public int? ASSET_USAGE { get; set; }
        public string ASSET_USAGE_STR { get; set; }
        public string ASSET_POSTALCODE { get; set; }
        public string ASSET_SABTI_ASLI { get; set; }
        public string ASSET_SABTI_FAREI { get; set; }
        public string ASSET_VARAGHE_MALEKIAT { get; set; }
        public string ASSET_ENTEZAMI { get; set; }
        public string ASSET_MOTOR { get; set; }
        public int? ASSET_KHODRO_NOTYPE { get; set; }
        public string ASSET_SHASI { get; set; }
        public string ASSET_PHONE_NO { get; set; }
        public string RESISTANCEUNIT_STR { get; set; }
        public string AMPERUNIT_STR { get; set; }
        public string VOLTAGEUNIT_STR { get; set; }
        public string COURSEUNIT_STR { get; set; }
        public string POWERUNIT_STR { get; set; }
        public string PRESSUREUNIT_STR { get; set; }
        public string FORCEUNIT_STR { get; set; }
        public string WEIGHTUNIT_STR { get; set; }
        public string DIAMETERUNIT_STR { get; set; }
        public string LENGTHXUNIT_STR { get; set; }
        public string AREAUNIT_STR { get; set; }
        public string CAPACITYUNIT_STR { get; set; }
        public int? ASSET_ROOTASSETID { get; set; }
        public int? ASSET_MATERIAL { get; set; }
        public string ASSET_MATERIAL_STR { get; set; }
        public string ASSET_COLOR_STR { get; set; }
        public double? ASSET_LENGTHX { get; set; }
        public double? ASSET_DIAMETER { get; set; }
        public double? ASSET_AREA { get; set; }
        public double? ASSET_CAPACITY { get; set; }
        public double? ASSET_WEIGHT { get; set; }
        public double? ASSET_FORCE { get; set; }
        public double? ASSET_PRESSURE { get; set; }
        public double? ASSET_POWER { get; set; }
        public int? ASSET_COLOR { get; set; }
        public double? ASSET_COURSE { get; set; }
        public double? ASSET_VOLTAGE { get; set; }
        public double? ASSET_AMPER { get; set; }
        public double? ASSET_RESISTANCE { get; set; }
        public int? ASSET_RESISTANCEUNIT { get; set; }
        public int? ASSET_AMPERUNIT { get; set; }
        public int? ASSET_VOLTAGEUNIT { get; set; }
        public int? ASSET_COURSEUNIT { get; set; }
        public int? ASSET_POWERUNIT { get; set; }
        public int? ASSET_PRESSUREUNIT { get; set; }
        public int? ASSET_FORCEUNIT { get; set; }
        public int? ASSET_WEIGHTUNIT { get; set; }
        public int? ASSET_DIAMETERUNIT { get; set; }
        public int? ASSET_LENGTHXUNIT { get; set; }
        public int? ASSET_AREAUNIT { get; set; }
        public int? ASSET_CAPACITYUNIT { get; set; }
        public int CODE_TYPE { get; set; }
        public double RESERVEDQTY { get; set; }
        public double ASSET_AVAILABLEQTY { get; set; }
        public int IS_EXITED { get; set; }
        public int? EXIT_PAPERITEM { get; set; }
        public double? REPAIR_TOTALCOST { get; set; }
        public int EXP_REMAIN { get; set; }
    }
}
