using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ERP_LOCATION
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int CODE { get; set; }
        public string FULLCODE { get; set; }
        public decimal? NFULLCODE { get; set; }
        public int? ROOTLOCATIONID { get; set; }
        public string ROOTLOCATION_CODE { get; set; }
        public string ROOTLOCATION_TITLE { get; set; }
        public int? PARENTID { get; set; }
        public string PARENT_CODE { get; set; }
        public string PARENT_TITLE { get; set; }
        public int? PARENTPARENTID { get; set; }
        public string PHONE { get; set; }
        public int DELETED { get; set; }
        public int LOCATIONTYPE { get; set; }
        public string LOCATIONTYPE_STR { get; set; }
        public int? SUBCOUNT { get; set; }
    }
}
