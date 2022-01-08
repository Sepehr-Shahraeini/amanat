﻿using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ASSET
    {
        public ERP_ASSET()
        {
            CACHEDASSETs = new HashSet<CACHEDASSET>();
            ERP_ASSETOPT_DETAILs = new HashSet<ERP_ASSETOPT_DETAIL>();
            ERP_ASSET_DEFECTs = new HashSet<ERP_ASSET_DEFECT>();
            ERP_CHANGEOWNERs = new HashSet<ERP_CHANGEOWNER>();
            ERP_ENSHes = new HashSet<ERP_ENSH>();
            ERP_EXTs = new HashSet<ERP_EXT>();
            ERP_INs = new HashSet<ERP_IN>();
            ERP_ONOFFHISTORYALTERNATENavigations = new HashSet<ERP_ONOFFHISTORY>();
            ERP_ONOFFHISTORYASSETs = new HashSet<ERP_ONOFFHISTORY>();
            ERP_ONOFFHISTORYPARENTASSETs = new HashSet<ERP_ONOFFHISTORY>();
            ERP_PAPERITEMs = new HashSet<ERP_PAPERITEM>();
            ERP_REPAIRPACKAGEs = new HashSet<ERP_REPAIRPACKAGE>();
            ERP_REPAIR_MATERIALASSETs = new HashSet<ERP_REPAIR_MATERIAL>();
            ERP_REPAIR_MATERIALPASSETs = new HashSet<ERP_REPAIR_MATERIAL>();
            ERP_REPAIR_RMATERIALASSETs = new HashSet<ERP_REPAIR_RMATERIAL>();
            ERP_REPAIR_RMATERIALPASSETs = new HashSet<ERP_REPAIR_RMATERIAL>();
            InverseEXTRACTFROM = new HashSet<ERP_ASSET>();
            InversePARENT = new HashSet<ERP_ASSET>();
            NET_CMPD_CHKSEQ_HISTORies = new HashSet<NET_CMPD_CHKSEQ_HISTORY>();
            NET_CMPD_LASTDONEs = new HashSet<NET_CMPD_LASTDONE>();
        }

        public int ID { get; set; }
        public string LABEL { get; set; }
        public string NAME { get; set; }
        public string SNBN { get; set; }
        public int? CODEID { get; set; }
        public string PN { get; set; }
        public string MODEL { get; set; }
        public int? BRAND { get; set; }
        public int ASSETTYPE { get; set; }
        public int? LABELTYPE { get; set; }
        public string OLDLABEL { get; set; }
        public string LATINNAME { get; set; }
        public int? COUNTRY { get; set; }
        public double? QUANTITY { get; set; }
        public int? QUANTITYUNIT { get; set; }
        public double? QUALITY { get; set; }
        public int? VALUETYPE { get; set; }
        public double? VALUE { get; set; }
        public int? CURRENCY { get; set; }
        public double? EXCHANGERATE { get; set; }
        public int? EARNINGTYPE { get; set; }
        public string OLDOWNER { get; set; }
        public double? BOOKVALUE { get; set; }
        public double? SAVEDAMOUNT { get; set; }
        public double? USEFULAGE { get; set; }
        public long? PRODATE { get; set; }
        public long? EXPDATE { get; set; }
        public DateTime? PRODATEG { get; set; }
        public DateTime? EXPDATEG { get; set; }
        public long? PURCHASEDATE { get; set; }
        public long? OPERATIONDATE { get; set; }
        public long? LETTERDATE { get; set; }
        public string LETTERNO { get; set; }
        public string LETTERSUBJECT { get; set; }
        public string SELLERNAME { get; set; }
        public string SELLERPHONE { get; set; }
        public string SELLERADDRESS { get; set; }
        public string WARANTY { get; set; }
        public long? WARANTYBEGINDATE { get; set; }
        public long? WARANTYENDDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public int? RECEIVERID { get; set; }
        public int? KEEPINGLOCATIONID { get; set; }
        public int? ROOTLOCATION { get; set; }
        public int ISACTIVE { get; set; }
        public int? RECLOCATIONID { get; set; }
        public double REMAIN { get; set; }
        public int? CONDITION { get; set; }
        public long? CALCDATE { get; set; }
        public int? MAINOWNER { get; set; }
        public int? ID2 { get; set; }
        public int? PARENTID { get; set; }
        public int? EXTRACTFROMID { get; set; }
        public int? MAINPLAKFAREIID { get; set; }
        public int? PLAKASLITEMPLATEID { get; set; }
        public string TRACKINGNO { get; set; }
        public int? LASTPAPERITEMID { get; set; }
        public int? SHELFFROM { get; set; }
        public int? SHELFTO { get; set; }
        public long? EXITDATE { get; set; }
        public int? EXITREASON { get; set; }
        public string EXITTO { get; set; }
        public int? USAGE { get; set; }
        public string AMLAK_SABTI_ASLI { get; set; }
        public string AMLAK_SABTI_FAREI { get; set; }
        public string AMLAK_VARAGHE_MALEKIAT { get; set; }
        public string KHODRO_MOTOR { get; set; }
        public string KHODRO_SHASI { get; set; }
        public string KHODRO_ENTEZAMI { get; set; }
        public int? KHODRO_NOTYPE { get; set; }
        public string PHONE_NO { get; set; }
        public string AMLAK_POSTALCODE { get; set; }
        public long? CREATEDATE { get; set; }
        public int? EXIT_PAPERITEM { get; set; }
        public int? ROOTASSETID { get; set; }
        public int? MATERIAL { get; set; }
        public double? LENGTHX { get; set; }
        public double? DIAMETER { get; set; }
        public double? AREA { get; set; }
        public double? CAPACITY { get; set; }
        public double? WEIGHT { get; set; }
        public double? FORCE { get; set; }
        public double? PRESSURE { get; set; }
        public double? POWER { get; set; }
        public int? COLOR { get; set; }
        public double? COURSE { get; set; }
        public double? VOLTAGE { get; set; }
        public double? AMPER { get; set; }
        public double? RESISTANCE { get; set; }
        public int? RESISTANCEUNIT { get; set; }
        public int? AMPERUNIT { get; set; }
        public int? VOLTAGEUNIT { get; set; }
        public int? COURSEUNIT { get; set; }
        public int? POWERUNIT { get; set; }
        public int? PRESSUREUNIT { get; set; }
        public int? FORCEUNIT { get; set; }
        public int? WEIGHTUNIT { get; set; }
        public int? DIAMETERUNIT { get; set; }
        public int? LENGTHXUNIT { get; set; }
        public int? AREAUNIT { get; set; }
        public int? CAPACITYUNIT { get; set; }
        public double? ARZI { get; set; }
        public byte[] OLDID { get; set; }
        public double? REPAIR_TOTALCOST { get; set; }
        public int? ONPACKAGEID { get; set; }
        public long? OLDLBL { get; set; }
        public int? OLDPARENTID { get; set; }
        public int? OLDEXTID { get; set; }
        public int? OLDRID { get; set; }
        public int? OLDPID { get; set; }
        public double? COUNTER { get; set; }
        public long? NLABEL { get; set; }
        public int CREATOR { get; set; }
        public int? ONPAPERID { get; set; }
        public string OLDLID { get; set; }
        public string OLDCODE { get; set; }
        public int? KHODRO_NOTYPE2 { get; set; }
        public int? BRAND2 { get; set; }
        public int? MODELID { get; set; }
        public int? BUYFOR { get; set; }
        public int? BUYFORPAPER { get; set; }
        public int? BUYFORPAPERITEM { get; set; }
        public int? USERID { get; set; }

        public virtual ERP_CODING CODE { get; set; }
        public virtual ERP_ASSET EXTRACTFROM { get; set; }
        public virtual ERP_LOCATION KEEPINGLOCATION { get; set; }
        public virtual ERP_ORGANIZATION MAINOWNERNavigation { get; set; }
        public virtual ERP_ASSET PARENT { get; set; }
        public virtual ERP_USER RECEIVER { get; set; }
        public virtual ERP_LOCATION RECLOCATION { get; set; }
        public virtual ERP_LOCATION ROOTLOCATIONNavigation { get; set; }
        public virtual ICollection<CACHEDASSET> CACHEDASSETs { get; set; }
        public virtual ICollection<ERP_ASSETOPT_DETAIL> ERP_ASSETOPT_DETAILs { get; set; }
        public virtual ICollection<ERP_ASSET_DEFECT> ERP_ASSET_DEFECTs { get; set; }
        public virtual ICollection<ERP_CHANGEOWNER> ERP_CHANGEOWNERs { get; set; }
        public virtual ICollection<ERP_ENSH> ERP_ENSHes { get; set; }
        public virtual ICollection<ERP_EXT> ERP_EXTs { get; set; }
        public virtual ICollection<ERP_IN> ERP_INs { get; set; }
        public virtual ICollection<ERP_ONOFFHISTORY> ERP_ONOFFHISTORYALTERNATENavigations { get; set; }
        public virtual ICollection<ERP_ONOFFHISTORY> ERP_ONOFFHISTORYASSETs { get; set; }
        public virtual ICollection<ERP_ONOFFHISTORY> ERP_ONOFFHISTORYPARENTASSETs { get; set; }
        public virtual ICollection<ERP_PAPERITEM> ERP_PAPERITEMs { get; set; }
        public virtual ICollection<ERP_REPAIRPACKAGE> ERP_REPAIRPACKAGEs { get; set; }
        public virtual ICollection<ERP_REPAIR_MATERIAL> ERP_REPAIR_MATERIALASSETs { get; set; }
        public virtual ICollection<ERP_REPAIR_MATERIAL> ERP_REPAIR_MATERIALPASSETs { get; set; }
        public virtual ICollection<ERP_REPAIR_RMATERIAL> ERP_REPAIR_RMATERIALASSETs { get; set; }
        public virtual ICollection<ERP_REPAIR_RMATERIAL> ERP_REPAIR_RMATERIALPASSETs { get; set; }
        public virtual ICollection<ERP_ASSET> InverseEXTRACTFROM { get; set; }
        public virtual ICollection<ERP_ASSET> InversePARENT { get; set; }
        public virtual ICollection<NET_CMPD_CHKSEQ_HISTORY> NET_CMPD_CHKSEQ_HISTORies { get; set; }
        public virtual ICollection<NET_CMPD_LASTDONE> NET_CMPD_LASTDONEs { get; set; }
    }
}
