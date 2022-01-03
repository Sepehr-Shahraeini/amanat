using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class CITY
    {
        public string TITLE { get; set; }
        public int PK { get; set; }
        public int FK_STATE { get; set; }
    }
}
