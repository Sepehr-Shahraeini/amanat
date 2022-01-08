using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class db_storage_current
    {
        public string name { get; set; }
        public object v_value { get; set; }
        public string c_value { get; set; }
        public string nc_value { get; set; }
        public byte[] b_value { get; set; }
    }
}
