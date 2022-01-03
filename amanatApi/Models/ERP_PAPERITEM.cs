using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_PAPERITEM
    {
        public ERP_PAPERITEM()
        {
            ERP_ACCSITEMs = new HashSet<ERP_ACCSITEM>();
            ERP_PAPERITEMCORRECTIONs = new HashSet<ERP_PAPERITEMCORRECTION>();
        }

        public int ID { get; set; }
        public int PAPERID { get; set; }
        public int CODEID { get; set; }
        public string ASSETTITLE { get; set; }
        public double QUANTITY { get; set; }
        public int ASSETID { get; set; }
        public string ASSETLABEL { get; set; }
        public double PRICE { get; set; }
        public string REASON { get; set; }
        public int? RELATEDPAPERITEM { get; set; }
        public int? RECID { get; set; }
        public int? RECLOCATIONID { get; set; }
        public int? SENDERID { get; set; }
        public int? SENDERLOCATIONID { get; set; }
        public int? SENDERROOTLOCATIONID { get; set; }
        public int? PN_ID { get; set; }
        public string PN { get; set; }
        public int? QUANTITYUNIT { get; set; }
        public int? REQUESTITEM_ID { get; set; }
        public int? TEMP_DELIVERYITEM_ID { get; set; }
        public int? CONDITION { get; set; }
        public int? TASKID { get; set; }
        public int DELETED { get; set; }
        public string DELETEREASON { get; set; }
        public string DESCRIPTION { get; set; }
        public string MODEL { get; set; }
        public string BRAND { get; set; }
        public long? DELIVERYDATE { get; set; }
        public string SNBN { get; set; }
        public int? STATUS { get; set; }
        public long? STATUS_DATE { get; set; }
        public int? STATUS_BY { get; set; }
        public double ORIGINAL_PRICE { get; set; }
        public int? SENDERCONDITION { get; set; }
        public float? INIT_QTY { get; set; }
        public long? KASR_RETURN_DATE { get; set; }
        public byte[] OLDPAPERID { get; set; }
        public byte[] OLDID { get; set; }
        public int? BUYFORLOCATION { get; set; }
        public int? MATERIALID { get; set; }
        public int? PACKAGEID { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
        public virtual ERP_CODING CODE { get; set; }
        public virtual ERP_PAPER PAPER { get; set; }
        public virtual ERP_USER REC { get; set; }
        public virtual ERP_LOCATION RECLOCATION { get; set; }
        public virtual ERP_USER SENDER { get; set; }
        public virtual ERP_LOCATION SENDERLOCATION { get; set; }
        public virtual ERP_LOCATION SENDERROOTLOCATION { get; set; }
        public virtual ICollection<ERP_ACCSITEM> ERP_ACCSITEMs { get; set; }
        public virtual ICollection<ERP_PAPERITEMCORRECTION> ERP_PAPERITEMCORRECTIONs { get; set; }
    }
}
