using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class REPORTSETTINGFILTERITEM
    {
        public byte[] ID { get; set; }
        public byte[] REPORTSETTINGID { get; set; }
        public int? P1INDEX { get; set; }
        public int? P2INDEX { get; set; }
        public int? CMBFIELDSELECTED_INDEX { get; set; }
        public string CMBFIELDSELECTED_TEXT { get; set; }
        public int? CMBOPERATOR1 { get; set; }
        public int? CMBOPERATOR2 { get; set; }
        public int? RBYESCHECKED { get; set; }
        public int? RBNOCHECKED { get; set; }
        public int? CMBCOMBOSELECTED_INDEX { get; set; }
        public string CMBCOMBOSELECTED_TEXT { get; set; }
        public string TXTVALUE1 { get; set; }
        public string TXTVALUE2 { get; set; }
        public byte[] CMBFIELDVALUE { get; set; }
        public int ORDERINDEX { get; set; }
    }
}
