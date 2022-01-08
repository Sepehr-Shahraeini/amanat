using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_PAPER_REPORT
    {
        public string P_FULLNO { get; set; }
        public int? P_PAPERDATE { get; set; }
        public string P_SEN_LOCATION_TITLE { get; set; }
        public string P_SEN_LOCATION_CODE { get; set; }
        public string P_REC_LOCATION_CODE { get; set; }
        public string P_REC_LOCATION_TITLE { get; set; }
        public string P_REC_USER_NAME { get; set; }
        public string P_REC_USER_PID { get; set; }
        public string P_SEN_USER_NAME { get; set; }
        public string P_SEN_USER_PID { get; set; }
        public string P_SEN_AMIN_NAME { get; set; }
        public string P_SEN_AMIN_PID { get; set; }
        public string P_SEN_RES_NAME { get; set; }
        public string P_SEN_RES_PID { get; set; }
        public string ASSET_CODE { get; set; }
        public string ASSET_NAME { get; set; }
        public string ASSET_BRAND_STR { get; set; }
        public string ASSET_MODEL { get; set; }
        public string ASSET_COUNTRY_STR { get; set; }
        public string ASSET_SNBN { get; set; }
        public string ASSET_LABEL { get; set; }
        public long? ASSET_NLABEL { get; set; }
        public string ASSET_QUANTITYUNIT_STR { get; set; }
        public int ASSET_ASSETTYPE { get; set; }
        public string ASSET_ASSETTYPE_STR { get; set; }
        public string ASSET_CURRENCY_STR { get; set; }
        public double PI_QUANTITY { get; set; }
        public string PI_QUANTITYUNIT_STR { get; set; }
        public string P_REC_AMIN_NAME { get; set; }
        public string P_REC_AMIN_PID { get; set; }
        public string P_DESCRIPTION { get; set; }
        public double? PI_PRICE { get; set; }
        public double? PI_TOTALPRICE { get; set; }
        public string P_REC_RES_NAME { get; set; }
        public string P_REC_RES_PID { get; set; }
        public string ASSET_PN { get; set; }
        public string P_SEN_HAMIN_NAME { get; set; }
        public string P_SEN_HAMIN_PID { get; set; }
        public string KASR_REASON_STR { get; set; }
        public int? KASR_DATE { get; set; }
        public int? P_LICENCE_DATE { get; set; }
        public string P_LICENCE_NO { get; set; }
        public string P_LICENCE_CREATOR { get; set; }
        public string HOGHUGHI_USER_NAME { get; set; }
        public string HOGHUGHI_USER_PID { get; set; }
        public int PI_ID { get; set; }
        public int P_ID { get; set; }
        public int? CORRECTED { get; set; }
        public int? STATUS { get; set; }
        public int? ASSET_PARENTID { get; set; }
    }
}
