using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_PROP
    {
        public int ID { get; set; }
        public string PROPNAME { get; set; }
        public string PROPVALUE { get; set; }
        public int ASSETID { get; set; }
    }
}
