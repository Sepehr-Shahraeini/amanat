using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ERP_CODING_DET
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int CODE { get; set; }
        public string FULLCODE { get; set; }
        public decimal? NFULLCODE { get; set; }
        public string PARENT_FULLCODE { get; set; }
        public int? PARENT_PARENTID { get; set; }
        public int? PARENT_ASSETTYPE { get; set; }
        public int? PARENT_MODEL { get; set; }
        public int? PARENT_SN { get; set; }
        public int? PARENT_FACTORY { get; set; }
        public int? PARENT_LATINNAME { get; set; }
        public int? PARENT_PN { get; set; }
        public int? PARENT_ASSET_TYPE { get; set; }
        public int? PARENT_MATERIAL { get; set; }
        public int? PARENT_COLOR { get; set; }
        public int? PARENT_CODETYPE { get; set; }
        public double? PARENT_DEPRATE { get; set; }
        public int? PARENT_DEPTYPE { get; set; }
        public int? PARENTID { get; set; }
        public int CODETYPE { get; set; }
        public double? DEPRATE { get; set; }
        public int? DEPTYPE { get; set; }
        public string DEPTYPE_STR { get; set; }
        public int ASSETTYPE { get; set; }
        public string ASSETTYPE_TITLE { get; set; }
        public int MODEL { get; set; }
        public string MODEL_TITLE { get; set; }
        public int SN { get; set; }
        public string SN_TITLE { get; set; }
        public int FACTORY { get; set; }
        public string FACTORY_TITLE { get; set; }
        public int LATINNAME { get; set; }
        public int PN { get; set; }
        public string PN_TITLE { get; set; }
        public int MATERIAL { get; set; }
        public string MATERIAL_TITLE { get; set; }
        public int COLOR { get; set; }
        public string COLOR_TITLE { get; set; }
        public int? ASSET_TYPE { get; set; }
        public string ASSET_TYPE_TITLE { get; set; }
        public int ASSETS_COUTN { get; set; }
        public int? SUBCOUNT { get; set; }
    }
}
