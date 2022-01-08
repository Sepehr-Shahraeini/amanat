using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class v_dbms_sql_cursor
    {
        public int id { get; set; }
        public int spid { get; set; }
        public DateTime login_time { get; set; }
        public string statement { get; set; }
        public int? current_row { get; set; }
        public int? last_row { get; set; }
    }
}
