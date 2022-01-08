using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ORGANIZATION
    {
        public ERP_ORGANIZATION()
        {
            ERP_ASSETs = new HashSet<ERP_ASSET>();
        }

        public int ID { get; set; }
        public string NAME { get; set; }
        public string RABETNAME { get; set; }
        public string ADDRESS { get; set; }
        public string TEL { get; set; }
        public string FAX { get; set; }
        public int? LOCATIONID { get; set; }
        public int? ROOTLOCATION { get; set; }
        public int? OLDID { get; set; }

        public virtual ICollection<ERP_ASSET> ERP_ASSETs { get; set; }
    }
}
