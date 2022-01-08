using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class OLAP_USER
    {
        public int ID { get; set; }
        public string PERSONNELID { get; set; }
        public int LOCATIONID { get; set; }
        public string LOCATION_CODE { get; set; }
    }
}
