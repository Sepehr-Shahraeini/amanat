using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class t_dbms_sql_define_column
    {
        public int cursor_id { get; set; }
        public int position { get; set; }
        public string _type { get; set; }

        public virtual t_dbms_sql_cursor cursor { get; set; }
    }
}
