using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class t_dbms_sql_recordset
    {
        public int cursor_id { get; set; }
        public int _key { get; set; }
        public int position { get; set; }
        public object v_value { get; set; }
        public string c_value { get; set; }
        public string nc_value { get; set; }
        public byte[] b_value { get; set; }

        public virtual t_dbms_sql_cursor cursor { get; set; }
    }
}
