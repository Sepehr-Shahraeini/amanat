using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class ERP_ENSH
    {
        public ERP_ENSH()
        {
            ERP_BILLs = new HashSet<ERP_BILL>();
        }

        public int ID { get; set; }
        public int TYPE { get; set; }
        public string ESHTERAK_NO { get; set; }
        public string SHENASAEI_NO { get; set; }
        public string CONTOR_NO { get; set; }
        public string TAREFE { get; set; }
        public string MANTAGHE { get; set; }
        public string MASRAF { get; set; }
        public int? VAHED { get; set; }
        public string ZARFIAT { get; set; }
        public string GHOTR { get; set; }
        public int? MOSHTAREK_TYPE { get; set; }
        public string MOSHTAREK_NAME { get; set; }
        public long? NASB_DATE { get; set; }
        public long MABNA_DATE { get; set; }
        public double COUNTER { get; set; }
        public int VEKALATNAME { get; set; }
        public int SHENASNAME { get; set; }
        public int EGHRARNAME { get; set; }
        public string FISH_NO { get; set; }
        public double? FISH_PRICE { get; set; }
        public long? FISH_DATE { get; set; }
        public string FAZELAB_GHTR { get; set; }
        public int? FAZELAB_COUNT { get; set; }
        public long? FAZELAB_NASB_DATE { get; set; }
        public string PHASE { get; set; }
        public string AMPER { get; set; }
        public int ASSETID { get; set; }

        public virtual ERP_ASSET ASSET { get; set; }
        public virtual ICollection<ERP_BILL> ERP_BILLs { get; set; }
    }
}
