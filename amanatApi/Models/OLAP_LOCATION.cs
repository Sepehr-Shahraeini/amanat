using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class OLAP_LOCATION
    {
        public int ID { get; set; }
        public int ROOTID { get; set; }
        public string FULLCODE { get; set; }
        public string L5_CODE { get; set; }
        public string L7_CODE { get; set; }
        public string L9_CODE { get; set; }
        public string L11_CODE { get; set; }
        public string L13_CODE { get; set; }
        public string L3_CODE { get; set; }
        public int? L5_P_CNT { get; set; }
        public int? L3_P_CNT { get; set; }
        public int? L7_P_CNT { get; set; }
        public int? L9_P_CNT { get; set; }
        public int? L11_P_CNT { get; set; }
        public int? L13_P_CNT { get; set; }
        public int? L_P_CNT { get; set; }
    }
}
