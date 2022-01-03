using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_CHANGEOWNER
    {
        public int ID { get; set; }
        public int ASSETID { get; set; }
        public long DATE_CHANGE { get; set; }
        public string OLDOWNER { get; set; }
        public string NEWOWNER { get; set; }
        public string OLDPLAK { get; set; }
        public string NEWPLAK { get; set; }
        public int? PLAKTYPE { get; set; }
        public int? ENTEZAMITYPE { get; set; }
        public string DESCRIPTION { get; set; }
        public string OLDMAHRAMANE { get; set; }
        public string NEWMAHRAMANE { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
    }
}
