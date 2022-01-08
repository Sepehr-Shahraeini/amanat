using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class NET_MPD_APPLICABILITY
    {
        public int PK { get; set; }
        public int FK_NET_MPD { get; set; }
        public int? PROP_TYPE { get; set; }
        public int? PROP_VALUE { get; set; }
        public string DESCRIPTION { get; set; }

        public virtual NET_MPD FK_NET_MPDNavigation { get; set; }
    }
}
