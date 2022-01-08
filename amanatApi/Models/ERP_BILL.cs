using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_BILL
    {
        public int ID { get; set; }
        public int ENSH_ID { get; set; }
        public int PARDAKHT_VAZIAT { get; set; }
        public int? PARDAKHAT_TYPE { get; set; }
        public int? PARDAKHT_DATE { get; set; }
        public double PRICE { get; set; }
        public string RAHGIRI_NO { get; set; }
        public int BEGINDATE { get; set; }
        public int ENDDATE { get; set; }
        public string SHENASE_PARDAKHT { get; set; }
        public string SHENASE_GHABZ { get; set; }
        public int? APPROVER { get; set; }
        public int? APPROVER_LOCATION { get; set; }
        public int? PAYER { get; set; }
        public int? PAYER_LOCATION { get; set; }
        public double COUNTER { get; set; }
        public string REMARK { get; set; }
        public string RESID_IMG_URL { get; set; }
        public double? MASRAF_TOTAL { get; set; }
        public double? MASRAF_AVG { get; set; }
        public int? PERIOD { get; set; }
        public int? PERIOD_DAYS { get; set; }
        public double? MASRAF_HIGH { get; set; }
        public double? MASRAF_LOW { get; set; }
        public double? MASRAF_MOJAZ { get; set; }
        public double? MASRAF_MAZAD { get; set; }
        public double? TAKHFIF { get; set; }
        public double? MALIAT { get; set; }
        public double? BIME { get; set; }
        public double? AVAREZ { get; set; }
        public string XLSFILE { get; set; }
        public int? CREATE_DATE { get; set; }

        public virtual ERP_ENSH ENSH { get; set; }
    }
}
