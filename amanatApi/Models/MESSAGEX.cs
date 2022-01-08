using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class MESSAGEX
    {
        public byte[] ID { get; set; }
        public int SENDER { get; set; }
        public int SENDDATE { get; set; }
        public int DELETED { get; set; }
        public int SYSTEM { get; set; }
        public byte[] FORWARDEDBY { get; set; }
        public byte[] BODY { get; set; }
        public string SUBJECT { get; set; }
        public byte[] REPLYTO { get; set; }
        public byte[] FORWARDFROM { get; set; }
        public int? ARCHIVED { get; set; }
    }
}
