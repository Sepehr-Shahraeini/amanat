using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_PAPERITEMCORRECTION
    {
        public int ID { get; set; }
        public int PAPERCORRECTIONID { get; set; }
        public int? PAPERITEMID { get; set; }
        public int? CODEID { get; set; }
        public string ASSETTITLE { get; set; }
        public double? QUANTITY { get; set; }
        public string ASSETLABEL { get; set; }
        public double? PRICE { get; set; }
        public int? RECID { get; set; }
        public int? RECLOCATIONID { get; set; }
        public int? SENDERID { get; set; }
        public int? SENDERLOCATIONID { get; set; }
        public int? SENDERROOTLOCATIONID { get; set; }
        public string PN { get; set; }
        public int? QUANTITYUNIT { get; set; }
        public int? REQUESTITEM_ID { get; set; }
        public int? TEMP_DELIVERYITEM_ID { get; set; }
        public int? CONDITION { get; set; }
        public int? TASKID { get; set; }
        public int IS_DELETED { get; set; }
        public string DELETEREASON { get; set; }
        public int IS_NEW { get; set; }
        public string DESCRIPTION { get; set; }
        public string MODEL { get; set; }
        public int? BRAND { get; set; }
        public string SNBN { get; set; }
        public int? SENDERCONDITION { get; set; }
        public long? KASR_RETURN_DATE { get; set; }
        public int? O_CODEID { get; set; }
        public string O_ASSETTITLE { get; set; }
        public double? O_QUANTITY { get; set; }
        public string O_ASSETLABEL { get; set; }
        public double? O_PRICE { get; set; }
        public int? O_RECID { get; set; }
        public int? O_RECLOCATIONID { get; set; }
        public int? O_SENDERID { get; set; }
        public int? O_SENDERLOCATIONID { get; set; }
        public int? O_SENDERROOTLOCATIONID { get; set; }
        public string O_PN { get; set; }
        public int? O_QUANTITYUNIT { get; set; }
        public int? O_REQUESTITEM_ID { get; set; }
        public int? O_TEMP_DELIVERYITEM_ID { get; set; }
        public int? O_CONDITION { get; set; }
        public int? O_TASKID { get; set; }
        public string O_DESCRIPTION { get; set; }
        public string O_MODEL { get; set; }
        public int? O_BRAND { get; set; }
        public string O_SNBN { get; set; }
        public int? O_SENDERCONDITION { get; set; }
        public long? O_KASR_RETURN_DATE { get; set; }

        public virtual ERP_PAPERCORRECTION PAPERCORRECTION { get; set; }
        public virtual ERP_PAPERITEM PAPERITEM { get; set; }
    }
}
