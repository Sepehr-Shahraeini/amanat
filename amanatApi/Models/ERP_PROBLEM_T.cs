using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_PROBLEM_T
    {
        public int ID { get; set; }
        public string REMARK { get; set; }
        public int? PROBLEMID { get; set; }

        public virtual ERP_REPAIR_PROBLEM PROBLEM { get; set; }
    }
}
