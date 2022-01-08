using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_REPORTUSER
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string SUBTITLE { get; set; }
        public string SIGNS { get; set; }
        public int? SIGNS_STR { get; set; }
        public string COL_FONTNAME { get; set; }
        public int? COL_FONTSIZE { get; set; }
        public int? COL_FONTWEIGHT { get; set; }
        public string HEADER_FONTNAME { get; set; }
        public int? HEADER_FONTSIZE { get; set; }
        public int? HEADER_FONTWEIGHT { get; set; }
        public int? PAPERTYPE { get; set; }
        public float? MARGIN { get; set; }
        public int? LANDSCAPE { get; set; }
        public int? CREATOR { get; set; }
        public string CATEGORY { get; set; }
        public int? LIMITED { get; set; }
        public int? ISSYSTEM { get; set; }
        public string CATEGORY2 { get; set; }
        public int? ISTAJMI { get; set; }
        public string CREATOR_PID { get; set; }
        public string CREATOR_NAME { get; set; }
    }
}
