using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_PAPERHISTORY
    {
        public int ID { get; set; }
        public int PAPERID { get; set; }
        public int RECID { get; set; }
        public int RECLOCATIONID { get; set; }
        public int SENID { get; set; }
        public int SENLOCATIONID { get; set; }
        public int PARENTID { get; set; }
        public int CREATORID { get; set; }
        public int CREATEDATE { get; set; }
        public int VISITED { get; set; }
        public int? VISITDATE { get; set; }
        public int REJECTED { get; set; }
        public int? REJECTDATE { get; set; }
        public int CONFIRMED { get; set; }
        public int? CONFIRMDATE { get; set; }
        public int ARCHIVED { get; set; }
        public int? ARCHIVEDATE { get; set; }
        public int? STATUS { get; set; }
        public int? STATUSDATE { get; set; }
        public int DELETED { get; set; }
        public int? READYTOARCHIVE { get; set; }
        public int? PAPERCORRECTIONID { get; set; }
        public int? RECTYPE { get; set; }

        public virtual ERP_PAPER PAPER { get; set; }
        public virtual ERP_PAPERCORRECTION PAPERCORRECTION { get; set; }
    }
}
