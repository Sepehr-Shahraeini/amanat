using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_PAPER_LIST_M
    {
        public int PI_ID { get; set; }
        public int ASSET_ID { get; set; }
        public int? ASSET_RECLOCATIONID { get; set; }
        public int? ASSET_RECEIVERID { get; set; }
        public int? ASSET_CODEID { get; set; }
        public string ASSET_CODE { get; set; }
        public int P_ID { get; set; }
        public double PI_QUANTITY { get; set; }
        public double PI_PRICE { get; set; }
        public double PI_TOTALPRICE { get; set; }
        public int P_PAPERTYPE { get; set; }
        public string P_PAPERTYPE_STR { get; set; }
        public string P_FULLNO { get; set; }
        public int? P_PAPERDATE { get; set; }
        public int? P_REC_USER { get; set; }
        public string P_REC_USER_PID { get; set; }
        public string P_REC_USER_NAME { get; set; }
        public int? P_REC_LOCATION { get; set; }
        public string P_REC_LOCATION_TITLE { get; set; }
        public string P_REC_LOCATION_CODE { get; set; }
        public int? P_REC_LOCATIONTYPE { get; set; }
        public int? PI_SENDERID { get; set; }
        public string PI_SENDER_PID { get; set; }
        public string PI_SENDER_NAME { get; set; }
        public int? PI_SENDERLOCATIONID { get; set; }
        public string PI_SENDERLOCATION_TITLE { get; set; }
        public string PI_SENDERLOCATION_CODE { get; set; }
        public int? P_SEN_USER { get; set; }
        public string P_SEN_USER_PID { get; set; }
        public string P_SEN_USER_NAME { get; set; }
        public int? P_SEN_LOCATION { get; set; }
        public string P_SEN_LOCATION_TITLE { get; set; }
        public string P_SEN_LOCATION_CODE { get; set; }
        public int? P_SEN_LOCATIONTYPE { get; set; }
        public int? P_SEN_AMIN_USER { get; set; }
        public string P_SEN_AMIN_PID { get; set; }
        public string P_SEN_AMIN_NAME { get; set; }
        public int? P_REC_AMIN_USER { get; set; }
        public string P_REC_AMIN_PID { get; set; }
        public string P_REC_AMIN_NAME { get; set; }
        public string ASSET_LABEL { get; set; }
        public long? ASSET_NLABEL { get; set; }
        public string ASSET_SABTI_ASLI { get; set; }
        public string ASSET_SABTI_FAREI { get; set; }
        public string ASSET_ENTEZAMI { get; set; }
        public string ASSET_MOTOR { get; set; }
        public string ASSET_SHASI { get; set; }
        public string ASSET_PHONE_NO { get; set; }
        public int? ASSET_USAGE { get; set; }
        public string ASSET_USAGE_STR { get; set; }
        public int? ASSET_CURRENCY { get; set; }
        public string ASSET_CURRENCY_STR { get; set; }
        public int? ASSET_EARNINGTYPE { get; set; }
        public string ASSET_EARNINGTYPE_STR { get; set; }
        public int? ASSET_VALUETYPE { get; set; }
        public string ASSET_VALUETYPE_STR { get; set; }
        public string ASSET_NAME { get; set; }
        public double ASSET_AVAILABLEQTY { get; set; }
        public int ASSET_ASSETTYPE { get; set; }
        public string ASSET_ASSETTYPE_STR { get; set; }
        public string ASSET_LATINNAME { get; set; }
        public string ASSET_SNBN { get; set; }
        public string ASSET_COUNTRY_STR { get; set; }
        public int? ASSET_COUNTRY { get; set; }
        public string ASSET_MODEL { get; set; }
        public string SELLERADDRESS { get; set; }
        public string SELLERNAME { get; set; }
        public string SELLERPHONE { get; set; }
        public int? ASSET_BRAND { get; set; }
        public string ASSET_BRAND_STR { get; set; }
        public int? ASSET_CONDITION { get; set; }
        public string ASSET_CONDITION_STR { get; set; }
        public string ASSET_PN { get; set; }
        public int ELAPSED { get; set; }
        public int P_ACTIVE { get; set; }
        public int? PI_CONDITION { get; set; }
        public string PI_CONDITION_STR { get; set; }
        public string TRACKINGNO { get; set; }
        public string ASSET_COLOR_STR { get; set; }
        public int? P_SEN_RES_USER { get; set; }
        public string P_SEN_RES_PID { get; set; }
        public string P_SEN_RES_NAME { get; set; }
        public int? P_REC_RES_USER { get; set; }
        public string P_REC_RES_PID { get; set; }
        public string P_REC_RES_NAME { get; set; }
        public string P_DESCRIPTION { get; set; }
        public int? P_CREATOR { get; set; }
        public string P_CREATOR_PID { get; set; }
        public string P_CREATOR_NAME { get; set; }
        public int P_CREATEDATE { get; set; }
        public int? ASSET_QUANTITYUNIT { get; set; }
        public string ASSET_QUANTITYUNIT_STR { get; set; }
        public int? BUYFOR { get; set; }
        public string BUYFORCODE { get; set; }
        public string BUYFORTITLE { get; set; }
    }
}
