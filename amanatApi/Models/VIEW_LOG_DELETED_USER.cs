using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_LOG_DELETED_USER
    {
        public int ENTITYID { get; set; }
        public string NAME { get; set; }
        public string OLDVALUE { get; set; }
        public string NEWVALUE { get; set; }
        public string PID { get; set; }
        public int? UID { get; set; }
    }
}
