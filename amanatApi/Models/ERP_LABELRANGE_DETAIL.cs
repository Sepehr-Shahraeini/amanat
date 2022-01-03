using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_LABELRANGE_DETAIL
    {
        public int ID { get; set; }
        public int? LABELRANGEID { get; set; }
        public int LBL_FROM { get; set; }
        public int LBL_TO { get; set; }
        public int LBL_TYPE { get; set; }
        public int LOCATIONID { get; set; }
    }
}
