using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_LOCATION
    {
        public ERP_LOCATION()
        {
            ERP_ASSETKEEPINGLOCATIONs = new HashSet<ERP_ASSET>();
            ERP_ASSETLKEEPINGLOCATIONs = new HashSet<ERP_ASSETL>();
            ERP_ASSETLRECLOCATIONs = new HashSet<ERP_ASSETL>();
            ERP_ASSETLROOTLOCATIONNavigations = new HashSet<ERP_ASSETL>();
            ERP_ASSETRECLOCATIONs = new HashSet<ERP_ASSET>();
            ERP_ASSETROOTLOCATIONNavigations = new HashSet<ERP_ASSET>();
            ERP_PAPERFKREQUESTLOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERITEMRECLOCATIONs = new HashSet<ERP_PAPERITEM>();
            ERP_PAPERITEMSENDERLOCATIONs = new HashSet<ERP_PAPERITEM>();
            ERP_PAPERITEMSENDERROOTLOCATIONs = new HashSet<ERP_PAPERITEM>();
            ERP_PAPERKEEPING_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERRECEIVER_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERREC_AMINAMVAL_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERREC_HEADAMINAMVAL_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERREC_RESPONSIBLE_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERRESERVEDFORUNITNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERROOTLOCATION2Navigations = new HashSet<ERP_PAPER>();
            ERP_PAPERROOTLOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERSENDER_AMINAMVAL_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERSENDER_HEADAMINAMVAL_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERSENDER_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERSENDE_RRESPONSIBLE_LOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERTARGETLOCATIONNavigations = new HashSet<ERP_PAPER>();
            ERP_REPAIRPACKAGEs = new HashSet<ERP_REPAIRPACKAGE>();
            ERP_USERLOCATIONs = new HashSet<ERP_USER>();
            ERP_USERROOTLOCATIONNavigations = new HashSet<ERP_USER>();
        }

        public string TITLE { get; set; }
        public int CODE { get; set; }
        public string FULLCODE { get; set; }
        public int? ROOTLOCATIONID { get; set; }
        public int? PARENTID { get; set; }
        public string PHONE { get; set; }
        public int DELETED { get; set; }
        public int LOCATIONTYPE { get; set; }
        public int ID { get; set; }
        public int? OLDID { get; set; }
        public int? OLDPARENTID { get; set; }
        public int ISVIRTUAL { get; set; }

        public virtual ICollection<ERP_ASSET> ERP_ASSETKEEPINGLOCATIONs { get; set; }
        public virtual ICollection<ERP_ASSETL> ERP_ASSETLKEEPINGLOCATIONs { get; set; }
        public virtual ICollection<ERP_ASSETL> ERP_ASSETLRECLOCATIONs { get; set; }
        public virtual ICollection<ERP_ASSETL> ERP_ASSETLROOTLOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_ASSET> ERP_ASSETRECLOCATIONs { get; set; }
        public virtual ICollection<ERP_ASSET> ERP_ASSETROOTLOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERFKREQUESTLOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPERITEM> ERP_PAPERITEMRECLOCATIONs { get; set; }
        public virtual ICollection<ERP_PAPERITEM> ERP_PAPERITEMSENDERLOCATIONs { get; set; }
        public virtual ICollection<ERP_PAPERITEM> ERP_PAPERITEMSENDERROOTLOCATIONs { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERKEEPING_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERRECEIVER_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERREC_AMINAMVAL_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERREC_HEADAMINAMVAL_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERREC_RESPONSIBLE_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERRESERVEDFORUNITNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERROOTLOCATION2Navigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERROOTLOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERSENDER_AMINAMVAL_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERSENDER_HEADAMINAMVAL_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERSENDER_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERSENDE_RRESPONSIBLE_LOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERTARGETLOCATIONNavigations { get; set; }
        public virtual ICollection<ERP_REPAIRPACKAGE> ERP_REPAIRPACKAGEs { get; set; }
        public virtual ICollection<ERP_USER> ERP_USERLOCATIONs { get; set; }
        public virtual ICollection<ERP_USER> ERP_USERROOTLOCATIONNavigations { get; set; }
    }
}
