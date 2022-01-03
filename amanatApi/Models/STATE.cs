using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class STATE
    {
        public string TITLE { get; set; }
        public int PK { get; set; }
        public int? FK_COUNTRY { get; set; }
    }
}
