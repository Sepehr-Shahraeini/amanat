using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_PAPER
    {
        public ERP_PAPER()
        {
            ERP_ACCSANADs = new HashSet<ERP_ACCSANAD>();
            ERP_PAPERCORRECTIONs = new HashSet<ERP_PAPERCORRECTION>();
            ERP_PAPERHISTORies = new HashSet<ERP_PAPERHISTORY>();
            ERP_PAPERITEMs = new HashSet<ERP_PAPERITEM>();
        }

        public int ID { get; set; }
        public long NO { get; set; }
        public string FULLNO { get; set; }
        public long? PAPERDATE { get; set; }
        public long CREATEDATE { get; set; }
        public long? PAPEREXPDATE { get; set; }
        public int PAPERTYPE { get; set; }
        public int APPROVED { get; set; }
        public int ACTIVE { get; set; }
        public int DELETED { get; set; }
        public int ROOTLOCATION { get; set; }
        public int? ROOTLOCATION2 { get; set; }
        public int? SENDER_LOCATION { get; set; }
        public int? SENDER_USER { get; set; }
        public int? RECEIVER_LOCATION { get; set; }
        public int? RECEIVER_USER { get; set; }
        public int? SENDE_RRESPONSIBLE_LOCATION { get; set; }
        public int? SENDER_RESPONSIBLE_USER { get; set; }
        public int? SENDER_AMINAMVAL_LOCATION { get; set; }
        public int? SENDER_AMINAMVAL_USER { get; set; }
        public int? SENDER_HEADAMINAMVAL_LOCATION { get; set; }
        public int? SENDER_HEADAMINAMVAL_USER { get; set; }
        public int? STOREKEEPERUSER { get; set; }
        public int? REC_AMINAMVAL_LOCATION { get; set; }
        public int? REC_AMINAMVAL_USER { get; set; }
        public int? REC_HEADAMINAMVAL_LOCATION { get; set; }
        public int? REC_HEADAMINAMVAL_USER { get; set; }
        public int? REC_RESPONSIBLE_LOCATION { get; set; }
        public int? REC_RESPONSIBLE_USER { get; set; }
        public int? TARGETLOCATION { get; set; }
        public int? TARGETUSER { get; set; }
        public int? CREATOR { get; set; }
        public string LICENCE_NO { get; set; }
        public long? LICENCE_DATE { get; set; }
        public string LICENCE_CREATOR { get; set; }
        public string LICENCE_IMAGE_URL { get; set; }
        public int? ORIGINALPAPERID { get; set; }
        public int PAPERYEAR { get; set; }
        public int? RESERVEDFORUNIT { get; set; }
        public int? FKOPERTOR { get; set; }
        public long? DEADLINE { get; set; }
        public string FKMACHINETYPE { get; set; }
        public int? FKMACHINE { get; set; }
        public int? FKCOMPANY { get; set; }
        public int? FKPRIORITY { get; set; }
        public int? FKREQUESTUSER { get; set; }
        public int? FKREQUESTLOCATION { get; set; }
        public int? FKREQUEST { get; set; }
        public string AWB { get; set; }
        public string INVOICE_NO { get; set; }
        public double? INVOICE_PRICE { get; set; }
        public double? INVOICE_DISCOUNT { get; set; }
        public double? INVOICE_TAX { get; set; }
        public double? INVOICE_FINALPRICE { get; set; }
        public double? TRANSPORTCOST { get; set; }
        public double? COST_ADDITIVE { get; set; }
        public long? TRANSPORTDATE { get; set; }
        public string TRANSPORTER { get; set; }
        public long? DELIVERYDATE { get; set; }
        public string QUOTATION { get; set; }
        public long? INVOICE_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public double? COST_SUBTRACTIVE { get; set; }
        public long? RECEIPTDATE { get; set; }
        public int? INVOICE_CURRENCY { get; set; }
        public string LICENCE_DESCRIPTION { get; set; }
        public int? KEEPING_LOCATION { get; set; }
        public int? HOGHUGHI_USER { get; set; }
        public int? HOGHUGHI_LOCATION { get; set; }
        public int? KASR_COMPANY { get; set; }
        public int? KASR_RABET { get; set; }
        public string KASR_PLAK_TAHVILI { get; set; }
        public double? KASR_SELL_VALUE { get; set; }
        public int? KASR_SELL_CURRENCY { get; set; }
        public string KASR_SELL_MOZAIEDE { get; set; }
        public int? KASR_SERGHAT_USERID { get; set; }
        public double? KASR_SERGHAT_KARSHENASI { get; set; }
        public double? KASR_SERGHT_MANAVI { get; set; }
        public long? KASR_DEADLINE { get; set; }
        public long? KASR_RETURN_DATE { get; set; }
        public int? KASR_REASON { get; set; }
        public int? EDITFROMPAPER { get; set; }
        public int? NEEDPRICECALC { get; set; }
        public long? KASR_DATE { get; set; }
        public string CACHEDKEY { get; set; }
        public int IS_CONTINUAL { get; set; }
        public byte[] OLDID { get; set; }
        public int? SENT { get; set; }
        public string OLDRADDESCRIPTION { get; set; }
        public int? REC_ANBARDAR_USER { get; set; }
        public int? REC_ANBARDAR_LOCATION { get; set; }
        public string SHOP { get; set; }
        public int? SHOPID { get; set; }
        public string SELLER { get; set; }
        public string SHOPADDRESS { get; set; }
        public string SHOPPHONE { get; set; }
        public int? MARJU_REASON { get; set; }
        public int? RELATEDPAPER { get; set; }
        public int? XF { get; set; }
        public int? BUYFOR { get; set; }

        public virtual ERP_USER CREATORNavigation { get; set; }
        public virtual ERP_LOCATION FKREQUESTLOCATIONNavigation { get; set; }
        public virtual ERP_USER FKREQUESTUSERNavigation { get; set; }
        public virtual ERP_LOCATION KEEPING_LOCATIONNavigation { get; set; }
        public virtual ERP_LOCATION RECEIVER_LOCATIONNavigation { get; set; }
        public virtual ERP_USER RECEIVER_USERNavigation { get; set; }
        public virtual ERP_LOCATION REC_AMINAMVAL_LOCATIONNavigation { get; set; }
        public virtual ERP_USER REC_AMINAMVAL_USERNavigation { get; set; }
        public virtual ERP_LOCATION REC_HEADAMINAMVAL_LOCATIONNavigation { get; set; }
        public virtual ERP_USER REC_HEADAMINAMVAL_USERNavigation { get; set; }
        public virtual ERP_LOCATION REC_RESPONSIBLE_LOCATIONNavigation { get; set; }
        public virtual ERP_USER REC_RESPONSIBLE_USERNavigation { get; set; }
        public virtual ERP_LOCATION RESERVEDFORUNITNavigation { get; set; }
        public virtual ERP_LOCATION ROOTLOCATION2Navigation { get; set; }
        public virtual ERP_LOCATION ROOTLOCATIONNavigation { get; set; }
        public virtual ERP_LOCATION SENDER_AMINAMVAL_LOCATIONNavigation { get; set; }
        public virtual ERP_USER SENDER_AMINAMVAL_USERNavigation { get; set; }
        public virtual ERP_LOCATION SENDER_HEADAMINAMVAL_LOCATIONNavigation { get; set; }
        public virtual ERP_USER SENDER_HEADAMINAMVAL_USERNavigation { get; set; }
        public virtual ERP_LOCATION SENDER_LOCATIONNavigation { get; set; }
        public virtual ERP_USER SENDER_RESPONSIBLE_USERNavigation { get; set; }
        public virtual ERP_USER SENDER_USERNavigation { get; set; }
        public virtual ERP_LOCATION SENDE_RRESPONSIBLE_LOCATIONNavigation { get; set; }
        public virtual ERP_LOCATION TARGETLOCATIONNavigation { get; set; }
        public virtual ERP_USER TARGETUSERNavigation { get; set; }
        public virtual ICollection<ERP_ACCSANAD> ERP_ACCSANADs { get; set; }
        public virtual ICollection<ERP_PAPERCORRECTION> ERP_PAPERCORRECTIONs { get; set; }
        public virtual ICollection<ERP_PAPERHISTORY> ERP_PAPERHISTORies { get; set; }
        public virtual ICollection<ERP_PAPERITEM> ERP_PAPERITEMs { get; set; }
    }
}
