using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class VIEW_USERS_MAIN
    {
        public string FULLNAME2 { get; set; }
        public string PERSONNELID { get; set; }
        public string BUILDINGNO { get; set; }
        public string ROOTLOCATION_CODE { get; set; }
        public string ROOTLOCATION_TITLE { get; set; }
        public int ACTIVE { get; set; }
        public int LOCATIONID { get; set; }
        public string LOCATION_CODE { get; set; }
        public string LOCATION_TITLE { get; set; }
        public int DELETED { get; set; }
        public byte[] GROUPID { get; set; }
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
    }
}
