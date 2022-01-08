using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_PAPERITEM_SHORT
    {
        public int PI_ID { get; set; }
        public int PI_PAPERID { get; set; }
        public int PI_CODEID { get; set; }
        public int PI_ASSETID { get; set; }
        public double PI_QUANTITY { get; set; }
        public int? STATUS_DATE { get; set; }
        public int? PI_RELATEDPAPERITEM { get; set; }
        public int? PI_RELATEDPAPER_FULLNO { get; set; }
        public int? PI_RECID { get; set; }
        public string PI_REC_PID { get; set; }
        public string PI_REC_NAME { get; set; }
        public int? PI_RECLOCATIONID { get; set; }
        public string PI_RECLOCATION_TITLE { get; set; }
        public string PI_RECLOCATION_CODE { get; set; }
        public int? PI_SENDERID { get; set; }
        public string PI_SENDER_PID { get; set; }
        public string PI_SENDER_NAME { get; set; }
        public int? PI_SENDERLOCATIONID { get; set; }
        public string PI_SENDERLOCATION_TITLE { get; set; }
        public string PI_SENDERLOCATION_CODE { get; set; }
        public int? PI_SENDERROOTLOCATIONID { get; set; }
        public int PI_DELETED { get; set; }
        public int? PI_STATUS { get; set; }
    }
}
