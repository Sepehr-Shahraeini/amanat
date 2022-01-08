using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_CODING_SEARCH
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string FULLCODE { get; set; }
        public long? NFULLCODE { get; set; }
        public int CODETYPE { get; set; }
        public int? PARENTID { get; set; }
        public string TREE { get; set; }
        public int ASSETS_COUTN { get; set; }
        public int SUBCOUNT { get; set; }
    }
}
