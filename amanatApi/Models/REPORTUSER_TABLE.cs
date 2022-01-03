using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTUSER_TABLE
    {
        public REPORTUSER_TABLE()
        {
            REPORTUSER_CODEs = new HashSet<REPORTUSER_CODE>();
            REPORTUSER_FILTERs = new HashSet<REPORTUSER_FILTER>();
            REPORTUSER_ITEMs = new HashSet<REPORTUSER_ITEM>();
        }

        public int ID { get; set; }
        public int TABLEID { get; set; }
        public int? PARENTTABLEID { get; set; }
        public int REPORTID { get; set; }

        public virtual REPORTUSER REPORT { get; set; }
        public virtual ICollection<REPORTUSER_CODE> REPORTUSER_CODEs { get; set; }
        public virtual ICollection<REPORTUSER_FILTER> REPORTUSER_FILTERs { get; set; }
        public virtual ICollection<REPORTUSER_ITEM> REPORTUSER_ITEMs { get; set; }
    }
}
