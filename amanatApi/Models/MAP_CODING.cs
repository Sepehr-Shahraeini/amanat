using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class MAP_CODING
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int CODE { get; set; }
        public string FULLCODE { get; set; }
        public int? PARENTID { get; set; }
        public int CODETYPE { get; set; }
        public double? ASSET_AVAILABLEQTY { get; set; }
    }
}
