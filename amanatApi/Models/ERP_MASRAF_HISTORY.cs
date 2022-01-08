using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MASRAF_HISTORY
    {
        public int ID { get; set; }
        public int ASSETID { get; set; }
        public int DATE_CREATE { get; set; }
        public string DESCRIPTION { get; set; }
        public double? QUANTITY { get; set; }
        public int? RECID { get; set; }
        public int? RECLOCATIONID { get; set; }
        public string RECPID { get; set; }
        public string RECLOCATIONCODE { get; set; }
        public string RECNAME { get; set; }
        public string RECLOCATIONTITLE { get; set; }
        public int? ROOTID { get; set; }
        public string ROOTCODE { get; set; }
        public string ROOTTITLE { get; set; }
        public string ASSETNAME { get; set; }
        public string ASSETCODE { get; set; }
        public string ASSETCODETITLE { get; set; }
    }
}
