using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_ROTATION
    {
        public int PI_ID { get; set; }
        public string P_FULLNO { get; set; }
        public int P_ID { get; set; }
        public int P_NO { get; set; }
        public int? P_PAPERDATE { get; set; }
        public int? BEGIN_DATE { get; set; }
        public string END_DATE { get; set; }
        public int P_CREATEDATE { get; set; }
        public int? P_REC_LOCATION { get; set; }
        public string P_REC_LOCATION_CODE { get; set; }
        public string P_REC_LOCATION_TITLE { get; set; }
        public int? P_REC_USER { get; set; }
        public string P_REC_USER_NAME { get; set; }
        public string P_REC_USER_PID { get; set; }
        public string PI_CONDITION_STR { get; set; }
        public int ASSET_ID { get; set; }
        public int P_PAPERTYPE { get; set; }
        public string P_PAPERTYPE_STR { get; set; }
    }
}
