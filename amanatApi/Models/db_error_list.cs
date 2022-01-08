using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class db_error_list
    {
        public string error_full_name { get; set; }
        public decimal error_code { get; set; }
        public string error_message { get; set; }
    }
}
