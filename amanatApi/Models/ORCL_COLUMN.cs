using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ORCL_COLUMN
    {
        public int object_id { get; set; }
        public string Table_Name { get; set; }
        public string Column_Name { get; set; }
        public string Data_Type { get; set; }
        public short max_length { get; set; }
        public byte precision { get; set; }
        public byte scale { get; set; }
        public bool? is_nullable { get; set; }
        public bool Primary_Key { get; set; }
        public string EXPR_VAR_TYPE { get; set; }
        public string EXPR_VAR { get; set; }
        public string EXPR { get; set; }
    }
}
