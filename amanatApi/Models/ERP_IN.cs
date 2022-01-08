using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_IN
    {
        public int ID { get; set; }
        public int TYPE { get; set; }
        public string TYPE_STR { get; set; }
        public int COMPANY { get; set; }
        public string COMPANY_STR { get; set; }
        public string BIMEGOZAR { get; set; }
        public string SUBJECT { get; set; }
        public int BEGINDATE { get; set; }
        public int ENDDATE { get; set; }
        public double PRICE { get; set; }
        public string NO { get; set; }
        public string REMARK { get; set; }
        public int ASSETID { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
    }
}
