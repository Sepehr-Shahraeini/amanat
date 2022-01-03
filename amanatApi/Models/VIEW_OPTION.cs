using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_OPTION
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int? PARENTID { get; set; }
        public string DESCRIPTION { get; set; }
        public int ISSYSTEM { get; set; }
        public int ORDERINDEX { get; set; }
        public int? CATEGORY { get; set; }
        public string PARENTTITLE { get; set; }
        public int? PARENT_PARENTID { get; set; }
        public int? SUBCOUNT { get; set; }
    }
}
