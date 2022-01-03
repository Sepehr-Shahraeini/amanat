using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_REPAIRPACKAGE_PROBLEM
    {
        public int ID { get; set; }
        public string REMARK { get; set; }
        public int? PROBLEMID { get; set; }
        public int? REPAIRPACKAGEID { get; set; }

        public virtual ERP_REPAIRPACKAGE REPAIRPACKAGE { get; set; }
    }
}
