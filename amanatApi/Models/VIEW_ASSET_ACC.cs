using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_ASSET_ACC
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int? CODEID { get; set; }
        public string CODE { get; set; }
        public int? RECEIVERID { get; set; }
        public string RECPID { get; set; }
        public string RECNAME { get; set; }
        public int? RECLOCATIONID { get; set; }
        public string RECLOCATIONCODE { get; set; }
        public string RECLOCATIONTITLE { get; set; }
        public double? VALUE { get; set; }
        public double? BOOKVALUE { get; set; }
        public int ASSETTYPE { get; set; }
        public double REMAIN { get; set; }
        public double? QUANTITY { get; set; }
        public string LABEL { get; set; }
        public int? EARNINGTYPE { get; set; }
        public int? MAINOWNER { get; set; }
    }
}
