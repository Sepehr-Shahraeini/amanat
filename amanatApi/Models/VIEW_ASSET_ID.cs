using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_ID
    {
        public int ID { get; set; }
        public string LABEL { get; set; }
        public string NAME { get; set; }
        public string KHODRO_MOTOR { get; set; }
        public string KHODRO_SHASI { get; set; }
        public string KHODRO_ENTEZAMI { get; set; }
        public string AMLAK_SABTI_ASLI { get; set; }
        public string AMLAK_SABTI_FAREI { get; set; }
        public int? BRAND { get; set; }
        public string BRAND_TITLE { get; set; }
        public string MODEL { get; set; }
        public string PN { get; set; }
        public string SNBN { get; set; }
        public int? RECEIVERID { get; set; }
        public string REC_NAME { get; set; }
        public string REC_PID { get; set; }
        public int? RECLOCATIONID { get; set; }
        public string RECLOC_CODE { get; set; }
        public string RECLOC_TITLE { get; set; }
        public int? ROOTLOCATION { get; set; }
        public int? COUNTRY { get; set; }
        public string COUNTRY_TITLE { get; set; }
        public int CODETYPE { get; set; }
    }
}
