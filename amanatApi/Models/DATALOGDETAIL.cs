using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class DATALOGDETAIL
    {
        public int PK { get; set; }
        public int LOGID { get; set; }
        public string NAME { get; set; }
        public string NEWVALUE_OLD { get; set; }
        public string OLDVALUE_OLD { get; set; }
        public string NEWVALUE { get; set; }
        public string OLDVALUE { get; set; }

        public virtual DATALOG LOG { get; set; }
    }
}
