using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_MSG
    {
        public ERP_MSG()
        {
            ERP_MSGATTACHes = new HashSet<ERP_MSGATTACH>();
            ERP_MSGDETAILs = new HashSet<ERP_MSGDETAIL>();
            InverseMASTERMSGNavigation = new HashSet<ERP_MSG>();
        }

        public int ID { get; set; }
        public int SENDER { get; set; }
        public long DATE_SENT { get; set; }
        public int DELETED { get; set; }
        public int SYSTEM { get; set; }
        public int? FORWARDEDBY { get; set; }
        public string SUBJECT { get; set; }
        public int? REPLYTO { get; set; }
        public int? FORWARDFROM { get; set; }
        public int ARCHIVED { get; set; }
        public string BODY { get; set; }
        public int RECEIVER { get; set; }
        public int VISITED { get; set; }
        public long? DATE_VISITED { get; set; }
        public int REPLIED { get; set; }
        public long? DATE_REPLIED { get; set; }
        public int FORWARDED { get; set; }
        public string CONVERSATION { get; set; }
        public int MASTER { get; set; }
        public int DETAIL { get; set; }
        public int? MASTERMSG { get; set; }
        public string ARCHIVEDKEY { get; set; }

        public virtual ERP_MSG MASTERMSGNavigation { get; set; }
        public virtual ERP_USER SENDERNavigation { get; set; }
        public virtual ICollection<ERP_MSGATTACH> ERP_MSGATTACHes { get; set; }
        public virtual ICollection<ERP_MSGDETAIL> ERP_MSGDETAILs { get; set; }
        public virtual ICollection<ERP_MSG> InverseMASTERMSGNavigation { get; set; }
    }
}
