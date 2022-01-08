using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class t_dbms_sql_cursor
    {
        public t_dbms_sql_cursor()
        {
            t_dbms_sql_bind_variables = new HashSet<t_dbms_sql_bind_variable>();
            t_dbms_sql_define_columns = new HashSet<t_dbms_sql_define_column>();
            t_dbms_sql_recordsets = new HashSet<t_dbms_sql_recordset>();
        }

        public int id { get; set; }
        public int spid { get; set; }
        public DateTime login_time { get; set; }
        public string statement { get; set; }
        public int? current_row { get; set; }
        public int? last_row { get; set; }

        public virtual ICollection<t_dbms_sql_bind_variable> t_dbms_sql_bind_variables { get; set; }
        public virtual ICollection<t_dbms_sql_define_column> t_dbms_sql_define_columns { get; set; }
        public virtual ICollection<t_dbms_sql_recordset> t_dbms_sql_recordsets { get; set; }
    }
}
