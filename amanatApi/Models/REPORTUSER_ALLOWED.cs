using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTUSER_ALLOWED
    {
        public int ID { get; set; }
        public int REPORTID { get; set; }
        public int USERID { get; set; }
        public int ALLOWED { get; set; }
    }
}
