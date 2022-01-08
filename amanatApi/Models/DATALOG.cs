using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class DATALOG
    {
        public DATALOG()
        {
            DATALOGDETAILs = new HashSet<DATALOGDETAIL>();
        }

        public int ID { get; set; }
        public int ENTITYID { get; set; }
        public int DATE_CREATE { get; set; }
        public int USERID { get; set; }
        public int ENTITYSTATE { get; set; }
        public string ENTITYNAME { get; set; }

        public virtual ICollection<DATALOGDETAIL> DATALOGDETAILs { get; set; }
    }
}
