using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_USERLOCATIONACCESS
    {
        public int ID { get; set; }
        public int USERID { get; set; }
        public int LOCATIONID { get; set; }
        public string FULLCODE { get; set; }
        public int ROLE { get; set; }
        public int? MAIN { get; set; }
    }
}
