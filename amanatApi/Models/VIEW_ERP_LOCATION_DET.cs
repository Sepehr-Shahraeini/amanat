using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ERP_LOCATION_DET
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int CODE { get; set; }
        public string FULLCODE { get; set; }
        public long? NFULLCODE { get; set; }
        public string PARENT_FULLCODE { get; set; }
        public int? ROOTLOCATIONID { get; set; }
        public string ROOTLOCATION_CODE { get; set; }
        public string ROOTLOCATION_TITLE { get; set; }
        public int? PARENTID { get; set; }
        public int? PARENT_PARENTID { get; set; }
        public string PARENT_CODE { get; set; }
        public string PARENT_TITLE { get; set; }
        public int? PARENTPARENTID { get; set; }
        public string PHONE { get; set; }
        public int DELETED { get; set; }
        public int LOCATIONTYPE { get; set; }
        public string LOCATIONTYPE_STR { get; set; }
        public int? PARENT_LOCATIONTYPE { get; set; }
        public int ISVIRTUAL { get; set; }
        public int SUBCOUNT { get; set; }
        public int PEOPLECOUNT { get; set; }
        public int ASSETCOUNT { get; set; }
        public int MELKCOUNT { get; set; }
        public int KHODROCOUNT { get; set; }
        public int PHONECOUNT { get; set; }
        public int CODECOUNT { get; set; }
    }
}
