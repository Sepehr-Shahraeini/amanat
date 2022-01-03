using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_REPAIR_PROBLEM
    {
        public ERP_REPAIR_PROBLEM()
        {
            ERP_ASSET_DEFECTs = new HashSet<ERP_ASSET_DEFECT>();
            ERP_PROBLEM_Ts = new HashSet<ERP_PROBLEM_T>();
        }

        public int ID { get; set; }
        public int? CODEID { get; set; }
        public string CATEGORY { get; set; }
        public string TITLE { get; set; }
        public string REMARK { get; set; }
        public int? CODETYPE { get; set; }

        public virtual ERP_CODING CODE { get; set; }
        public virtual ICollection<ERP_ASSET_DEFECT> ERP_ASSET_DEFECTs { get; set; }
        public virtual ICollection<ERP_PROBLEM_T> ERP_PROBLEM_Ts { get; set; }
    }
}
