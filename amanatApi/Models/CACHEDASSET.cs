using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class CACHEDASSET
    {
        public int ID { get; set; }
        public int USERID { get; set; }
        public int ASSETID { get; set; }
        public double RESERVED_QTY { get; set; }
        public long RESERVATION_DATE { get; set; }
        public int ISPRESISTANT { get; set; }
        public int? APPID { get; set; }
        public DateTime? SYSRESDATE { get; set; }
        public string CACHEDKEY { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
        public virtual ERP_USER USER { get; set; }
    }
}
