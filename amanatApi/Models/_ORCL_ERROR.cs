using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class _ORCL_ERROR
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string RowKey { get; set; }
        public string Message { get; set; }
        public string ErrorNumber { get; set; }
    }
}
