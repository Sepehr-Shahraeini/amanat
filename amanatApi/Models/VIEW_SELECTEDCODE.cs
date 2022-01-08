using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_SELECTEDCODE
    {
        public int ID { get; set; }
        public int USERID { get; set; }
        public int CODEID { get; set; }
        public int LOCATIONID { get; set; }
        public int ROOTLOCATION { get; set; }
        public string FULLCODE { get; set; }
        public string TITLE { get; set; }
    }
}
