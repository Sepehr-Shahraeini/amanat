using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class EXPORTERROR
    {
        public string TABLENAME { get; set; }
        public string ECODE { get; set; }
        public string EMSG { get; set; }
        public string MSG { get; set; }
        public string KEY { get; set; }
    }
}
