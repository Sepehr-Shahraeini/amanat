using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_USER
    {
        public ERP_USER()
        {
            CACHEDASSETs = new HashSet<CACHEDASSET>();
            ERP_ASSETLs = new HashSet<ERP_ASSETL>();
            ERP_ASSETs = new HashSet<ERP_ASSET>();
            ERP_MSGDETAILs = new HashSet<ERP_MSGDETAIL>();
            ERP_MSGs = new HashSet<ERP_MSG>();
            ERP_PAPERCREATORNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERFKREQUESTUSERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERITEMRECs = new HashSet<ERP_PAPERITEM>();
            ERP_PAPERITEMSENDERs = new HashSet<ERP_PAPERITEM>();
            ERP_PAPERRECEIVER_USERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERREC_AMINAMVAL_USERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERREC_HEADAMINAMVAL_USERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERREC_RESPONSIBLE_USERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERSENDER_AMINAMVAL_USERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERSENDER_HEADAMINAMVAL_USERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERSENDER_RESPONSIBLE_USERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERSENDER_USERNavigations = new HashSet<ERP_PAPER>();
            ERP_PAPERTARGETUSERNavigations = new HashSet<ERP_PAPER>();
            ERP_REPAIRPACKAGEs = new HashSet<ERP_REPAIRPACKAGE>();
            ERP_USERCODINGACCESSes = new HashSet<ERP_USERCODINGACCESS>();
            ERP_USERLOCATIONACCESSes = new HashSet<ERP_USERLOCATIONACCESS>();
            ERP_USERROLEs = new HashSet<ERP_USERROLE>();
            ERP_USER_LOCATIONs = new HashSet<ERP_USER_LOCATION>();
            USER_ASSET_TYPEs = new HashSet<USER_ASSET_TYPE>();
        }

        public string USERNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string PASSWORD { get; set; }
        public string PERSONNELID { get; set; }
        public string BUILDINGNO { get; set; }
        public string SIGNATUREURL { get; set; }
        public string PICTUREURL { get; set; }
        public int ROOTLOCATION { get; set; }
        public long? LASTLOGIN { get; set; }
        public DateTime? LASTLOGING { get; set; }
        public int ACTIVE { get; set; }
        public int LOCATIONID { get; set; }
        public int DELETED { get; set; }
        public byte[] GROUPID { get; set; }
        public string NID { get; set; }
        public string EMAIL { get; set; }
        public string PHONE1 { get; set; }
        public string PHONE2 { get; set; }
        public string ADDRESS { get; set; }
        public string ROOM { get; set; }
        public int IS_ANBARDAR { get; set; }
        public int IS_ANBARDAR_KOL { get; set; }
        public int IS_ANBARDAR_ROOT { get; set; }
        public int IS_AMINAMVAL { get; set; }
        public int IS_AMINAMVAL_KOL { get; set; }
        public int IS_AMINAMVAL_ROOT { get; set; }
        public int IS_TADAROKAT { get; set; }
        public int IS_KHARID { get; set; }
        public int IS_ADMIN { get; set; }
        public int IS_GROUP_MAN { get; set; }
        public int IS_USER_MAN { get; set; }
        public int ID { get; set; }
        public int? IS_USER { get; set; }

        public virtual ERP_LOCATION LOCATION { get; set; }
        public virtual ERP_LOCATION ROOTLOCATIONNavigation { get; set; }
        public virtual ICollection<CACHEDASSET> CACHEDASSETs { get; set; }
        public virtual ICollection<ERP_ASSETL> ERP_ASSETLs { get; set; }
        public virtual ICollection<ERP_ASSET> ERP_ASSETs { get; set; }
        public virtual ICollection<ERP_MSGDETAIL> ERP_MSGDETAILs { get; set; }
        public virtual ICollection<ERP_MSG> ERP_MSGs { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERCREATORNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERFKREQUESTUSERNavigations { get; set; }
        public virtual ICollection<ERP_PAPERITEM> ERP_PAPERITEMRECs { get; set; }
        public virtual ICollection<ERP_PAPERITEM> ERP_PAPERITEMSENDERs { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERRECEIVER_USERNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERREC_AMINAMVAL_USERNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERREC_HEADAMINAMVAL_USERNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERREC_RESPONSIBLE_USERNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERSENDER_AMINAMVAL_USERNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERSENDER_HEADAMINAMVAL_USERNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERSENDER_RESPONSIBLE_USERNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERSENDER_USERNavigations { get; set; }
        public virtual ICollection<ERP_PAPER> ERP_PAPERTARGETUSERNavigations { get; set; }
        public virtual ICollection<ERP_REPAIRPACKAGE> ERP_REPAIRPACKAGEs { get; set; }
        public virtual ICollection<ERP_USERCODINGACCESS> ERP_USERCODINGACCESSes { get; set; }
        public virtual ICollection<ERP_USERLOCATIONACCESS> ERP_USERLOCATIONACCESSes { get; set; }
        public virtual ICollection<ERP_USERROLE> ERP_USERROLEs { get; set; }
        public virtual ICollection<ERP_USER_LOCATION> ERP_USER_LOCATIONs { get; set; }
        public virtual ICollection<USER_ASSET_TYPE> USER_ASSET_TYPEs { get; set; }
    }
}
