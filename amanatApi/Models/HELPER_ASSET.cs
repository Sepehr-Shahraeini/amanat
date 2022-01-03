using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class HELPER_ASSET
    {
        public int ASSET_ID { get; set; }
        public long? NLABEL { get; set; }
        public long? NLABEL2 { get; set; }
        public string CODE { get; set; }
        public string CODE_TITLE { get; set; }
        public int CODE_TYPE { get; set; }
        public string ASSETTYPE_STR { get; set; }
        public string BRAND_STR { get; set; }
        public string LABELTYPE_STR { get; set; }
        public string COUNTRY_STR { get; set; }
        public string QUANTITYUNIT_STR { get; set; }
        public string VALUETYPE_STR { get; set; }
        public string CURRENCY_STR { get; set; }
        public string EARNINGTYPE_STR { get; set; }
        public string CONDITION_STR { get; set; }
        public string USAGE_STR { get; set; }
        public string REC_PID { get; set; }
        public string REC_NAME { get; set; }
        public string ROOT_TITLE { get; set; }
        public string ROOT_CODE { get; set; }
        public string RECLOCATION_TITLE { get; set; }
        public string RECLOCATION_CODE { get; set; }
        public string RECLOCATION_PARENTCODE { get; set; }
        public int? RECLOC_LENGTH { get; set; }
        public int? RECLOCATION_TYPE { get; set; }
        public string LOC5_CODE { get; set; }
        public string LOC5_TITLE { get; set; }
        public string LOC7_CODE { get; set; }
        public string LOC7_TITLE { get; set; }
        public string PARENT_LABEL { get; set; }
        public string PARENT_SNBN { get; set; }
        public string PARENT_NAME { get; set; }
        public string EXTRACTFROM_LABEL { get; set; }
        public string EXTRACTFROM_SNBN { get; set; }
        public int IS_EXITED { get; set; }
        public int? EXIT_PAPERITEM { get; set; }
        public string MATERIAL_STR { get; set; }
        public string COLOR_STR { get; set; }
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
        public double? QUANTITY { get; set; }
        public double REMAIN { get; set; }
        public double RESERVEDQTY { get; set; }
        public double AVAILABLEQTY { get; set; }
    }
}
