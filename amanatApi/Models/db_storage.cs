using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class db_storage
    {
        public short spid { get; set; }
        public DateTime login_time { get; set; }
        public string name { get; set; }
        public object v_value { get; set; }
        public string c_value { get; set; }
        public string nc_value { get; set; }
        public byte[] b_value { get; set; }
    }
}
