﻿using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_USERCODINGACCESS
    {
        public int ID { get; set; }
        public int CODEID { get; set; }
        public int USERID { get; set; }
        public int ROLE { get; set; }
        public string FULLCODE { get; set; }
    }
}
