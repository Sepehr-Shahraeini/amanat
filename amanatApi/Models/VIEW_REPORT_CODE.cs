using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_REPORT_CODE
    {
        public int ID { get; set; }
        public int CODEID { get; set; }
        public int TABLEID { get; set; }
        public string FULLCODE { get; set; }
        public int? PARENTID { get; set; }
    }
}
