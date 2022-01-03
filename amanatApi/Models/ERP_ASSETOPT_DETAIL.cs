using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ASSETOPT_DETAIL
    {
        public int ID { get; set; }
        public int ASSETID { get; set; }
        public int OPTIONID { get; set; }
        public string REMARK { get; set; }
        public string CATEGORY { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
    }
}
