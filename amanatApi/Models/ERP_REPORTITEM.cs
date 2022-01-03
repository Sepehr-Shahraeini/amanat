using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_REPORTITEM
    {
        public byte[] IDOLD { get; set; }
        public string FIELDNAME { get; set; }
        public string TITLE { get; set; }
        public string FILTERMASKEDIT { get; set; }
        public string FILTERCOMBOTYPE { get; set; }
        public string DATATYPE { get; set; }
        public string FILTERCOMBO { get; set; }
        public int ISDATE { get; set; }
        public int SHOWSEARCH { get; set; }
        public int COMBOSTR { get; set; }
        public string SEARCHMETHOD { get; set; }
        public string FIELDDATATYPE { get; set; }
        public string CONVERTMETHOD { get; set; }
        public string PREFIX { get; set; }
        public int DONOTSHOW { get; set; }
        public string ORDERBYFIELD { get; set; }
        public int SEARCHENABLED { get; set; }
        public string GROUPTITLE { get; set; }
        public int ISTAKMILI { get; set; }
        public int? TAKMILICODE { get; set; }
        public byte[] OLDREPORTTABLEID { get; set; }
        public string AGGREGATEFUNCTION { get; set; }
        public string PIVOTGRIDLOCATION { get; set; }
        public string PIVOTSUMMARTTYPE { get; set; }
        public int? XORDERINDEX { get; set; }
        public int? XGROUP { get; set; }
        public string XGROUPTITLE { get; set; }
        public int? XMANDATORY { get; set; }
        public int ID { get; set; }
        public int? REPORTTABLEID { get; set; }
    }
}
