using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class v_dbms_sql_bind_variable
    {
        public int cursor_id { get; set; }
        public string _name { get; set; }
        public string _type { get; set; }
        public object v_value { get; set; }
        public string c_value { get; set; }
        public string nc_value { get; set; }
        public byte[] b_value { get; set; }
    }
}
