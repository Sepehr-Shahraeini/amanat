﻿using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_LABELRANGE
    {
        public int ID { get; set; }
        public int LBL_FROM { get; set; }
        public int LBL_TO { get; set; }
        public int LOCATIONID { get; set; }
        public int? LBL_TYPE { get; set; }
    }
}
