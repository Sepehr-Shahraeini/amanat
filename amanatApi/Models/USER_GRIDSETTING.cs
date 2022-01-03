using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class USER_GRIDSETTING
    {
        public int ID { get; set; }
        public int USERID { get; set; }
        public string GRIDTYPE { get; set; }
        public string FORM { get; set; }
        public int? APPID { get; set; }
        public string COLUMNS { get; set; }
        public int? CATEGORY { get; set; }
    }
}
