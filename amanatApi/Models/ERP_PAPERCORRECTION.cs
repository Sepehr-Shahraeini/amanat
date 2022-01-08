using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_PAPERCORRECTION
    {
        public ERP_PAPERCORRECTION()
        {
            ERP_PAPERHISTORies = new HashSet<ERP_PAPERHISTORY>();
            ERP_PAPERITEMCORRECTIONs = new HashSet<ERP_PAPERITEMCORRECTION>();
        }

        public int ID { get; set; }
        public int PAPERID { get; set; }
        public int NO { get; set; }
        public string FULLNO { get; set; }
        public string PAPERFULLNO { get; set; }
        public int CREATEDATE { get; set; }
        public int? SENDER_LOCATION { get; set; }
        public int? SENDER_USER { get; set; }
        public int? OSENDER_LOCATION { get; set; }
        public int? OSENDER_USER { get; set; }
        public int? RECEIVER_LOCATION { get; set; }
        public int? RECEIVER_USER { get; set; }
        public int? ORECEIVER_LOCATION { get; set; }
        public int? OLDRECEIVER_USER { get; set; }
        public int? SENDER_RRESPONSIBLE_LOCATION { get; set; }
        public int? SENDER_RESPONSIBLE_USER { get; set; }
        public int? OSENDER_RRESPONSIBLE_LOCATION { get; set; }
        public int? OSENDER_RESPONSIBLE_USER { get; set; }
        public int? SENDER_AMINAMVAL_LOCATION { get; set; }
        public int? SENDER_AMINAMVAL_USER { get; set; }
        public int? OSENDER_AMINAMVAL_LOCATION { get; set; }
        public int? OSENDER_AMINAMVAL_USER { get; set; }
        public int? SENDER_HEADAMINAMVAL_LOCATION { get; set; }
        public int? SENDER_HEADAMINAMVAL_USER { get; set; }
        public int? OSENDER_HEADAMINAMVAL_LOCATION { get; set; }
        public int? OSENDER_HEADAMINAMVAL_USER { get; set; }
        public int? REC_AMINAMVAL_LOCATION { get; set; }
        public int? REC_AMINAMVAL_USER { get; set; }
        public int? OREC_AMINAMVAL_LOCATION { get; set; }
        public int? OREC_AMINAMVAL_USER { get; set; }
        public int? REC_HEADAMINAMVAL_LOCATION { get; set; }
        public int? REC_HEADAMINAMVAL_USER { get; set; }
        public int? OREC_HEADAMINAMVAL_LOCATION { get; set; }
        public int? OREC_HEADAMINAMVAL_USER { get; set; }
        public int? REC_RESPONSIBLE_LOCATION { get; set; }
        public int? REC_RESPONSIBLE_USER { get; set; }
        public int? OREC_RESPONSIBLE_LOCATION { get; set; }
        public int? OREC_RESPONSIBLE_USER { get; set; }
        public int? CREATOR { get; set; }
        public string LICENCE_NO { get; set; }
        public int? LICENCE_DATE { get; set; }
        public string LICENCE_CREATOR { get; set; }
        public string LICENCE_IMAGE_URL { get; set; }
        public string OLICENCE_NO { get; set; }
        public int? OLICENCE_DATE { get; set; }
        public string OLICENCE_CREATOR { get; set; }
        public string OLICENCE_IMAGE_URL { get; set; }
        public int? RESERVEDFORUNIT { get; set; }
        public int? ORESERVEDFORUNIT { get; set; }
        public int? DEADLINE { get; set; }
        public int? ODEADLINE { get; set; }
        public int? FKREQUESTUSER { get; set; }
        public int? FKREQUESTLOCATION { get; set; }
        public int? FKREQUEST { get; set; }
        public int? OFKREQUESTUSER { get; set; }
        public int? OFKREQUESTLOCATION { get; set; }
        public int? OFKREQUEST { get; set; }
        public string AWB { get; set; }
        public string INVOICE_NO { get; set; }
        public double? INVOICE_PRICE { get; set; }
        public double? INVOICE_DISCOUNT { get; set; }
        public double? INVOICE_TAX { get; set; }
        public double? INVOICE_FINALPRICE { get; set; }
        public double? TRANSPORTCOST { get; set; }
        public double? COST_ADDITIVE { get; set; }
        public int? TRANSPORTDATE { get; set; }
        public string TRANSPORTER { get; set; }
        public int? DELIVERYDATE { get; set; }
        public string QUOTATION { get; set; }
        public int? INVOICE_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public double? COST_SUBTRACTIVE { get; set; }
        public int? RECEIPTDATE { get; set; }
        public int? INVOICE_CURRENCY { get; set; }
        public string LICENCE_DESCRIPTION { get; set; }
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
        public int? KASR_DEADLINE { get; set; }
        public int? KASR_RETURN_DATE { get; set; }
        public int? KASR_REASON { get; set; }
        public int? KASR_DATE { get; set; }
        public int? REC_ANBARDAR_USER { get; set; }
        public int? REC_ANBARDAR_LOCATION { get; set; }
        public string OAWB { get; set; }
        public string OINVOICE_NO { get; set; }
        public double? OINVOICE_PRICE { get; set; }
        public double? OINVOICE_DISCOUNT { get; set; }
        public double? OINVOICE_TAX { get; set; }
        public double? OINVOICE_FINALPRICE { get; set; }
        public double? OTRANSPORTCOST { get; set; }
        public double? OCOST_ADDITIVE { get; set; }
        public int? OTRANSPORTDATE { get; set; }
        public string OTRANSPORTER { get; set; }
        public int? ODELIVERYDATE { get; set; }
        public string OQUOTATION { get; set; }
        public int? OINVOICE_DATE { get; set; }
        public string ODESCRIPTION { get; set; }
        public double? OCOST_SUBTRACTIVE { get; set; }
        public int? ORECEIPTDATE { get; set; }
        public int? OINVOICE_CURRENCY { get; set; }
        public string OLICENCE_DESCRIPTION { get; set; }
        public int? OHOGHUGHI_USER { get; set; }
        public int? OHOGHUGHI_LOCATION { get; set; }
        public int? OKASR_COMPANY { get; set; }
        public int? OKASR_RABET { get; set; }
        public string OKASR_PLAK_TAHVILI { get; set; }
        public double? OKASR_SELL_VALUE { get; set; }
        public int? OKASR_SELL_CURRENCY { get; set; }
        public string OKASR_SELL_MOZAIEDE { get; set; }
        public int? OKASR_SERGHAT_USERID { get; set; }
        public double? OKASR_SERGHAT_KARSHENASI { get; set; }
        public double? OKASR_SERGHT_MANAVI { get; set; }
        public int? OKASR_DEADLINE { get; set; }
        public int? OKASR_RETURN_DATE { get; set; }
        public int? OKASR_REASON { get; set; }
        public int? OKASR_DATE { get; set; }
        public int? OREC_ANBARDAR_USER { get; set; }
        public int? OREC_ANBARDAR_LOCATION { get; set; }

        public virtual ERP_PAPER PAPER { get; set; }
        public virtual ICollection<ERP_PAPERHISTORY> ERP_PAPERHISTORies { get; set; }
        public virtual ICollection<ERP_PAPERITEMCORRECTION> ERP_PAPERITEMCORRECTIONs { get; set; }
    }
}
