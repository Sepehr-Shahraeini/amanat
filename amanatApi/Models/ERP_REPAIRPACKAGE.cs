using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_REPAIRPACKAGE
    {
        public ERP_REPAIRPACKAGE()
        {
            ERP_ONOFFHISTORies = new HashSet<ERP_ONOFFHISTORY>();
            ERP_REPAIRPACKAGE_PROBLEMs = new HashSet<ERP_REPAIRPACKAGE_PROBLEM>();
            ERP_REPAIR_MATERIALs = new HashSet<ERP_REPAIR_MATERIAL>();
            ERP_REPAIR_RMATERIALs = new HashSet<ERP_REPAIR_RMATERIAL>();
            ERP_REPAIR_TASKs = new HashSet<ERP_REPAIR_TASK>();
        }

        public int ID { get; set; }
        public string NO { get; set; }
        public double? COST { get; set; }
        public double? TAKHFIF { get; set; }
        public double? HAML { get; set; }
        public double? MALIAT { get; set; }
        public long? DATE_SCHEDULESTART { get; set; }
        public long? DATE_SCHEDULEEND { get; set; }
        public long? DATE_ACTUALSTART { get; set; }
        public long? DATE_ACTUALEND { get; set; }
        public int? DURATION_SCHEDULE { get; set; }
        public int? DURATION_ACTUAL { get; set; }
        public string REMARK { get; set; }
        public int? DELAY_REASON { get; set; }
        public string DELAY_REMARK { get; set; }
        public int? MANAGERID { get; set; }
        public string WORKSHOP { get; set; }
        public string WORKSHOP_ADDRESS { get; set; }
        public string WORKSHOP_PHONE { get; set; }
        public int? APPROVERID { get; set; }
        public int? OPERATORID { get; set; }
        public int? TAHVILDAHANDEID { get; set; }
        public int? RECEIVERID { get; set; }
        public int ASSETID { get; set; }
        public double? ASSET_TAHVIL_COUNTER { get; set; }
        public int? ASSET_CONDITION { get; set; }
        public int? REASON { get; set; }
        public string REASON_REMARK { get; set; }
        public float? COSTMATERIAL { get; set; }
        public float? COSTEJARE { get; set; }
        public int? IS_OUTSOURCE { get; set; }
        public int? WORKSHOPID { get; set; }
        public long? DATE_TAHVIL { get; set; }
        public long? DATE_RECEIVE { get; set; }
        public long? DATE_APPROVE { get; set; }
        public int CREATOR { get; set; }
        public int CREATORLOC { get; set; }
        public long? DATE_CLOSED { get; set; }
        public string INVOICE_NO { get; set; }
        public long? DATE_INVOICE { get; set; }
        public int? REPAIRTYPE { get; set; }
        public byte[] OLDID { get; set; }
        public string RPR_PARTNO { get; set; }
        public int? RPR_COSTYPR { get; set; }
        public string RPR_COSTTYPE_TITLE { get; set; }
        public string RPR_XPARTS { get; set; }
        public long? CREATE_DATE { get; set; }
        public int? DELETED { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
        public virtual ERP_LOCATION CREATORLOCNavigation { get; set; }
        public virtual ERP_USER CREATORNavigation { get; set; }
        public virtual ICollection<ERP_ONOFFHISTORY> ERP_ONOFFHISTORies { get; set; }
        public virtual ICollection<ERP_REPAIRPACKAGE_PROBLEM> ERP_REPAIRPACKAGE_PROBLEMs { get; set; }
        public virtual ICollection<ERP_REPAIR_MATERIAL> ERP_REPAIR_MATERIALs { get; set; }
        public virtual ICollection<ERP_REPAIR_RMATERIAL> ERP_REPAIR_RMATERIALs { get; set; }
        public virtual ICollection<ERP_REPAIR_TASK> ERP_REPAIR_TASKs { get; set; }
    }
}
