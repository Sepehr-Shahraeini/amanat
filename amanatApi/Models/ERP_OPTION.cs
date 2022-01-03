using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_OPTION
    {
        public ERP_OPTION()
        {
            InversePARENT = new HashSet<ERP_OPTION>();
        }

        public int ID { get; set; }
        public string TITLE { get; set; }
        public int? PARENTID { get; set; }
        public string DESCRIPTION { get; set; }
        public int ISSYSTEM { get; set; }
        public int ORDERINDEX { get; set; }
        public string TITLE2 { get; set; }
        public int? CATEGORY { get; set; }
        public int? OLDID { get; set; }
        public int? OLDPARENT { get; set; }

        public virtual ERP_OPTION PARENT { get; set; }
        public virtual ICollection<ERP_OPTION> InversePARENT { get; set; }
    }
}
