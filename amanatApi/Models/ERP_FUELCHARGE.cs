using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_FUELCHARGE
    {
        public int ID { get; set; }
        public int ASSETID { get; set; }
        public int? PARDAKHAT_TYPE { get; set; }
        public long DATE_CHARGE { get; set; }
        public double PRICE { get; set; }
        public string RAHGIRI_NO { get; set; }
        public int? APPROVER { get; set; }
        public int? APPROVER_LOCATION { get; set; }
        public int PAYER { get; set; }
        public int? PAYER_LOCATION { get; set; }
        public double COUNTER { get; set; }
        public string REMARK { get; set; }
        public int QUANTITY { get; set; }
        public int? FUELTYPE { get; set; }
        public string STATIONNO { get; set; }
        public string STATIONPHONE { get; set; }
        public string STATIONADDRESS { get; set; }
    }
}
