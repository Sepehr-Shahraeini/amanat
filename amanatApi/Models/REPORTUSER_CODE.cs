using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTUSER_CODE
    {
        public int ID { get; set; }
        public int CODEID { get; set; }
        public int TABLEID { get; set; }

        public virtual REPORTUSER_TABLE TABLE { get; set; }
    }
}
