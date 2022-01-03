using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class LOCKED_IP
    {
        public int ID { get; set; }
        public string IP { get; set; }
        public string MAC { get; set; }
        public DateTime DATE_CREATE { get; set; }
        public int STATUS { get; set; }
    }
}
