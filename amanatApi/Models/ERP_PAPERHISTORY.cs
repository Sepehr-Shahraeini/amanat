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
        public long CREATEDATE { get; set; }
        public int VISITED { get; set; }
        public long? VISITDATE { get; set; }
        public int REJECTED { get; set; }
        public long? REJECTDATE { get; set; }
        public int CONFIRMED { get; set; }
        public long? CONFIRMDATE { get; set; }
        public int ARCHIVED { get; set; }
        public long? ARCHIVEDATE { get; set; }
        public int? STATUS { get; set; }
        public long? STATUSDATE { get; set; }
        public int DELETED { get; set; }
        public int? READYTOARCHIVE { get; set; }
        public int? PAPERCORRECTIONID { get; set; }
        public int? RECTYPE { get; set; }

        public virtual ERP_PAPER PAPER { get; set; }
        public virtual ERP_PAPERCORRECTION PAPERCORRECTION { get; set; }
    }
}
