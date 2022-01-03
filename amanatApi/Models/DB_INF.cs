using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class DB_INF
    {
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public string DATA_TYPE { get; set; }
        public string DATA_LENGTH { get; set; }
        public string DATA_PRECISION { get; set; }
        public string NULLABLE { get; set; }
        public string KEY1 { get; set; }
        public string VERSION { get; set; }
    }
}
