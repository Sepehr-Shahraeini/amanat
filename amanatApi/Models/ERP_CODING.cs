using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_CODING
    {
        public ERP_CODING()
        {
            ERP_ASSETs = new HashSet<ERP_ASSET>();
            ERP_PAPERITEMs = new HashSet<ERP_PAPERITEM>();
            ERP_REPAIR_MATERIALs = new HashSet<ERP_REPAIR_MATERIAL>();
            ERP_REPAIR_PROBLEMs = new HashSet<ERP_REPAIR_PROBLEM>();
            ERP_REPAIR_RMATERIALs = new HashSet<ERP_REPAIR_RMATERIAL>();
            ERP_TASK_REFs = new HashSet<ERP_TASK_REF>();
            NET_CMPD_GROUPs = new HashSet<NET_CMPD_GROUP>();
            NET_CMPD_MATs = new HashSet<NET_CMPD_MAT>();
            NET_CMPD_TOOLs = new HashSet<NET_CMPD_TOOL>();
            NET_MPD_TASK_MATs = new HashSet<NET_MPD_TASK_MAT>();
            NET_MPD_TASK_TOOLs = new HashSet<NET_MPD_TASK_TOOL>();
        }

        public int ID { get; set; }
        public string TITLE { get; set; }
        public int CODE { get; set; }
        public string FULLCODE { get; set; }
        public int? PARENTID { get; set; }
        public int CODETYPE { get; set; }
        public double? DEPRATE { get; set; }
        public int? DEPTYPE { get; set; }
        public int ASSETTYPE { get; set; }
        public int MODEL { get; set; }
        public int SN { get; set; }
        public int FACTORY { get; set; }
        public int LATINNAME { get; set; }
        public int PN { get; set; }
        public int MATERIAL { get; set; }
        public int COLOR { get; set; }
        public int? ASSET_TYPE { get; set; }
        public int? MASRAFPERIOD { get; set; }

        public virtual ICollection<ERP_ASSET> ERP_ASSETs { get; set; }
        public virtual ICollection<ERP_PAPERITEM> ERP_PAPERITEMs { get; set; }
        public virtual ICollection<ERP_REPAIR_MATERIAL> ERP_REPAIR_MATERIALs { get; set; }
        public virtual ICollection<ERP_REPAIR_PROBLEM> ERP_REPAIR_PROBLEMs { get; set; }
        public virtual ICollection<ERP_REPAIR_RMATERIAL> ERP_REPAIR_RMATERIALs { get; set; }
        public virtual ICollection<ERP_TASK_REF> ERP_TASK_REFs { get; set; }
        public virtual ICollection<NET_CMPD_GROUP> NET_CMPD_GROUPs { get; set; }
        public virtual ICollection<NET_CMPD_MAT> NET_CMPD_MATs { get; set; }
        public virtual ICollection<NET_CMPD_TOOL> NET_CMPD_TOOLs { get; set; }
        public virtual ICollection<NET_MPD_TASK_MAT> NET_MPD_TASK_MATs { get; set; }
        public virtual ICollection<NET_MPD_TASK_TOOL> NET_MPD_TASK_TOOLs { get; set; }
    }
}
