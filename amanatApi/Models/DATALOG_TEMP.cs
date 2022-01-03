using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class DATALOG_TEMP
    {
        public int ID { get; set; }
        public int ENTITYID { get; set; }
        public int DATE_CREATE { get; set; }
        public int USERID { get; set; }
        public int ENTITYSTATE { get; set; }
        public string ENTITYNAME { get; set; }
    }
}
