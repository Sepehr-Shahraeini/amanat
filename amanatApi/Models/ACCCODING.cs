using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ACCCODING
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int KOL { get; set; }
        public string CREATEUSER { get; set; }
        public string UPDATEUSER { get; set; }
        public long REGISTERDATE { get; set; }
        public long UPDATEDATE { get; set; }
        public int MOEIN { get; set; }
        public int FULLCODE { get; set; }
        public string FULLNAME { get; set; }
        public int PARENTID { get; set; }
        public int ACCOUNTTYPE { get; set; }
        public int TAFZILI { get; set; }
        public byte[] ROWGUID { get; set; }
    }
}
