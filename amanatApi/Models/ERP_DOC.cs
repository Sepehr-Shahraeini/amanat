using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_DOC
    {
        public int ID { get; set; }
        public int? ASSETID { get; set; }
        public int? FILETYPE { get; set; }
        public int? DATE_ADD { get; set; }
        public string DESCRIPTION { get; set; }
        public string FILEEXT { get; set; }
        public string NO { get; set; }
        public string FILEURL { get; set; }
        public string FILEKEY { get; set; }
        public string KEYWORDS { get; set; }
    }
}
