using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_LOCATION_TREE
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int CODE { get; set; }
        public string FULLCODE { get; set; }
        public int? ROOTLOCATIONID { get; set; }
        public int? ROOTLOCATION_CODE { get; set; }
        public string PARENTID { get; set; }
        public string PARENT_CODE { get; set; }
        public int? PARENT_TITLE { get; set; }
        public int DELETED { get; set; }
        public int LOCATIONTYPE { get; set; }
        public string LOCATIONTYPE_STR { get; set; }
        public int? SUBCOUNT { get; set; }
    }
}
