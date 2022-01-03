using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_TASK_REF
    {
        public int ID { get; set; }
        public int? CODEID { get; set; }
        public string CATEGORY { get; set; }
        public string TITLE { get; set; }
        public string REMARK { get; set; }

        public virtual ERP_CODING CODE { get; set; }
    }
}
