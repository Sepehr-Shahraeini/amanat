using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTUSER_ITEM
    {
        public int ID { get; set; }
        public int ITEMID { get; set; }
        public int TABLEID { get; set; }
        public double WIDTH { get; set; }
        public int POSITION { get; set; }
        public int? ORDERBYSTATUS { get; set; }
        public int REPORTABLEID { get; set; }
        public int? SUMMARYFUNC { get; set; }
        public int? ORDERBYORDER { get; set; }
        public int? SUMMARYFUNC2 { get; set; }

        public virtual REPORTUSER_TABLE REPORTABLE { get; set; }
    }
}
