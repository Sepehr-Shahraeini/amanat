using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_USER_CODING
    {
        public int USERID { get; set; }
        public int CODEID { get; set; }
        public int ID { get; set; }
        public int? CODE { get; set; }
        public string FULLCODE { get; set; }
        public string TITLE { get; set; }
        public int? PARENTID { get; set; }
        public int? CODETYPE { get; set; }
    }
}
