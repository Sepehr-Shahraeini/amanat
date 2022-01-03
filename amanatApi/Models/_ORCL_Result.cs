using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class _ORCL_Result
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public long? Total { get; set; }
        public long? Processed { get; set; }
        public long? Failed { get; set; }
        public DateTime? Date { get; set; }
    }
}
