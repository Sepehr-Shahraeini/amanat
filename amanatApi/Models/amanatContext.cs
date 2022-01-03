using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace amanatApi.Models
{
    public partial class amanatContext : DbContext
    {
        public amanatContext()
        {
        }

        public amanatContext(DbContextOptions<amanatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ACCCODING> ACCCODINGs { get; set; }
        public virtual DbSet<ACCSANAD> ACCSANADs { get; set; }
        public virtual DbSet<ACCSITEM> ACCSITEMs { get; set; }
        public virtual DbSet<ACCYEAR> ACCYEARs { get; set; }
        public virtual DbSet<CACHEDASSET> CACHEDASSETs { get; set; }
        public virtual DbSet<CITY> CITies { get; set; }
        public virtual DbSet<DATALOG> DATALOGs { get; set; }
        public virtual DbSet<DATALOGDETAIL> DATALOGDETAILs { get; set; }
        public virtual DbSet<DATALOGDETAIL_TEMP> DATALOGDETAIL_TEMPs { get; set; }
        public virtual DbSet<DATALOG_TEMP> DATALOG_TEMPs { get; set; }
        public virtual DbSet<DBMAP> DBMAPs { get; set; }
        public virtual DbSet<DB_INF> DB_INFs { get; set; }
        public virtual DbSet<EFFICIENT_FUNCTION> EFFICIENT_FUNCTIONs { get; set; }
        public virtual DbSet<ERP_ACCCODING> ERP_ACCCODINGs { get; set; }
        public virtual DbSet<ERP_ACCSANAD> ERP_ACCSANADs { get; set; }
        public virtual DbSet<ERP_ACCSITEM> ERP_ACCSITEMs { get; set; }
        public virtual DbSet<ERP_ASSET> ERP_ASSETs { get; set; }
        public virtual DbSet<ERP_ASSET2> ERP_ASSET2s { get; set; }
        public virtual DbSet<ERP_ASSETL> ERP_ASSETLs { get; set; }
        public virtual DbSet<ERP_ASSETOPT_DETAIL> ERP_ASSETOPT_DETAILs { get; set; }
        public virtual DbSet<ERP_ASSET_DEFECT> ERP_ASSET_DEFECTs { get; set; }
        public virtual DbSet<ERP_BILL> ERP_BILLs { get; set; }
        public virtual DbSet<ERP_BILLPHONE> ERP_BILLPHONEs { get; set; }
        public virtual DbSet<ERP_CHANGEOWNER> ERP_CHANGEOWNERs { get; set; }
        public virtual DbSet<ERP_CODING> ERP_CODINGs { get; set; }
        public virtual DbSet<ERP_CODINGACCESS> ERP_CODINGACCESSes { get; set; }
        public virtual DbSet<ERP_CODING_TEMP> ERP_CODING_TEMPs { get; set; }
        public virtual DbSet<ERP_CONTROLPOINT> ERP_CONTROLPOINTs { get; set; }
        public virtual DbSet<ERP_DOC> ERP_DOCs { get; set; }
        public virtual DbSet<ERP_ENSH> ERP_ENSHes { get; set; }
        public virtual DbSet<ERP_ENSHHISTORY> ERP_ENSHHISTORies { get; set; }
        public virtual DbSet<ERP_EXT> ERP_EXTs { get; set; }
        public virtual DbSet<ERP_EXT17> ERP_EXT17s { get; set; }
        public virtual DbSet<ERP_EXT383> ERP_EXT383s { get; set; }
        public virtual DbSet<ERP_EXT384> ERP_EXT384s { get; set; }
        public virtual DbSet<ERP_FIRM> ERP_FIRMs { get; set; }
        public virtual DbSet<ERP_FIRMMEMBER> ERP_FIRMMEMBERs { get; set; }
        public virtual DbSet<ERP_FUELCHARGE> ERP_FUELCHARGEs { get; set; }
        public virtual DbSet<ERP_IN> ERP_INs { get; set; }
        public virtual DbSet<ERP_LABEL> ERP_LABELs { get; set; }
        public virtual DbSet<ERP_LABELRANGE> ERP_LABELRANGEs { get; set; }
        public virtual DbSet<ERP_LABELRANGE_DETAIL> ERP_LABELRANGE_DETAILs { get; set; }
        public virtual DbSet<ERP_LOCATION> ERP_LOCATIONs { get; set; }
        public virtual DbSet<ERP_MAKHZAN> ERP_MAKHZANs { get; set; }
        public virtual DbSet<ERP_MAKHZAN_PART> ERP_MAKHZAN_PARTs { get; set; }
        public virtual DbSet<ERP_MAKHZAN_RANGE> ERP_MAKHZAN_RANGEs { get; set; }
        public virtual DbSet<ERP_MAKOUT> ERP_MAKOUTs { get; set; }
        public virtual DbSet<ERP_MAKOUT_PART> ERP_MAKOUT_PARTs { get; set; }
        public virtual DbSet<ERP_MAKOUT_TR> ERP_MAKOUT_TRs { get; set; }
        public virtual DbSet<ERP_MASRAF_HISTORY> ERP_MASRAF_HISTORies { get; set; }
        public virtual DbSet<ERP_MODEL> ERP_MODELs { get; set; }
        public virtual DbSet<ERP_MSG> ERP_MSGs { get; set; }
        public virtual DbSet<ERP_MSGATTACH> ERP_MSGATTACHes { get; set; }
        public virtual DbSet<ERP_MSGDETAIL> ERP_MSGDETAILs { get; set; }
        public virtual DbSet<ERP_ONOFFHISTORY> ERP_ONOFFHISTORies { get; set; }
        public virtual DbSet<ERP_OPAPER> ERP_OPAPERs { get; set; }
        public virtual DbSet<ERP_OPTION> ERP_OPTIONs { get; set; }
        public virtual DbSet<ERP_ORGANIZATION> ERP_ORGANIZATIONs { get; set; }
        public virtual DbSet<ERP_PAPER> ERP_PAPERs { get; set; }
        public virtual DbSet<ERP_PAPERCORRECTION> ERP_PAPERCORRECTIONs { get; set; }
        public virtual DbSet<ERP_PAPERHISTORY> ERP_PAPERHISTORies { get; set; }
        public virtual DbSet<ERP_PAPERITEM> ERP_PAPERITEMs { get; set; }
        public virtual DbSet<ERP_PAPERITEMCORRECTION> ERP_PAPERITEMCORRECTIONs { get; set; }
        public virtual DbSet<ERP_PAPERSHIFT> ERP_PAPERSHIFTs { get; set; }
        public virtual DbSet<ERP_PROBLEM_T> ERP_PROBLEM_Ts { get; set; }
        public virtual DbSet<ERP_PROP> ERP_PROPs { get; set; }
        public virtual DbSet<ERP_REPAIRPACKAGE> ERP_REPAIRPACKAGEs { get; set; }
        public virtual DbSet<ERP_REPAIRPACKAGE_PROBLEM> ERP_REPAIRPACKAGE_PROBLEMs { get; set; }
        public virtual DbSet<ERP_REPAIR_MATERIAL> ERP_REPAIR_MATERIALs { get; set; }
        public virtual DbSet<ERP_REPAIR_PROBLEM> ERP_REPAIR_PROBLEMs { get; set; }
        public virtual DbSet<ERP_REPAIR_RMATERIAL> ERP_REPAIR_RMATERIALs { get; set; }
        public virtual DbSet<ERP_REPAIR_TASK> ERP_REPAIR_TASKs { get; set; }
        public virtual DbSet<ERP_REPAIR_TASK_OPERATOR> ERP_REPAIR_TASK_OPERATORs { get; set; }
        public virtual DbSet<ERP_REPORTITEM> ERP_REPORTITEMs { get; set; }
        public virtual DbSet<ERP_REPORTTABLE> ERP_REPORTTABLEs { get; set; }
        public virtual DbSet<ERP_REPORTX> ERP_REPORTXes { get; set; }
        public virtual DbSet<ERP_ROLE> ERP_ROLEs { get; set; }
        public virtual DbSet<ERP_ROLEACCESS> ERP_ROLEACCESSes { get; set; }
        public virtual DbSet<ERP_ROLEDENIED> ERP_ROLEDENIEDs { get; set; }
        public virtual DbSet<ERP_SELECTEDCODE> ERP_SELECTEDCODEs { get; set; }
        public virtual DbSet<ERP_TASK_REF> ERP_TASK_REFs { get; set; }
        public virtual DbSet<ERP_TEMPPAPER> ERP_TEMPPAPERs { get; set; }
        public virtual DbSet<ERP_TEMPPAPERITEM> ERP_TEMPPAPERITEMs { get; set; }
        public virtual DbSet<ERP_USER> ERP_USERs { get; set; }
        public virtual DbSet<ERP_USERCODINGACCESS> ERP_USERCODINGACCESSes { get; set; }
        public virtual DbSet<ERP_USERLOCATIONACCESS> ERP_USERLOCATIONACCESSes { get; set; }
        public virtual DbSet<ERP_USERROLE> ERP_USERROLEs { get; set; }
        public virtual DbSet<ERP_USER_ACTIVITY> ERP_USER_ACTIVITies { get; set; }
        public virtual DbSet<ERP_USER_ACTIVITY_TMP> ERP_USER_ACTIVITY_TMPs { get; set; }
        public virtual DbSet<ERP_USER_ACTIVITY_copy1> ERP_USER_ACTIVITY_copy1s { get; set; }
        public virtual DbSet<ERP_USER_CODING> ERP_USER_CODINGs { get; set; }
        public virtual DbSet<ERP_USER_LOCATION> ERP_USER_LOCATIONs { get; set; }
        public virtual DbSet<HELPER_ASSET> HELPER_ASSETs { get; set; }
        public virtual DbSet<LASTUPD> LASTUPDs { get; set; }
        public virtual DbSet<LOCKED_IP> LOCKED_IPs { get; set; }
        public virtual DbSet<LOG> LOGs { get; set; }
        public virtual DbSet<LTEST> LTESTs { get; set; }
        public virtual DbSet<MESSAGEX> MESSAGices { get; set; }
        public virtual DbSet<ORCL_COLUMN> ORCL_COLUMNs { get; set; }
        public virtual DbSet<ORCL_TABLE> ORCL_TABLEs { get; set; }
        public virtual DbSet<REPORTITEM> REPORTITEMs { get; set; }
        public virtual DbSet<REPORTITEMTABLE> REPORTITEMTABLEs { get; set; }
        public virtual DbSet<REPORTITEMTABLE_TEMP> REPORTITEMTABLE_TEMPs { get; set; }
        public virtual DbSet<REPORTITEM_TEMP2> REPORTITEM_TEMP2s { get; set; }
        public virtual DbSet<REPORTITEM_temp> REPORTITEM_temps { get; set; }
        public virtual DbSet<REPORTRELATION> REPORTRELATIONs { get; set; }
        public virtual DbSet<REPORTSETTING> REPORTSETTINGs { get; set; }
        public virtual DbSet<REPORTSETTINGCOLUMN> REPORTSETTINGCOLUMNs { get; set; }
        public virtual DbSet<REPORTSETTINGFILTERITEM> REPORTSETTINGFILTERITEMs { get; set; }
        public virtual DbSet<REPORTTABLE> REPORTTABLEs { get; set; }
        public virtual DbSet<REPORTUSER> REPORTUSERs { get; set; }
        public virtual DbSet<REPORTUSERSELECTEDCOLUMN> REPORTUSERSELECTEDCOLUMNs { get; set; }
        public virtual DbSet<REPORTUSER_ACCESS> REPORTUSER_ACCESSes { get; set; }
        public virtual DbSet<REPORTUSER_ALLOWED> REPORTUSER_ALLOWEDs { get; set; }
        public virtual DbSet<REPORTUSER_CODE> REPORTUSER_CODEs { get; set; }
        public virtual DbSet<REPORTUSER_FILTER> REPORTUSER_FILTERs { get; set; }
        public virtual DbSet<REPORTUSER_ITEM> REPORTUSER_ITEMs { get; set; }
        public virtual DbSet<REPORTUSER_TABLE> REPORTUSER_TABLEs { get; set; }
        public virtual DbSet<REPORTX> REPORTXes { get; set; }
        public virtual DbSet<STATE> STATEs { get; set; }
        public virtual DbSet<USER_ASSET_TYPE> USER_ASSET_TYPEs { get; set; }
        public virtual DbSet<USER_GRIDSETTING> USER_GRIDSETTINGs { get; set; }
        public virtual DbSet<USER_PROPERTy> USER_PROPERTIEs { get; set; }
        public virtual DbSet<VIEW_ASSET> VIEW_ASSETs { get; set; }
        public virtual DbSet<VIEW_ERP_CODING_DET> VIEW_ERP_CODING_DETs { get; set; }
        public virtual DbSet<VIEW_OPTION> VIEW_OPTIONs { get; set; }
        public virtual DbSet<VIEW_USERCODINGACCESS> VIEW_USERCODINGACCESSes { get; set; }
        public virtual DbSet<VIEW_USERLOCATIONACCESS> VIEW_USERLOCATIONACCESSes { get; set; }
        public virtual DbSet<WASSET> WASSETs { get; set; }
        public virtual DbSet<X_REPORT> X_REPORTs { get; set; }
        public virtual DbSet<_ORCL_ERROR> _ORCL_ERRORs { get; set; }
        public virtual DbSet<_ORCL_INSERT> _ORCL_INSERTs { get; set; }
        public virtual DbSet<_ORCL_Result> _ORCL_Results { get; set; }
        public virtual DbSet<_test> _tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Persian_100_CI_AI");

            modelBuilder.Entity<ACCCODING>(entity =>
            {
                entity.ToTable("ACCCODING", "AMVALWEB");

                entity.Property(e => e.CREATEUSER).HasMaxLength(100);

                entity.Property(e => e.FULLNAME).HasMaxLength(200);

                entity.Property(e => e.ROWGUID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.TITLE).HasMaxLength(100);

                entity.Property(e => e.UPDATEUSER).HasMaxLength(100);
            });

            modelBuilder.Entity<ACCSANAD>(entity =>
            {
                entity.ToTable("ACCSANAD", "AMVALWEB");

                entity.Property(e => e.ID).HasMaxLength(16);

                entity.Property(e => e.APPROVEDUSER).HasMaxLength(50);

                entity.Property(e => e.BASEDON).HasMaxLength(20);

                entity.Property(e => e.BASEDONID).HasMaxLength(16);

                entity.Property(e => e.CREATEUSER).HasMaxLength(50);

                entity.Property(e => e.SANADTYPE).HasMaxLength(50);

                entity.Property(e => e.TITLE).HasMaxLength(100);

                entity.Property(e => e.UPDATEUSER).HasMaxLength(50);
            });

            modelBuilder.Entity<ACCSITEM>(entity =>
            {
                entity.ToTable("ACCSITEM", "AMVALWEB");

                entity.HasIndex(e => e.SANADID, "FR_MOJI_S_1345");

                entity.Property(e => e.ID).HasMaxLength(16);

                entity.Property(e => e.RELATEDPAPERITEM).HasMaxLength(16);

                entity.Property(e => e.SANADID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.SANAD)
                    .WithMany(p => p.ACCSITEMs)
                    .HasForeignKey(d => d.SANADID)
                    .HasConstraintName("SYS_C0011156");
            });

            modelBuilder.Entity<ACCYEAR>(entity =>
            {
                entity.ToTable("ACCYEAR", "AMVALWEB");
            });

            modelBuilder.Entity<CACHEDASSET>(entity =>
            {
                entity.ToTable("CACHEDASSETS", "AMVALWEB");

                entity.HasIndex(e => e.ASSETID, "IDX_CHC_01");

                entity.Property(e => e.CACHEDKEY).HasMaxLength(2000);

                entity.Property(e => e.SYSRESDATE).HasPrecision(0);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.CACHEDASSETs)
                    .HasForeignKey(d => d.ASSETID)
                    .HasConstraintName("CA_ASSET");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.CACHEDASSETs)
                    .HasForeignKey(d => d.USERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CA_USER");
            });

            modelBuilder.Entity<CITY>(entity =>
            {
                entity.HasKey(e => e.PK)
                    .HasName("SYS_C0010989");

                entity.ToTable("CITY", "AMVALWEB");

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<DATALOG>(entity =>
            {
                entity.ToTable("DATALOG", "AMVALWEB");

                entity.Property(e => e.ENTITYNAME)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<DATALOGDETAIL>(entity =>
            {
                entity.HasKey(e => e.PK)
                    .HasName("SYS_C0011035");

                entity.ToTable("DATALOGDETAIL", "AMVALWEB");

                entity.HasIndex(e => e.LOGID, "IDX_LOGID");

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.NEWVALUE).HasMaxLength(2000);

                entity.Property(e => e.OLDVALUE).HasMaxLength(2000);

                entity.HasOne(d => d.LOG)
                    .WithMany(p => p.DATALOGDETAILs)
                    .HasForeignKey(d => d.LOGID)
                    .HasConstraintName("DLOGDETFK_01");
            });

            modelBuilder.Entity<DATALOGDETAIL_TEMP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATALOGDETAIL_TEMP", "AMVALWEB");

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.NEWVALUE).HasMaxLength(2000);

                entity.Property(e => e.OLDVALUE).HasMaxLength(2000);

                entity.Property(e => e.PK).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DATALOG_TEMP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATALOG_TEMP", "AMVALWEB");

                entity.Property(e => e.ENTITYNAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DBMAP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DBMAP", "AMVALWEB");

                entity.Property(e => e.COLUMN_NAME).HasMaxLength(1000);

                entity.Property(e => e.DATA_TYPE).HasMaxLength(1000);

                entity.Property(e => e.TABLE_NAME).HasMaxLength(1000);
            });

            modelBuilder.Entity<DB_INF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DB_INF", "AMVALWEB");

                entity.Property(e => e.COLUMN_NAME).HasMaxLength(2000);

                entity.Property(e => e.DATA_LENGTH).HasMaxLength(2000);

                entity.Property(e => e.DATA_PRECISION).HasMaxLength(2000);

                entity.Property(e => e.DATA_TYPE).HasMaxLength(2000);

                entity.Property(e => e.KEY1).HasMaxLength(2000);

                entity.Property(e => e.NULLABLE).HasMaxLength(2000);

                entity.Property(e => e.TABLE_NAME).HasMaxLength(2000);

                entity.Property(e => e.VERSION).HasMaxLength(2000);
            });

            modelBuilder.Entity<EFFICIENT_FUNCTION>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EFFICIENT_FUNCTIONS", "AMVALWEB");

                entity.HasIndex(e => e.DATA_LENGTH, "EFFICIENT_FUNCTIONS_IDX");
            });

            modelBuilder.Entity<ERP_ACCCODING>(entity =>
            {
                entity.ToTable("ERP_ACCCODING", "AMVALWEB");

                entity.Property(e => e.FULLNAME).HasMaxLength(1000);

                entity.Property(e => e.TITLE).HasMaxLength(1000);
            });

            modelBuilder.Entity<ERP_ACCSANAD>(entity =>
            {
                entity.ToTable("ERP_ACCSANAD", "AMVALWEB");

                entity.Property(e => e.APPROVEDDATE).HasDefaultValueSql("((0))");

                entity.Property(e => e.NO)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ORGANIZATION).HasDefaultValueSql("((0))");

                entity.Property(e => e.TITLE).HasMaxLength(2000);

                entity.Property(e => e.TOTAL).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PAPER)
                    .WithMany(p => p.ERP_ACCSANADs)
                    .HasForeignKey(d => d.PAPERID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ACCSANAD_01");
            });

            modelBuilder.Entity<ERP_ACCSITEM>(entity =>
            {
                entity.ToTable("ERP_ACCSITEM", "AMVALWEB");

                entity.HasOne(d => d.PAPERITEM)
                    .WithMany(p => p.ERP_ACCSITEMs)
                    .HasForeignKey(d => d.PAPERITEMID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ACCSITEM_02");

                entity.HasOne(d => d.SANAD)
                    .WithMany(p => p.ERP_ACCSITEMs)
                    .HasForeignKey(d => d.SANADID)
                    .HasConstraintName("FK_ACCSITEM_01");
            });

            modelBuilder.Entity<ERP_ASSET>(entity =>
            {
                entity.ToTable("ERP_ASSET", "AMVALWEB");

                entity.HasIndex(e => e.CODEID, "IDX_ASSET_CODE");

                entity.HasIndex(e => e.CREATOR, "IDX_ASSET_CREATOR");

                entity.HasIndex(e => e.LABEL, "IDX_ASSET_LABEL")
                    .IsUnique();

                entity.HasIndex(e => e.LABELTYPE, "IDX_ASSET_LBLTYPE");

                entity.HasIndex(e => e.NAME, "IDX_ASSET_NAME");

                entity.HasIndex(e => e.NLABEL, "IDX_ASSET_NLABEL");

                entity.HasIndex(e => e.OLDEXTID, "IDX_ASSET_OLDEXT");

                entity.HasIndex(e => e.PARENTID, "IDX_ASSET_PARENTID");

                entity.HasIndex(e => e.PHONE_NO, "IDX_ASSET_PHONE");

                entity.HasIndex(e => e.RECLOCATIONID, "IDX_ASSET_RECLOC");

                entity.HasIndex(e => e.SNBN, "IDX_ASSET_SNBN");

                entity.HasIndex(e => e.ASSETTYPE, "IDX_ASSET_TYPE");

                entity.Property(e => e.AMLAK_POSTALCODE).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_SABTI_ASLI).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_SABTI_FAREI).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_VARAGHE_MALEKIAT).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.EXITTO).HasMaxLength(2000);

                entity.Property(e => e.EXPDATEG).HasPrecision(0);

                entity.Property(e => e.KHODRO_ENTEZAMI).HasMaxLength(2000);

                entity.Property(e => e.KHODRO_MOTOR).HasMaxLength(2000);

                entity.Property(e => e.KHODRO_SHASI).HasMaxLength(2000);

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.LATINNAME).HasMaxLength(2000);

                entity.Property(e => e.LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.LETTERSUBJECT).HasMaxLength(2000);

                entity.Property(e => e.MODEL).HasMaxLength(2000);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.OLDCODE).HasMaxLength(2000);

                entity.Property(e => e.OLDID).HasMaxLength(16);

                entity.Property(e => e.OLDLABEL).HasMaxLength(2000);

                entity.Property(e => e.OLDLID).HasMaxLength(2000);

                entity.Property(e => e.OLDOWNER).HasMaxLength(2000);

                entity.Property(e => e.PHONE_NO).HasMaxLength(2000);

                entity.Property(e => e.PN).HasMaxLength(2000);

                entity.Property(e => e.PRODATEG).HasPrecision(0);

                entity.Property(e => e.SELLERADDRESS).HasMaxLength(2000);

                entity.Property(e => e.SELLERNAME).HasMaxLength(2000);

                entity.Property(e => e.SELLERPHONE).HasMaxLength(2000);

                entity.Property(e => e.SNBN).HasMaxLength(2000);

                entity.Property(e => e.TRACKINGNO).HasMaxLength(2000);

                entity.Property(e => e.WARANTY).HasMaxLength(2000);

                entity.HasOne(d => d.CODE)
                    .WithMany(p => p.ERP_ASSETs)
                    .HasForeignKey(d => d.CODEID)
                    .HasConstraintName("FK_ERP_ASSET_ERP_CODING_ID");

                entity.HasOne(d => d.EXTRACTFROM)
                    .WithMany(p => p.InverseEXTRACTFROM)
                    .HasForeignKey(d => d.EXTRACTFROMID)
                    .HasConstraintName("FK_ERP_ASSET_ERP_ASSET_ID1");

                entity.HasOne(d => d.KEEPINGLOCATION)
                    .WithMany(p => p.ERP_ASSETKEEPINGLOCATIONs)
                    .HasForeignKey(d => d.KEEPINGLOCATIONID)
                    .HasConstraintName("FK_ERP_ASSET_ERP_LOCATION_ID1");

                entity.HasOne(d => d.MAINOWNERNavigation)
                    .WithMany(p => p.ERP_ASSETs)
                    .HasForeignKey(d => d.MAINOWNER)
                    .HasConstraintName("FK_ERP_ASSET_ORGAN");

                entity.HasOne(d => d.PARENT)
                    .WithMany(p => p.InversePARENT)
                    .HasForeignKey(d => d.PARENTID)
                    .HasConstraintName("FK_ERP_ASSET_ERP_ASSET_ID2");

                entity.HasOne(d => d.RECEIVER)
                    .WithMany(p => p.ERP_ASSETs)
                    .HasForeignKey(d => d.RECEIVERID)
                    .HasConstraintName("FK_ERP_ASSET_ERP_USERS_ID1");

                entity.HasOne(d => d.RECLOCATION)
                    .WithMany(p => p.ERP_ASSETRECLOCATIONs)
                    .HasForeignKey(d => d.RECLOCATIONID)
                    .HasConstraintName("FK_ERP_ASSET_ERP_LOCATION_ID3");

                entity.HasOne(d => d.ROOTLOCATIONNavigation)
                    .WithMany(p => p.ERP_ASSETROOTLOCATIONNavigations)
                    .HasForeignKey(d => d.ROOTLOCATION)
                    .HasConstraintName("FK_ERP_ASSET_ERP_LOCATION_ID2");
            });

            modelBuilder.Entity<ERP_ASSET2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ERP_ASSET2", "AMVALWEB");

                entity.Property(e => e.AMLAK_POSTALCODE).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_SABTI_ASLI).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_SABTI_FAREI).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_VARAGHE_MALEKIAT).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.EXITTO).HasMaxLength(2000);

                entity.Property(e => e.EXPDATEG).HasPrecision(0);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.KHODRO_ENTEZAMI).HasMaxLength(2000);

                entity.Property(e => e.KHODRO_MOTOR).HasMaxLength(2000);

                entity.Property(e => e.KHODRO_SHASI).HasMaxLength(2000);

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.LATINNAME).HasMaxLength(2000);

                entity.Property(e => e.LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.LETTERSUBJECT).HasMaxLength(2000);

                entity.Property(e => e.MODEL).HasMaxLength(2000);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.OLDCODE).HasMaxLength(2000);

                entity.Property(e => e.OLDID).HasMaxLength(16);

                entity.Property(e => e.OLDLABEL).HasMaxLength(2000);

                entity.Property(e => e.OLDLID).HasMaxLength(2000);

                entity.Property(e => e.OLDOWNER).HasMaxLength(2000);

                entity.Property(e => e.PHONE_NO).HasMaxLength(2000);

                entity.Property(e => e.PN).HasMaxLength(2000);

                entity.Property(e => e.PRODATEG).HasPrecision(0);

                entity.Property(e => e.SELLERADDRESS).HasMaxLength(2000);

                entity.Property(e => e.SELLERNAME).HasMaxLength(2000);

                entity.Property(e => e.SELLERPHONE).HasMaxLength(2000);

                entity.Property(e => e.SNBN).HasMaxLength(2000);

                entity.Property(e => e.TRACKINGNO).HasMaxLength(2000);

                entity.Property(e => e.WARANTY).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_ASSETL>(entity =>
            {
                entity.ToTable("ERP_ASSETL", "AMVALWEB");

                entity.HasIndex(e => e.CODEID, "IDX_ASSET_CODE_copy1");

                entity.HasIndex(e => e.CREATOR, "IDX_ASSET_CREATOR_copy1");

                entity.HasIndex(e => e.LABEL, "IDX_ASSET_LABEL_copy1")
                    .IsUnique();

                entity.HasIndex(e => e.LABELTYPE, "IDX_ASSET_LBLTYPE_copy1");

                entity.HasIndex(e => e.NAME, "IDX_ASSET_NAME_copy1");

                entity.HasIndex(e => e.NLABEL, "IDX_ASSET_NLABEL_copy1");

                entity.HasIndex(e => e.OLDEXTID, "IDX_ASSET_OLDEXT_copy1");

                entity.HasIndex(e => e.PARENTID, "IDX_ASSET_PARENTID_copy1");

                entity.HasIndex(e => e.PHONE_NO, "IDX_ASSET_PHONE_copy1");

                entity.HasIndex(e => e.RECLOCATIONID, "IDX_ASSET_RECLOC_copy1");

                entity.HasIndex(e => e.SNBN, "IDX_ASSET_SNBN_copy1");

                entity.HasIndex(e => e.ASSETTYPE, "IDX_ASSET_TYPE_copy1");

                entity.Property(e => e.AMLAK_POSTALCODE).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_SABTI_ASLI).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_SABTI_FAREI).HasMaxLength(2000);

                entity.Property(e => e.AMLAK_VARAGHE_MALEKIAT).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.EXITTO).HasMaxLength(2000);

                entity.Property(e => e.EXPDATEG).HasPrecision(0);

                entity.Property(e => e.KHODRO_ENTEZAMI).HasMaxLength(2000);

                entity.Property(e => e.KHODRO_MOTOR).HasMaxLength(2000);

                entity.Property(e => e.KHODRO_SHASI).HasMaxLength(2000);

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.LATINNAME).HasMaxLength(2000);

                entity.Property(e => e.LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.LETTERSUBJECT).HasMaxLength(2000);

                entity.Property(e => e.MODEL).HasMaxLength(2000);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.OLDCODE).HasMaxLength(2000);

                entity.Property(e => e.OLDID).HasMaxLength(16);

                entity.Property(e => e.OLDLABEL).HasMaxLength(2000);

                entity.Property(e => e.OLDLID).HasMaxLength(2000);

                entity.Property(e => e.OLDOWNER).HasMaxLength(2000);

                entity.Property(e => e.PHONE_NO).HasMaxLength(2000);

                entity.Property(e => e.PN).HasMaxLength(2000);

                entity.Property(e => e.PRODATEG).HasPrecision(0);

                entity.Property(e => e.SELLERADDRESS).HasMaxLength(2000);

                entity.Property(e => e.SELLERNAME).HasMaxLength(2000);

                entity.Property(e => e.SELLERPHONE).HasMaxLength(2000);

                entity.Property(e => e.SNBN).HasMaxLength(2000);

                entity.Property(e => e.TRACKINGNO).HasMaxLength(2000);

                entity.Property(e => e.WARANTY).HasMaxLength(2000);

                entity.HasOne(d => d.CODE)
                    .WithMany(p => p.ERP_ASSETLs)
                    .HasForeignKey(d => d.CODEID)
                    .HasConstraintName("FK__ERP_ASSET__CODEI__7A8729A3");

                entity.HasOne(d => d.EXTRACTFROM)
                    .WithMany(p => p.ERP_ASSETLEXTRACTFROMs)
                    .HasForeignKey(d => d.EXTRACTFROMID)
                    .HasConstraintName("FK__ERP_ASSET__EXTRA__789EE131");

                entity.HasOne(d => d.KEEPINGLOCATION)
                    .WithMany(p => p.ERP_ASSETLKEEPINGLOCATIONs)
                    .HasForeignKey(d => d.KEEPINGLOCATIONID)
                    .HasConstraintName("FK__ERP_ASSET__KEEPI__7B7B4DDC");

                entity.HasOne(d => d.MAINOWNERNavigation)
                    .WithMany(p => p.ERP_ASSETLs)
                    .HasForeignKey(d => d.MAINOWNER)
                    .HasConstraintName("FK__ERP_ASSET__MAINO__7E57BA87");

                entity.HasOne(d => d.PARENT)
                    .WithMany(p => p.ERP_ASSETLPARENTs)
                    .HasForeignKey(d => d.PARENTID)
                    .HasConstraintName("FK__ERP_ASSET__PAREN__7993056A");

                entity.HasOne(d => d.RECEIVER)
                    .WithMany(p => p.ERP_ASSETLs)
                    .HasForeignKey(d => d.RECEIVERID)
                    .HasConstraintName("FK__ERP_ASSET__RECEI__7F4BDEC0");

                entity.HasOne(d => d.RECLOCATION)
                    .WithMany(p => p.ERP_ASSETLRECLOCATIONs)
                    .HasForeignKey(d => d.RECLOCATIONID)
                    .HasConstraintName("FK__ERP_ASSET__RECLO__7D63964E");

                entity.HasOne(d => d.ROOTLOCATIONNavigation)
                    .WithMany(p => p.ERP_ASSETLROOTLOCATIONNavigations)
                    .HasForeignKey(d => d.ROOTLOCATION)
                    .HasConstraintName("FK__ERP_ASSET__ROOTL__7C6F7215");
            });

            modelBuilder.Entity<ERP_ASSETOPT_DETAIL>(entity =>
            {
                entity.ToTable("ERP_ASSETOPT_DETAIL", "AMVALWEB");

                entity.Property(e => e.CATEGORY).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_ASSETOPT_DETAILs)
                    .HasForeignKey(d => d.ASSETID)
                    .HasConstraintName("FK_AOD_01");
            });

            modelBuilder.Entity<ERP_ASSET_DEFECT>(entity =>
            {
                entity.ToTable("ERP_ASSET_DEFECT", "AMVALWEB");

                entity.Property(e => e.NO).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_ASSET_DEFECTs)
                    .HasForeignKey(d => d.ASSETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AD_01");

                entity.HasOne(d => d.PROBLEM)
                    .WithMany(p => p.ERP_ASSET_DEFECTs)
                    .HasForeignKey(d => d.PROBLEMID)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_AD_02");
            });

            modelBuilder.Entity<ERP_BILL>(entity =>
            {
                entity.ToTable("ERP_BILL", "AMVALWEB");

                entity.Property(e => e.RAHGIRI_NO).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.RESID_IMG_URL).HasMaxLength(2000);

                entity.Property(e => e.SHENASE_GHABZ)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.SHENASE_PARDAKHT)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.XLSFILE).HasMaxLength(2000);

                entity.HasOne(d => d.ENSH)
                    .WithMany(p => p.ERP_BILLs)
                    .HasForeignKey(d => d.ENSH_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BILL_01");
            });

            modelBuilder.Entity<ERP_BILLPHONE>(entity =>
            {
                entity.ToTable("ERP_BILLPHONE", "AMVALWEB");

                entity.Property(e => e.RAHGIRI_NO).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.RESID_IMG_URL).HasMaxLength(2000);

                entity.Property(e => e.SHENASE_GHABZ)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.SHENASE_PARDAKHT)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.XLSFILE).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_CHANGEOWNER>(entity =>
            {
                entity.ToTable("ERP_CHANGEOWNER", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.NEWMAHRAMANE).HasMaxLength(2000);

                entity.Property(e => e.NEWOWNER).HasMaxLength(2000);

                entity.Property(e => e.NEWPLAK).HasMaxLength(2000);

                entity.Property(e => e.OLDMAHRAMANE).HasMaxLength(2000);

                entity.Property(e => e.OLDOWNER).HasMaxLength(2000);

                entity.Property(e => e.OLDPLAK).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_CHANGEOWNERs)
                    .HasForeignKey(d => d.ASSETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_01");
            });

            modelBuilder.Entity<ERP_CODING>(entity =>
            {
                entity.ToTable("ERP_CODING", "AMVALWEB");

                entity.HasIndex(e => e.FULLCODE, "ERP_CODING_I_FULLCODE")
                    .IsUnique();

                entity.HasIndex(e => new { e.CODE, e.PARENTID }, "ERP_CODING_U_CODE_PARENTID")
                    .IsUnique();

                entity.Property(e => e.FULLCODE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_CODINGACCESS>(entity =>
            {
                entity.ToTable("ERP_CODINGACCESS", "AMVALWEB");
            });

            modelBuilder.Entity<ERP_CODING_TEMP>(entity =>
            {
                entity.ToTable("ERP_CODING_TEMP", "AMVALWEB");

                entity.Property(e => e.FULLCODE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_CONTROLPOINT>(entity =>
            {
                entity.ToTable("ERP_CONTROLPOINT", "AMVALWEB");
            });

            modelBuilder.Entity<ERP_DOC>(entity =>
            {
                entity.ToTable("ERP_DOC", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.FILEEXT).HasMaxLength(2000);

                entity.Property(e => e.FILEKEY).HasMaxLength(2000);

                entity.Property(e => e.FILEURL).HasMaxLength(2000);

                entity.Property(e => e.KEYWORDS).HasMaxLength(2000);

                entity.Property(e => e.NO).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_ENSH>(entity =>
            {
                entity.ToTable("ERP_ENSH", "AMVALWEB");

                entity.HasIndex(e => e.CONTOR_NO, "UQ_ENSH_CONTOR")
                    .IsUnique();

                entity.HasIndex(e => new { e.TYPE, e.ESHTERAK_NO }, "UQ_ENSH_ESHTERAK")
                    .IsUnique();

                entity.HasIndex(e => new { e.TYPE, e.SHENASAEI_NO }, "UQ_ENSH_SHENASAEI")
                    .IsUnique();

                entity.Property(e => e.AMPER).HasMaxLength(2000);

                entity.Property(e => e.CONTOR_NO).HasMaxLength(2000);

                entity.Property(e => e.ESHTERAK_NO)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.FAZELAB_GHTR).HasMaxLength(2000);

                entity.Property(e => e.FISH_NO).HasMaxLength(2000);

                entity.Property(e => e.GHOTR).HasMaxLength(2000);

                entity.Property(e => e.MANTAGHE).HasMaxLength(2000);

                entity.Property(e => e.MASRAF).HasMaxLength(2000);

                entity.Property(e => e.MOSHTAREK_NAME).HasMaxLength(2000);

                entity.Property(e => e.PHASE).HasMaxLength(2000);

                entity.Property(e => e.SHENASAEI_NO).HasMaxLength(2000);

                entity.Property(e => e.TAREFE).HasMaxLength(2000);

                entity.Property(e => e.ZARFIAT).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_ENSHes)
                    .HasForeignKey(d => d.ASSETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ENSH_01");
            });

            modelBuilder.Entity<ERP_ENSHHISTORY>(entity =>
            {
                entity.ToTable("ERP_ENSHHISTORY", "AMVALWEB");
            });

            modelBuilder.Entity<ERP_EXT>(entity =>
            {
                entity.ToTable("ERP_EXT", "AMVALWEB");

                entity.Property(e => e.ASSETS_P10_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_10).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_11).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_12).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_7).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_8).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P10_9).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_7).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_8).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P11_9).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P12_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P12_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P12_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P12_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P12_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P12_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P13_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P13_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P13_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P13_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P14_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P14_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P14_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P14_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P14_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P14_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_10).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_11).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_12).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_13).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_14).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_15).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_16).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_17).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_18).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_19).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_20).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_7).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_8).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P15_9).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_7).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_8).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P1_9).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_7).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_8).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P2_9).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_10).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_11).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_12).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_13).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_14).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_15).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_16).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_17).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_7).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_8).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P3_9).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P5_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P5_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P5_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P5_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P6_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P6_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P6_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P6_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P6_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P6_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P6_7).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_10).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_11).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_12).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_13).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_14).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_15).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_16).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_6).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_7).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_8).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P7_9).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P8_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P8_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P8_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P8_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P9_1).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P9_2).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P9_3).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P9_4).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P9_5).HasMaxLength(2000);

                entity.Property(e => e.ASSETS_P9_6).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_EXTs)
                    .HasForeignKey(d => d.ASSETID)
                    .HasConstraintName("FK_EXT_01");
            });

            modelBuilder.Entity<ERP_EXT17>(entity =>
            {
                entity.ToTable("ERP_EXT17", "AMVALWEB");

                entity.HasIndex(e => e.MALEK, "IDX_E17_MALEK");

                entity.Property(e => e.ADDRESS).HasMaxLength(2000);

                entity.Property(e => e.BAHREBARDAR).HasMaxLength(2000);

                entity.Property(e => e.BAKHSHSABTI).HasMaxLength(2000);

                entity.Property(e => e.BLUK).HasMaxLength(2000);

                entity.Property(e => e.CITY).HasMaxLength(2000);

                entity.Property(e => e.DAFTARCODE).HasMaxLength(2000);

                entity.Property(e => e.DAFTERSABTNO).HasMaxLength(2000);

                entity.Property(e => e.HORUF).HasMaxLength(2000);

                entity.Property(e => e.MAFRUZ).HasMaxLength(2000);

                entity.Property(e => e.MAKHZANNO).HasMaxLength(2000);

                entity.Property(e => e.MAKHZANVAZIAT).HasMaxLength(2000);

                entity.Property(e => e.MALEK).HasMaxLength(2000);

                entity.Property(e => e.MANTAGHE).HasMaxLength(2000);

                entity.Property(e => e.MELK_NAME).HasMaxLength(2000);

                entity.Property(e => e.MOSHAKHSAT).HasMaxLength(2000);

                entity.Property(e => e.OLDPAYANKAR).HasMaxLength(2000);

                entity.Property(e => e.OTHER).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.SAMT).HasMaxLength(2000);

                entity.Property(e => e.STATE).HasMaxLength(2000);

                entity.Property(e => e.TASISAT).HasMaxLength(2000);

                entity.Property(e => e.VAHED).HasMaxLength(2000);

                entity.Property(e => e.VMALEKIAT).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_EXT383>(entity =>
            {
                entity.ToTable("ERP_EXT383", "AMVALWEB");

                entity.HasIndex(e => e.MALEK, "IDX_E383_MALEK");

                entity.Property(e => e.AGHLAM).HasMaxLength(2000);

                entity.Property(e => e.BENZINCARD).HasMaxLength(2000);

                entity.Property(e => e.BREAKSYSTEM).HasMaxLength(2000);

                entity.Property(e => e.CAPACITYSTR).HasMaxLength(2000);

                entity.Property(e => e.CARD).HasMaxLength(2000);

                entity.Property(e => e.CNGCARD).HasMaxLength(2000);

                entity.Property(e => e.DAFTARCODE).HasMaxLength(2000);

                entity.Property(e => e.DAFTERSABTNO).HasMaxLength(2000);

                entity.Property(e => e.FANARFRONT).HasMaxLength(2000);

                entity.Property(e => e.FANARREAR).HasMaxLength(2000);

                entity.Property(e => e.FARMAN).HasMaxLength(2000);

                entity.Property(e => e.FUELCARD).HasMaxLength(2000);

                entity.Property(e => e.GASOLINECARD).HasMaxLength(2000);

                entity.Property(e => e.IMENI).HasMaxLength(2000);

                entity.Property(e => e.MAHRAMANENO).HasMaxLength(2000);

                entity.Property(e => e.MALEK).HasMaxLength(2000);

                entity.Property(e => e.MOTORMODEL).HasMaxLength(2000);

                entity.Property(e => e.POLLUTION).HasMaxLength(2000);

                entity.Property(e => e.PRODATE).HasMaxLength(2000);

                entity.Property(e => e.PROPERTIES).HasMaxLength(2000);

                entity.Property(e => e.RING).HasMaxLength(2000);

                entity.Property(e => e.SANADREMARK).HasMaxLength(2000);

                entity.Property(e => e.SUSPENSION).HasMaxLength(2000);

                entity.Property(e => e.TIREFRONT).HasMaxLength(2000);

                entity.Property(e => e.TIREREAR).HasMaxLength(2000);

                entity.Property(e => e.VIN).HasMaxLength(2000);

                entity.Property(e => e.VMALEKIAT).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_EXT384>(entity =>
            {
                entity.ToTable("ERP_EXT384", "AMVALWEB");

                entity.HasIndex(e => e.MALEK, "IDX_E384_MALEK");

                entity.Property(e => e.ADDRESS).HasMaxLength(2000);

                entity.Property(e => e.BAHREBARDAR).HasMaxLength(2000);

                entity.Property(e => e.BAHREBARDARI_LOC).HasMaxLength(2000);

                entity.Property(e => e.BANK).HasMaxLength(2000);

                entity.Property(e => e.CITY).HasMaxLength(2000);

                entity.Property(e => e.DAFTARCODE).HasMaxLength(2000);

                entity.Property(e => e.DAFTARSAFHE).HasMaxLength(2000);

                entity.Property(e => e.DAFTERSABTNO).HasMaxLength(2000);

                entity.Property(e => e.FILENO).HasMaxLength(2000);

                entity.Property(e => e.FISHNO).HasMaxLength(2000);

                entity.Property(e => e.MALEK).HasMaxLength(2000);

                entity.Property(e => e.MANTAGHE).HasMaxLength(2000);

                entity.Property(e => e.MELKNO).HasMaxLength(2000);

                entity.Property(e => e.PIN1).HasMaxLength(2000);

                entity.Property(e => e.PIN2).HasMaxLength(2000);

                entity.Property(e => e.PUK1).HasMaxLength(2000);

                entity.Property(e => e.PUK2).HasMaxLength(2000);

                entity.Property(e => e.SABTNO).HasMaxLength(2000);

                entity.Property(e => e.SIMNO).HasMaxLength(2000);

                entity.Property(e => e.SOLHNO).HasMaxLength(2000);

                entity.Property(e => e.STATE).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_FIRM>(entity =>
            {
                entity.ToTable("ERP_FIRM", "AMVALWEB");

                entity.Property(e => e.ALLEY).HasMaxLength(2000);

                entity.Property(e => e.BRAND).HasMaxLength(2000);

                entity.Property(e => e.CITY).HasMaxLength(2000);

                entity.Property(e => e.NAME).HasMaxLength(2000);

                entity.Property(e => e.NATIONALNO).HasMaxLength(2000);

                entity.Property(e => e.PLAK).HasMaxLength(2000);

                entity.Property(e => e.STATE).HasMaxLength(2000);

                entity.Property(e => e.STREET).HasMaxLength(2000);

                entity.Property(e => e.SUBJECT).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_FIRMMEMBER>(entity =>
            {
                entity.ToTable("ERP_FIRMMEMBER", "AMVALWEB");

                entity.Property(e => e.ADDRESS).HasMaxLength(2000);

                entity.Property(e => e.FATHERNAME).HasMaxLength(2000);

                entity.Property(e => e.LNAME).HasMaxLength(2000);

                entity.Property(e => e.MOBILE).HasMaxLength(2000);

                entity.Property(e => e.NAME).HasMaxLength(2000);

                entity.Property(e => e.TEL).HasMaxLength(2000);

                entity.HasOne(d => d.FIRM)
                    .WithMany(p => p.ERP_FIRMMEMBERs)
                    .HasForeignKey(d => d.FIRMID)
                    .HasConstraintName("FK_FIRMM_01");
            });

            modelBuilder.Entity<ERP_FUELCHARGE>(entity =>
            {
                entity.ToTable("ERP_FUELCHARGE", "AMVALWEB");

                entity.HasIndex(e => e.ASSETID, "IDX_FC_ASSETID");

                entity.Property(e => e.RAHGIRI_NO).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.STATIONADDRESS).HasMaxLength(2000);

                entity.Property(e => e.STATIONNO).HasMaxLength(2000);

                entity.Property(e => e.STATIONPHONE).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_IN>(entity =>
            {
                entity.ToTable("ERP_INS", "AMVALWEB");

                entity.HasIndex(e => e.ASSETID, "ERP_INS_IDX_1");

                entity.HasIndex(e => new { e.COMPANY, e.NO }, "UQ_NO")
                    .IsUnique();

                entity.Property(e => e.BIMEGOZAR).HasMaxLength(2000);

                entity.Property(e => e.COMPANY_STR).HasMaxLength(2000);

                entity.Property(e => e.NO)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.SUBJECT).HasMaxLength(2000);

                entity.Property(e => e.TYPE_STR).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_INs)
                    .HasForeignKey(d => d.ASSETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ERP_INS_01");
            });

            modelBuilder.Entity<ERP_LABEL>(entity =>
            {
                entity.ToTable("ERP_LABELS", "AMVALWEB");

                entity.HasIndex(e => e.NLABEL, "IDX_LABELS_LBL");
            });

            modelBuilder.Entity<ERP_LABELRANGE>(entity =>
            {
                entity.HasKey(e => new { e.ID, e.LOCATIONID })
                    .HasName("SYS_C0010819");

                entity.ToTable("ERP_LABELRANGE", "AMVALWEB");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ERP_LABELRANGE_DETAIL>(entity =>
            {
                entity.ToTable("ERP_LABELRANGE_DETAIL", "AMVALWEB");

                entity.HasIndex(e => e.LOCATIONID, "IDX_LBLRD_LID");

                entity.HasIndex(e => e.LBL_TYPE, "IDX_LBLRD_TYPE");
            });

            modelBuilder.Entity<ERP_LOCATION>(entity =>
            {
                entity.ToTable("ERP_LOCATION", "AMVALWEB");

                entity.HasIndex(e => e.ROOTLOCATIONID, "IDX_LOC_ROOT");

                entity.HasIndex(e => e.LOCATIONTYPE, "IDX_LOC_TYPE");

                entity.HasIndex(e => e.FULLCODE, "IND_LOCATION_FULLCODE");

                entity.Property(e => e.FULLCODE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.PHONE).HasMaxLength(2000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_MAKHZAN>(entity =>
            {
                entity.ToTable("ERP_MAKHZAN", "AMVALWEB");

                entity.HasIndex(e => e.SANADTYPE, "IDX_MAK_03");

                entity.HasIndex(e => e.SENDERLOCATIONID, "IDX_MAK_04");

                entity.HasIndex(e => e.RECID, "IDX_MAK_05");

                entity.HasIndex(e => e.APPROVERID, "IDX_MAK_06");

                entity.HasIndex(e => e.NO, "MU_01")
                    .IsUnique();

                entity.HasIndex(e => e.ASSETID, "MU_02")
                    .IsUnique();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.LETTERSUBJECT).HasMaxLength(2000);

                entity.Property(e => e.MOJAVEZKHARIDNO).HasMaxLength(2000);

                entity.Property(e => e.PARTS).HasMaxLength(2000);

                entity.Property(e => e.SOORATJALASENO).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_MAKHZAN_PART>(entity =>
            {
                entity.ToTable("ERP_MAKHZAN_PART", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.DOCUMENTNO).HasMaxLength(2000);

                entity.HasOne(d => d.SANAD)
                    .WithMany(p => p.ERP_MAKHZAN_PARTs)
                    .HasForeignKey(d => d.SANADID)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("MP_01");
            });

            modelBuilder.Entity<ERP_MAKHZAN_RANGE>(entity =>
            {
                entity.ToTable("ERP_MAKHZAN_RANGE", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_MAKOUT>(entity =>
            {
                entity.ToTable("ERP_MAKOUT", "AMVALWEB");

                entity.HasIndex(e => e.SANADID, "IDX_MAKO_01");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.LETTERSUBJECT).HasMaxLength(2000);

                entity.HasOne(d => d.SANAD)
                    .WithMany(p => p.ERP_MAKOUTs)
                    .HasForeignKey(d => d.SANADID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MO_01");
            });

            modelBuilder.Entity<ERP_MAKOUT_PART>(entity =>
            {
                entity.ToTable("ERP_MAKOUT_PART", "AMVALWEB");

                entity.HasIndex(e => new { e.MAKOUTID, e.PARTID }, "MAKOUT_PART_C_1")
                    .IsUnique();

                entity.HasOne(d => d.MAKOUT)
                    .WithMany(p => p.ERP_MAKOUT_PARTs)
                    .HasForeignKey(d => d.MAKOUTID)
                    .HasConstraintName("MPO_01");
            });

            modelBuilder.Entity<ERP_MAKOUT_TR>(entity =>
            {
                entity.ToTable("ERP_MAKOUT_TR", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.LETTERSUBJECT).HasMaxLength(2000);

                entity.Property(e => e.OLD_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.OLD_LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.OLD_LETTERSUBJECT).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_MASRAF_HISTORY>(entity =>
            {
                entity.ToTable("ERP_MASRAF_HISTORY", "AMVALWEB");

                entity.Property(e => e.ASSETCODE).HasMaxLength(2000);

                entity.Property(e => e.ASSETCODETITLE).HasMaxLength(2000);

                entity.Property(e => e.ASSETNAME).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.RECLOCATIONCODE).HasMaxLength(2000);

                entity.Property(e => e.RECLOCATIONTITLE).HasMaxLength(2000);

                entity.Property(e => e.RECNAME).HasMaxLength(2000);

                entity.Property(e => e.RECPID).HasMaxLength(2000);

                entity.Property(e => e.ROOTCODE).HasMaxLength(2000);

                entity.Property(e => e.ROOTTITLE).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_MODEL>(entity =>
            {
                entity.ToTable("ERP_MODEL", "AMVALWEB");

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_MSG>(entity =>
            {
                entity.ToTable("ERP_MSG", "AMVALWEB");

                entity.HasIndex(e => e.CONVERSATION, "IX_MSG_CONVERSATION");

                entity.Property(e => e.ARCHIVEDKEY).HasMaxLength(2000);

                entity.Property(e => e.CONVERSATION)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.SUBJECT).HasMaxLength(2000);

                entity.HasOne(d => d.MASTERMSGNavigation)
                    .WithMany(p => p.InverseMASTERMSGNavigation)
                    .HasForeignKey(d => d.MASTERMSG)
                    .HasConstraintName("FK_MSG_MASTER");

                entity.HasOne(d => d.SENDERNavigation)
                    .WithMany(p => p.ERP_MSGs)
                    .HasForeignKey(d => d.SENDER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MSG_SEN");
            });

            modelBuilder.Entity<ERP_MSGATTACH>(entity =>
            {
                entity.ToTable("ERP_MSGATTACH", "AMVALWEB");

                entity.Property(e => e.ATTACHFILENAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ATTACHURL)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.DESCRPTION).HasMaxLength(2000);

                entity.HasOne(d => d.MSG)
                    .WithMany(p => p.ERP_MSGATTACHes)
                    .HasForeignKey(d => d.MSGID)
                    .HasConstraintName("FK_MSGAT_MSG");
            });

            modelBuilder.Entity<ERP_MSGDETAIL>(entity =>
            {
                entity.ToTable("ERP_MSGDETAIL", "AMVALWEB");

                entity.HasOne(d => d.MSG)
                    .WithMany(p => p.ERP_MSGDETAILs)
                    .HasForeignKey(d => d.MSGID)
                    .HasConstraintName("FK_MSGD_MSG");

                entity.HasOne(d => d.RECEIVERNavigation)
                    .WithMany(p => p.ERP_MSGDETAILs)
                    .HasForeignKey(d => d.RECEIVER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MSG_REC");
            });

            modelBuilder.Entity<ERP_ONOFFHISTORY>(entity =>
            {
                entity.ToTable("ERP_ONOFFHISTORY", "AMVALWEB");

                entity.Property(e => e.CREATEDATE).HasPrecision(0);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.HasOne(d => d.ALTERNATENavigation)
                    .WithMany(p => p.ERP_ONOFFHISTORYALTERNATENavigations)
                    .HasForeignKey(d => d.ALTERNATE)
                    .HasConstraintName("FK_ONOFF_03");

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_ONOFFHISTORYASSETs)
                    .HasForeignKey(d => d.ASSETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ONOFF_01");

                entity.HasOne(d => d.PARENTASSET)
                    .WithMany(p => p.ERP_ONOFFHISTORYPARENTASSETs)
                    .HasForeignKey(d => d.PARENTASSETID)
                    .HasConstraintName("FK_ONOFF_02");

                entity.HasOne(d => d.REPAIRPACKAGENavigation)
                    .WithMany(p => p.ERP_ONOFFHISTORies)
                    .HasForeignKey(d => d.REPAIRPACKAGE)
                    .HasConstraintName("FK_ONOFF_04");
            });

            modelBuilder.Entity<ERP_OPAPER>(entity =>
            {
                entity.HasKey(e => e.PI_ID)
                    .HasName("SYS_C0073707");

                entity.ToTable("ERP_OPAPER", "AMVALWEB");

                entity.Property(e => e.PI_ID).ValueGeneratedNever();

                entity.Property(e => e.ASSET_ASSETTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_BRAND_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_CODE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_CONDITION_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_COUNTRY_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_CURRENCY_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.ASSET_EARNINGTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_ENTEZAMI).HasMaxLength(2000);

                entity.Property(e => e.ASSET_LABEL).HasMaxLength(2000);

                entity.Property(e => e.ASSET_LATINNAME).HasMaxLength(2000);

                entity.Property(e => e.ASSET_LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.ASSET_LETTERSUBJECT).HasMaxLength(2000);

                entity.Property(e => e.ASSET_MODEL).HasMaxLength(2000);

                entity.Property(e => e.ASSET_MOTOR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_NAME).HasMaxLength(2000);

                entity.Property(e => e.ASSET_PHONE_NO).HasMaxLength(2000);

                entity.Property(e => e.ASSET_PN).HasMaxLength(2000);

                entity.Property(e => e.ASSET_RECLOCATION_CODE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_RECLOCATION_TITLE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_REC_NAME).HasMaxLength(2000);

                entity.Property(e => e.ASSET_REC_PID).HasMaxLength(2000);

                entity.Property(e => e.ASSET_ROOT_CODE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_ROOT_TITLE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SABTI_ASLI).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SABTI_FAREI).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SHASI).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SNBN).HasMaxLength(2000);

                entity.Property(e => e.ASSET_TRACKINGNO).HasMaxLength(2000);

                entity.Property(e => e.ASSET_USAGE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_VALUETYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_VARAGHE_MALEKIAT).HasMaxLength(2000);

                entity.Property(e => e.EXIT_STATUS_STR).HasMaxLength(2000);

                entity.Property(e => e.HOGHUGHI_LOCATION_CODE).HasMaxLength(2000);

                entity.Property(e => e.HOGHUGHI_LOCATION_TITLE).HasMaxLength(2000);

                entity.Property(e => e.HOGHUGHI_USER_NAME).HasMaxLength(2000);

                entity.Property(e => e.HOGHUGHI_USER_PID).HasMaxLength(2000);

                entity.Property(e => e.KASR_COMPANY_NAME).HasMaxLength(2000);

                entity.Property(e => e.KASR_DEADLINE_F).HasMaxLength(2000);

                entity.Property(e => e.KASR_PLAK_TAHVILI).HasMaxLength(2000);

                entity.Property(e => e.KASR_RABETNAME).HasMaxLength(2000);

                entity.Property(e => e.KASR_REASON_STR).HasMaxLength(2000);

                entity.Property(e => e.KASR_RETURN_DATE_F).HasMaxLength(2000);

                entity.Property(e => e.KASR_SELL_MOZAIEDE).HasMaxLength(2000);

                entity.Property(e => e.KASR_SERGHAT_NAME).HasMaxLength(2000);

                entity.Property(e => e.KASR_SERGHAT_PID).HasMaxLength(2000);

                entity.Property(e => e.MACHINE_NAME).HasMaxLength(2000);

                entity.Property(e => e.MARJU_REASON_TITLE).HasMaxLength(2000);

                entity.Property(e => e.PI_CONDITION_STR).HasMaxLength(2000);

                entity.Property(e => e.PI_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.PI_QUANTITYUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.PI_REASON).HasMaxLength(2000);

                entity.Property(e => e.PI_RECLOCATION_CODE).HasMaxLength(2000);

                entity.Property(e => e.PI_RECLOCATION_TITLE).HasMaxLength(2000);

                entity.Property(e => e.PI_REC_NAME).HasMaxLength(2000);

                entity.Property(e => e.PI_REC_PID).HasMaxLength(2000);

                entity.Property(e => e.PI_REQUEST_FULLNO).HasMaxLength(2000);

                entity.Property(e => e.PI_SENDERLOCATION_CODE).HasMaxLength(2000);

                entity.Property(e => e.PI_SENDERLOCATION_TITLE).HasMaxLength(2000);

                entity.Property(e => e.PI_SENDER_NAME).HasMaxLength(2000);

                entity.Property(e => e.PI_SENDER_PID).HasMaxLength(2000);

                entity.Property(e => e.PI_TASK_STR).HasMaxLength(2000);

                entity.Property(e => e.PI_TEMP_DELIVERY_FULLNO).HasMaxLength(2000);

                entity.Property(e => e.P_CREATOR_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_CREATOR_PID).HasMaxLength(2000);

                entity.Property(e => e.P_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.P_FULLNO).HasMaxLength(2000);

                entity.Property(e => e.P_ID).ValueGeneratedOnAdd();

                entity.Property(e => e.P_PAPERTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.P_REC_AMIN_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_REC_AMIN_PID).HasMaxLength(2000);

                entity.Property(e => e.P_REC_HAMIN_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_REC_HAMIN_PID).HasMaxLength(2000);

                entity.Property(e => e.P_REC_LOCATION_CODE).HasMaxLength(2000);

                entity.Property(e => e.P_REC_LOCATION_TITLE).HasMaxLength(2000);

                entity.Property(e => e.P_REC_RES_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_REC_RES_PID).HasMaxLength(2000);

                entity.Property(e => e.P_REC_USER_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_REC_USER_PID).HasMaxLength(2000);

                entity.Property(e => e.P_RESERVEDFORUNIT_CODE).HasMaxLength(2000);

                entity.Property(e => e.P_RESERVEDFORUNIT_TITLE).HasMaxLength(2000);

                entity.Property(e => e.P_ROOT2_CODE).HasMaxLength(2000);

                entity.Property(e => e.P_ROOT2_TITLE).HasMaxLength(2000);

                entity.Property(e => e.P_ROOT_CODE).HasMaxLength(2000);

                entity.Property(e => e.P_ROOT_TITLE).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_AMIN_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_AMIN_PID).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_HAMIN_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_HAMIN_PID).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_LOCATION_CODE).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_LOCATION_TITLE).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_RES_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_RES_PID).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_USER_NAME).HasMaxLength(2000);

                entity.Property(e => e.P_SEN_USER_PID).HasMaxLength(2000);

                entity.Property(e => e.SELLER).HasMaxLength(2000);

                entity.Property(e => e.SHOP).HasMaxLength(2000);

                entity.Property(e => e.SHOPADDRESS).HasMaxLength(2000);

                entity.Property(e => e.SHOPPHONE).HasMaxLength(2000);

                entity.Property(e => e.STATUS_BY_NAME).HasMaxLength(2000);

                entity.Property(e => e.STATUS_BY_PIDS).HasMaxLength(2000);

                entity.Property(e => e.STATUS_DATE_F).HasMaxLength(2000);

                entity.Property(e => e.STATUS_STR).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_OPTION>(entity =>
            {
                entity.ToTable("ERP_OPTION", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.TITLE2).HasMaxLength(2000);

                entity.HasOne(d => d.PARENT)
                    .WithMany(p => p.InversePARENT)
                    .HasForeignKey(d => d.PARENTID)
                    .HasConstraintName("FK_OPTION_PARENTID");
            });

            modelBuilder.Entity<ERP_ORGANIZATION>(entity =>
            {
                entity.ToTable("ERP_ORGANIZATION", "AMVALWEB");

                entity.Property(e => e.ADDRESS).HasMaxLength(2000);

                entity.Property(e => e.FAX).HasMaxLength(2000);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.RABETNAME).HasMaxLength(2000);

                entity.Property(e => e.TEL).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_PAPER>(entity =>
            {
                entity.ToTable("ERP_PAPER", "AMVALWEB");

                entity.HasIndex(e => e.ROOTLOCATION, "PAPER_IDX_01");

                entity.HasIndex(e => e.ROOTLOCATION2, "PAPER_IDX_02");

                entity.HasIndex(e => e.SENDER_LOCATION, "PAPER_IDX_03");

                entity.HasIndex(e => e.SENDER_USER, "PAPER_IDX_04");

                entity.HasIndex(e => e.RECEIVER_LOCATION, "PAPER_IDX_05");

                entity.HasIndex(e => e.RECEIVER_USER, "PAPER_IDX_06");

                entity.HasIndex(e => e.SENDE_RRESPONSIBLE_LOCATION, "PAPER_IDX_07");

                entity.HasIndex(e => e.SENDER_RESPONSIBLE_USER, "PAPER_IDX_08");

                entity.HasIndex(e => e.SENDER_AMINAMVAL_LOCATION, "PAPER_IDX_09");

                entity.HasIndex(e => e.SENDER_AMINAMVAL_USER, "PAPER_IDX_10");

                entity.HasIndex(e => e.REC_AMINAMVAL_LOCATION, "PAPER_IDX_11");

                entity.HasIndex(e => e.REC_AMINAMVAL_USER, "PAPER_IDX_12");

                entity.HasIndex(e => e.REC_RESPONSIBLE_LOCATION, "PAPER_IDX_13");

                entity.HasIndex(e => e.REC_RESPONSIBLE_USER, "PAPER_IDX_14");

                entity.HasIndex(e => e.REC_ANBARDAR_USER, "PAPER_IDX_15");

                entity.HasIndex(e => e.REC_ANBARDAR_LOCATION, "PAPER_IDX_16");

                entity.Property(e => e.AWB).HasMaxLength(2000);

                entity.Property(e => e.CACHEDKEY).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.FKMACHINETYPE).HasMaxLength(2000);

                entity.Property(e => e.FULLNO)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.INVOICE_NO).HasMaxLength(2000);

                entity.Property(e => e.KASR_PLAK_TAHVILI).HasMaxLength(2000);

                entity.Property(e => e.KASR_SELL_MOZAIEDE).HasMaxLength(2000);

                entity.Property(e => e.LICENCE_CREATOR).HasMaxLength(2000);

                entity.Property(e => e.LICENCE_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.LICENCE_IMAGE_URL).HasMaxLength(2000);

                entity.Property(e => e.LICENCE_NO).HasMaxLength(2000);

                entity.Property(e => e.OLDID).HasMaxLength(16);

                entity.Property(e => e.OLDRADDESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.QUOTATION).HasMaxLength(2000);

                entity.Property(e => e.SELLER).HasMaxLength(2000);

                entity.Property(e => e.SHOP).HasMaxLength(2000);

                entity.Property(e => e.SHOPADDRESS).HasMaxLength(2000);

                entity.Property(e => e.SHOPPHONE).HasMaxLength(2000);

                entity.Property(e => e.TRANSPORTER).HasMaxLength(2000);

                entity.HasOne(d => d.CREATORNavigation)
                    .WithMany(p => p.ERP_PAPERCREATORNavigations)
                    .HasForeignKey(d => d.CREATOR)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID");

                entity.HasOne(d => d.FKREQUESTLOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERFKREQUESTLOCATIONNavigations)
                    .HasForeignKey(d => d.FKREQUESTLOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID13");

                entity.HasOne(d => d.FKREQUESTUSERNavigation)
                    .WithMany(p => p.ERP_PAPERFKREQUESTUSERNavigations)
                    .HasForeignKey(d => d.FKREQUESTUSER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID12");

                entity.HasOne(d => d.KEEPING_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERKEEPING_LOCATIONNavigations)
                    .HasForeignKey(d => d.KEEPING_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID14");

                entity.HasOne(d => d.RECEIVER_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERRECEIVER_LOCATIONNavigations)
                    .HasForeignKey(d => d.RECEIVER_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID4");

                entity.HasOne(d => d.RECEIVER_USERNavigation)
                    .WithMany(p => p.ERP_PAPERRECEIVER_USERNavigations)
                    .HasForeignKey(d => d.RECEIVER_USER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID3");

                entity.HasOne(d => d.REC_AMINAMVAL_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERREC_AMINAMVAL_LOCATIONNavigations)
                    .HasForeignKey(d => d.REC_AMINAMVAL_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID8");

                entity.HasOne(d => d.REC_AMINAMVAL_USERNavigation)
                    .WithMany(p => p.ERP_PAPERREC_AMINAMVAL_USERNavigations)
                    .HasForeignKey(d => d.REC_AMINAMVAL_USER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID7");

                entity.HasOne(d => d.REC_HEADAMINAMVAL_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERREC_HEADAMINAMVAL_LOCATIONNavigations)
                    .HasForeignKey(d => d.REC_HEADAMINAMVAL_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID9");

                entity.HasOne(d => d.REC_HEADAMINAMVAL_USERNavigation)
                    .WithMany(p => p.ERP_PAPERREC_HEADAMINAMVAL_USERNavigations)
                    .HasForeignKey(d => d.REC_HEADAMINAMVAL_USER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID8");

                entity.HasOne(d => d.REC_RESPONSIBLE_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERREC_RESPONSIBLE_LOCATIONNavigations)
                    .HasForeignKey(d => d.REC_RESPONSIBLE_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID10");

                entity.HasOne(d => d.REC_RESPONSIBLE_USERNavigation)
                    .WithMany(p => p.ERP_PAPERREC_RESPONSIBLE_USERNavigations)
                    .HasForeignKey(d => d.REC_RESPONSIBLE_USER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID9");

                entity.HasOne(d => d.RESERVEDFORUNITNavigation)
                    .WithMany(p => p.ERP_PAPERRESERVEDFORUNITNavigations)
                    .HasForeignKey(d => d.RESERVEDFORUNIT)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID12");

                entity.HasOne(d => d.ROOTLOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERROOTLOCATIONNavigations)
                    .HasForeignKey(d => d.ROOTLOCATION)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID1");

                entity.HasOne(d => d.ROOTLOCATION2Navigation)
                    .WithMany(p => p.ERP_PAPERROOTLOCATION2Navigations)
                    .HasForeignKey(d => d.ROOTLOCATION2)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID2");

                entity.HasOne(d => d.SENDER_AMINAMVAL_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERSENDER_AMINAMVAL_LOCATIONNavigations)
                    .HasForeignKey(d => d.SENDER_AMINAMVAL_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID6");

                entity.HasOne(d => d.SENDER_AMINAMVAL_USERNavigation)
                    .WithMany(p => p.ERP_PAPERSENDER_AMINAMVAL_USERNavigations)
                    .HasForeignKey(d => d.SENDER_AMINAMVAL_USER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID5");

                entity.HasOne(d => d.SENDER_HEADAMINAMVAL_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERSENDER_HEADAMINAMVAL_LOCATIONNavigations)
                    .HasForeignKey(d => d.SENDER_HEADAMINAMVAL_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID7");

                entity.HasOne(d => d.SENDER_HEADAMINAMVAL_USERNavigation)
                    .WithMany(p => p.ERP_PAPERSENDER_HEADAMINAMVAL_USERNavigations)
                    .HasForeignKey(d => d.SENDER_HEADAMINAMVAL_USER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID6");

                entity.HasOne(d => d.SENDER_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERSENDER_LOCATIONNavigations)
                    .HasForeignKey(d => d.SENDER_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID3");

                entity.HasOne(d => d.SENDER_RESPONSIBLE_USERNavigation)
                    .WithMany(p => p.ERP_PAPERSENDER_RESPONSIBLE_USERNavigations)
                    .HasForeignKey(d => d.SENDER_RESPONSIBLE_USER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID4");

                entity.HasOne(d => d.SENDER_USERNavigation)
                    .WithMany(p => p.ERP_PAPERSENDER_USERNavigations)
                    .HasForeignKey(d => d.SENDER_USER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID2");

                entity.HasOne(d => d.SENDE_RRESPONSIBLE_LOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERSENDE_RRESPONSIBLE_LOCATIONNavigations)
                    .HasForeignKey(d => d.SENDE_RRESPONSIBLE_LOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID5");

                entity.HasOne(d => d.TARGETLOCATIONNavigation)
                    .WithMany(p => p.ERP_PAPERTARGETLOCATIONNavigations)
                    .HasForeignKey(d => d.TARGETLOCATION)
                    .HasConstraintName("FK_ERP_PAPER_ERP_LOCATION_ID11");

                entity.HasOne(d => d.TARGETUSERNavigation)
                    .WithMany(p => p.ERP_PAPERTARGETUSERNavigations)
                    .HasForeignKey(d => d.TARGETUSER)
                    .HasConstraintName("FK_ERP_PAPER_ERP_USERS_ID10");
            });

            modelBuilder.Entity<ERP_PAPERCORRECTION>(entity =>
            {
                entity.ToTable("ERP_PAPERCORRECTION", "AMVALWEB");

                entity.HasIndex(e => e.PAPERID, "IX_PCOR_1");

                entity.Property(e => e.AWB).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.FULLNO)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.INVOICE_NO).HasMaxLength(2000);

                entity.Property(e => e.KASR_PLAK_TAHVILI).HasMaxLength(2000);

                entity.Property(e => e.KASR_SELL_MOZAIEDE).HasMaxLength(2000);

                entity.Property(e => e.LICENCE_CREATOR).HasMaxLength(2000);

                entity.Property(e => e.LICENCE_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.LICENCE_IMAGE_URL).HasMaxLength(2000);

                entity.Property(e => e.LICENCE_NO).HasMaxLength(2000);

                entity.Property(e => e.OAWB).HasMaxLength(2000);

                entity.Property(e => e.ODESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.OINVOICE_NO).HasMaxLength(2000);

                entity.Property(e => e.OKASR_PLAK_TAHVILI).HasMaxLength(2000);

                entity.Property(e => e.OKASR_SELL_MOZAIEDE).HasMaxLength(2000);

                entity.Property(e => e.OLICENCE_CREATOR).HasMaxLength(2000);

                entity.Property(e => e.OLICENCE_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.OLICENCE_IMAGE_URL).HasMaxLength(2000);

                entity.Property(e => e.OLICENCE_NO).HasMaxLength(2000);

                entity.Property(e => e.OQUOTATION).HasMaxLength(2000);

                entity.Property(e => e.OTRANSPORTER).HasMaxLength(2000);

                entity.Property(e => e.PAPERFULLNO)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.QUOTATION).HasMaxLength(2000);

                entity.Property(e => e.TRANSPORTER).HasMaxLength(2000);

                entity.HasOne(d => d.PAPER)
                    .WithMany(p => p.ERP_PAPERCORRECTIONs)
                    .HasForeignKey(d => d.PAPERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAPERCOR_PAPERID");
            });

            modelBuilder.Entity<ERP_PAPERHISTORY>(entity =>
            {
                entity.ToTable("ERP_PAPERHISTORY", "AMVALWEB");

                entity.HasOne(d => d.PAPERCORRECTION)
                    .WithMany(p => p.ERP_PAPERHISTORies)
                    .HasForeignKey(d => d.PAPERCORRECTIONID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PH_02");

                entity.HasOne(d => d.PAPER)
                    .WithMany(p => p.ERP_PAPERHISTORies)
                    .HasForeignKey(d => d.PAPERID)
                    .HasConstraintName("FK_PH_01");
            });

            modelBuilder.Entity<ERP_PAPERITEM>(entity =>
            {
                entity.ToTable("ERP_PAPERITEM", "AMVALWEB");

                entity.HasIndex(e => e.QUANTITYUNIT, "IDX_PAPERITEM_01");

                entity.HasIndex(e => e.CONDITION, "IDX_PAPERITEM_02");

                entity.HasIndex(e => e.ASSETID, "IDX_PAPERITEM_03");

                entity.HasIndex(e => e.CODEID, "IDX_PAPERITEM_04");

                entity.HasIndex(e => e.SENDERID, "IDX_PAPERITEM_05");

                entity.HasIndex(e => e.SENDERLOCATIONID, "IDX_PAPERITEM_06");

                entity.HasIndex(e => e.SENDERROOTLOCATIONID, "IDX_PAPERITEM_07");

                entity.Property(e => e.ASSETLABEL)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ASSETTITLE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.BRAND).HasMaxLength(2000);

                entity.Property(e => e.DELETEREASON).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.MODEL).HasMaxLength(2000);

                entity.Property(e => e.OLDID).HasMaxLength(16);

                entity.Property(e => e.OLDPAPERID).HasMaxLength(16);

                entity.Property(e => e.PN).HasMaxLength(2000);

                entity.Property(e => e.REASON).HasMaxLength(2000);

                entity.Property(e => e.SNBN).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_PAPERITEMs)
                    .HasForeignKey(d => d.ASSETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAPERITEM_02");

                entity.HasOne(d => d.CODE)
                    .WithMany(p => p.ERP_PAPERITEMs)
                    .HasForeignKey(d => d.CODEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAPERITEM_CODING_ID");

                entity.HasOne(d => d.PAPER)
                    .WithMany(p => p.ERP_PAPERITEMs)
                    .HasForeignKey(d => d.PAPERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAPERITEM_01");

                entity.HasOne(d => d.REC)
                    .WithMany(p => p.ERP_PAPERITEMRECs)
                    .HasForeignKey(d => d.RECID)
                    .HasConstraintName("FK_PAPERITEM_USERS_ID1");

                entity.HasOne(d => d.RECLOCATION)
                    .WithMany(p => p.ERP_PAPERITEMRECLOCATIONs)
                    .HasForeignKey(d => d.RECLOCATIONID)
                    .HasConstraintName("FK_PAPERITEM_LOCATION1");

                entity.HasOne(d => d.SENDER)
                    .WithMany(p => p.ERP_PAPERITEMSENDERs)
                    .HasForeignKey(d => d.SENDERID)
                    .HasConstraintName("FK_PAPERITEM_USERS_ID2");

                entity.HasOne(d => d.SENDERLOCATION)
                    .WithMany(p => p.ERP_PAPERITEMSENDERLOCATIONs)
                    .HasForeignKey(d => d.SENDERLOCATIONID)
                    .HasConstraintName("FK_PAPERITEM_LOCATION2");

                entity.HasOne(d => d.SENDERROOTLOCATION)
                    .WithMany(p => p.ERP_PAPERITEMSENDERROOTLOCATIONs)
                    .HasForeignKey(d => d.SENDERROOTLOCATIONID)
                    .HasConstraintName("FK_PAPERITEM_LOCATION3");
            });

            modelBuilder.Entity<ERP_PAPERITEMCORRECTION>(entity =>
            {
                entity.ToTable("ERP_PAPERITEMCORRECTION", "AMVALWEB");

                entity.HasIndex(e => e.PAPERITEMID, "IX_PI_COR");

                entity.HasIndex(e => e.PAPERCORRECTIONID, "IX_PI_COR_2");

                entity.Property(e => e.ASSETLABEL).HasMaxLength(2000);

                entity.Property(e => e.ASSETTITLE).HasMaxLength(2000);

                entity.Property(e => e.DELETEREASON).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.MODEL).HasMaxLength(2000);

                entity.Property(e => e.O_ASSETLABEL).HasMaxLength(2000);

                entity.Property(e => e.O_ASSETTITLE).HasMaxLength(2000);

                entity.Property(e => e.O_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.O_MODEL).HasMaxLength(2000);

                entity.Property(e => e.O_PN).HasMaxLength(2000);

                entity.Property(e => e.O_SNBN).HasMaxLength(2000);

                entity.Property(e => e.PN).HasMaxLength(2000);

                entity.Property(e => e.SNBN).HasMaxLength(2000);

                entity.HasOne(d => d.PAPERCORRECTION)
                    .WithMany(p => p.ERP_PAPERITEMCORRECTIONs)
                    .HasForeignKey(d => d.PAPERCORRECTIONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PITEM_COR_PCOR");

                entity.HasOne(d => d.PAPERITEM)
                    .WithMany(p => p.ERP_PAPERITEMCORRECTIONs)
                    .HasForeignKey(d => d.PAPERITEMID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PITEM_COR_PI");
            });

            modelBuilder.Entity<ERP_PAPERSHIFT>(entity =>
            {
                entity.ToTable("ERP_PAPERSHIFT", "AMVALWEB");
            });

            modelBuilder.Entity<ERP_PROBLEM_T>(entity =>
            {
                entity.ToTable("ERP_PROBLEM_TS", "AMVALWEB");

                entity.Property(e => e.REMARK)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.PROBLEM)
                    .WithMany(p => p.ERP_PROBLEM_Ts)
                    .HasForeignKey(d => d.PROBLEMID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TS_01");
            });

            modelBuilder.Entity<ERP_PROP>(entity =>
            {
                entity.ToTable("ERP_PROP", "AMVALWEB");

                entity.Property(e => e.PROPNAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.PROPVALUE).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_REPAIRPACKAGE>(entity =>
            {
                entity.ToTable("ERP_REPAIRPACKAGE", "AMVALWEB");

                entity.HasIndex(e => e.NO, "IDX_REPPAC_NO")
                    .IsUnique();

                entity.Property(e => e.DELAY_REMARK).HasMaxLength(2000);

                entity.Property(e => e.INVOICE_NO).HasMaxLength(2000);

                entity.Property(e => e.NO)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.OLDID).HasMaxLength(16);

                entity.Property(e => e.REASON_REMARK).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.RPR_COSTTYPE_TITLE).HasMaxLength(2000);

                entity.Property(e => e.RPR_PARTNO).HasMaxLength(2000);

                entity.Property(e => e.RPR_XPARTS).HasMaxLength(2000);

                entity.Property(e => e.WORKSHOP).HasMaxLength(2000);

                entity.Property(e => e.WORKSHOP_ADDRESS).HasMaxLength(2000);

                entity.Property(e => e.WORKSHOP_PHONE).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_REPAIRPACKAGEs)
                    .HasForeignKey(d => d.ASSETID)
                    .HasConstraintName("FK_PACK_01");

                entity.HasOne(d => d.CREATORNavigation)
                    .WithMany(p => p.ERP_REPAIRPACKAGEs)
                    .HasForeignKey(d => d.CREATOR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PACK_02");

                entity.HasOne(d => d.CREATORLOCNavigation)
                    .WithMany(p => p.ERP_REPAIRPACKAGEs)
                    .HasForeignKey(d => d.CREATORLOC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PACK_03");
            });

            modelBuilder.Entity<ERP_REPAIRPACKAGE_PROBLEM>(entity =>
            {
                entity.ToTable("ERP_REPAIRPACKAGE_PROBLEMS", "AMVALWEB");

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.HasOne(d => d.REPAIRPACKAGE)
                    .WithMany(p => p.ERP_REPAIRPACKAGE_PROBLEMs)
                    .HasForeignKey(d => d.REPAIRPACKAGEID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_RPC_01");
            });

            modelBuilder.Entity<ERP_REPAIR_MATERIAL>(entity =>
            {
                entity.ToTable("ERP_REPAIR_MATERIAL", "AMVALWEB");

                entity.Property(e => e.BRAND_STR).HasMaxLength(2000);

                entity.Property(e => e.MODEL).HasMaxLength(2000);

                entity.Property(e => e.PN).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.SNBN).HasMaxLength(2000);

                entity.Property(e => e.TITLE).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_REPAIR_MATERIALASSETs)
                    .HasForeignKey(d => d.ASSETID)
                    .HasConstraintName("FK_TASKM_02");

                entity.HasOne(d => d.CODE)
                    .WithMany(p => p.ERP_REPAIR_MATERIALs)
                    .HasForeignKey(d => d.CODEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TASKM_01");

                entity.HasOne(d => d.PASSET)
                    .WithMany(p => p.ERP_REPAIR_MATERIALPASSETs)
                    .HasForeignKey(d => d.PASSETID)
                    .HasConstraintName("FK_TASKM_05");

                entity.HasOne(d => d.REPAIRPACKAGE)
                    .WithMany(p => p.ERP_REPAIR_MATERIALs)
                    .HasForeignKey(d => d.REPAIRPACKAGEID)
                    .HasConstraintName("FK_TASKM_03");

                entity.HasOne(d => d.TASK)
                    .WithMany(p => p.ERP_REPAIR_MATERIALs)
                    .HasForeignKey(d => d.TASKID)
                    .HasConstraintName("FK_TASKM_04");
            });

            modelBuilder.Entity<ERP_REPAIR_PROBLEM>(entity =>
            {
                entity.ToTable("ERP_REPAIR_PROBLEM", "AMVALWEB");

                entity.Property(e => e.CATEGORY).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.TITLE).HasMaxLength(2000);

                entity.HasOne(d => d.CODE)
                    .WithMany(p => p.ERP_REPAIR_PROBLEMs)
                    .HasForeignKey(d => d.CODEID)
                    .HasConstraintName("FK_TASKP");
            });

            modelBuilder.Entity<ERP_REPAIR_RMATERIAL>(entity =>
            {
                entity.ToTable("ERP_REPAIR_RMATERIAL", "AMVALWEB");

                entity.Property(e => e.BRAND_STR).HasMaxLength(2000);

                entity.Property(e => e.MODEL).HasMaxLength(2000);

                entity.Property(e => e.PN).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.SNBN).HasMaxLength(2000);

                entity.Property(e => e.TITLE).HasMaxLength(2000);

                entity.HasOne(d => d.ASSET)
                    .WithMany(p => p.ERP_REPAIR_RMATERIALASSETs)
                    .HasForeignKey(d => d.ASSETID)
                    .HasConstraintName("SYS_C0011143");

                entity.HasOne(d => d.CODE)
                    .WithMany(p => p.ERP_REPAIR_RMATERIALs)
                    .HasForeignKey(d => d.CODEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0011142");

                entity.HasOne(d => d.PASSET)
                    .WithMany(p => p.ERP_REPAIR_RMATERIALPASSETs)
                    .HasForeignKey(d => d.PASSETID)
                    .HasConstraintName("SYS_C0011146");

                entity.HasOne(d => d.REPAIRPACKAGE)
                    .WithMany(p => p.ERP_REPAIR_RMATERIALs)
                    .HasForeignKey(d => d.REPAIRPACKAGEID)
                    .HasConstraintName("SYS_C0011144");

                entity.HasOne(d => d.TASK)
                    .WithMany(p => p.ERP_REPAIR_RMATERIALs)
                    .HasForeignKey(d => d.TASKID)
                    .HasConstraintName("SYS_C0011145");
            });

            modelBuilder.Entity<ERP_REPAIR_TASK>(entity =>
            {
                entity.ToTable("ERP_REPAIR_TASK", "AMVALWEB");

                entity.Property(e => e.DELAY_REMARK).HasMaxLength(2000);

                entity.Property(e => e.NO)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.OPERATOR).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.WORKSHOP).HasMaxLength(2000);

                entity.Property(e => e.WORKSHOPADDRESS).HasMaxLength(2000);

                entity.Property(e => e.WORKSHOPPHONE).HasMaxLength(2000);

                entity.HasOne(d => d.PROBLEM)
                    .WithMany(p => p.ERP_REPAIR_TASKs)
                    .HasForeignKey(d => d.PROBLEMID)
                    .HasConstraintName("FK_TASK_02");

                entity.HasOne(d => d.REPAIRPACKAGE)
                    .WithMany(p => p.ERP_REPAIR_TASKs)
                    .HasForeignKey(d => d.REPAIRPACKAGEID)
                    .HasConstraintName("FK_TASK_01");
            });

            modelBuilder.Entity<ERP_REPAIR_TASK_OPERATOR>(entity =>
            {
                entity.ToTable("ERP_REPAIR_TASK_OPERATOR", "AMVALWEB");

                entity.Property(e => e.OPERATOR).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.HasOne(d => d.TASK)
                    .WithMany(p => p.ERP_REPAIR_TASK_OPERATORs)
                    .HasForeignKey(d => d.TASKID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOP_01");
            });

            modelBuilder.Entity<ERP_REPORTITEM>(entity =>
            {
                entity.ToTable("ERP_REPORTITEM", "AMVALWEB");

                entity.Property(e => e.AGGREGATEFUNCTION).HasMaxLength(200);

                entity.Property(e => e.CONVERTMETHOD).HasMaxLength(1000);

                entity.Property(e => e.DATATYPE).HasMaxLength(300);

                entity.Property(e => e.FIELDDATATYPE)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FIELDNAME).HasMaxLength(1000);

                entity.Property(e => e.FILTERCOMBO).HasMaxLength(300);

                entity.Property(e => e.FILTERCOMBOTYPE).HasMaxLength(1000);

                entity.Property(e => e.FILTERMASKEDIT).HasMaxLength(1000);

                entity.Property(e => e.GROUPTITLE).HasMaxLength(500);

                entity.Property(e => e.IDOLD)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.OLDREPORTTABLEID).HasMaxLength(16);

                entity.Property(e => e.ORDERBYFIELD).HasMaxLength(1000);

                entity.Property(e => e.PIVOTGRIDLOCATION).HasMaxLength(200);

                entity.Property(e => e.PIVOTSUMMARTTYPE).HasMaxLength(200);

                entity.Property(e => e.PREFIX).HasMaxLength(1000);

                entity.Property(e => e.SEARCHENABLED).HasDefaultValueSql("((1))");

                entity.Property(e => e.SEARCHMETHOD).HasMaxLength(1000);

                entity.Property(e => e.TITLE).HasMaxLength(1000);

                entity.Property(e => e.XGROUPTITLE).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_REPORTTABLE>(entity =>
            {
                entity.ToTable("ERP_REPORTTABLE", "AMVALWEB");

                entity.Property(e => e.ALIAS).HasMaxLength(200);

                entity.Property(e => e.OLDID).HasMaxLength(16);

                entity.Property(e => e.OLDREPORTID).HasMaxLength(16);

                entity.Property(e => e.TABLENAME)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<ERP_REPORTX>(entity =>
            {
                entity.ToTable("ERP_REPORTX", "AMVALWEB");

                entity.Property(e => e.OLDID).HasMaxLength(16);

                entity.Property(e => e.TABLENAME).HasMaxLength(1000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<ERP_ROLE>(entity =>
            {
                entity.ToTable("ERP_ROLE", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_ROLEACCESS>(entity =>
            {
                entity.ToTable("ERP_ROLEACCESS", "AMVALWEB");

                entity.Property(e => e.FORMCAPTION).HasMaxLength(2000);

                entity.Property(e => e.FORMKEY).HasMaxLength(2000);

                entity.Property(e => e.OBJECTCAPTION).HasMaxLength(2000);

                entity.Property(e => e.OBJECTKEY).HasMaxLength(2000);

                entity.Property(e => e.PUBLICKEY).HasMaxLength(2000);

                entity.HasOne(d => d.ROLE)
                    .WithMany(p => p.ERP_ROLEACCESSes)
                    .HasForeignKey(d => d.ROLEID)
                    .HasConstraintName("FK_RO_01");
            });

            modelBuilder.Entity<ERP_ROLEDENIED>(entity =>
            {
                entity.ToTable("ERP_ROLEDENIED", "AMVALWEB");

                entity.Property(e => e.FORMCAPTION).HasMaxLength(2000);

                entity.Property(e => e.FORMKEY).HasMaxLength(2000);

                entity.Property(e => e.OBJECTCAPTION).HasMaxLength(2000);

                entity.Property(e => e.OBJECTKEY).HasMaxLength(2000);

                entity.Property(e => e.PUBLICKEY).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_SELECTEDCODE>(entity =>
            {
                entity.ToTable("ERP_SELECTEDCODE", "AMVALWEB");
            });

            modelBuilder.Entity<ERP_TASK_REF>(entity =>
            {
                entity.ToTable("ERP_TASK_REF", "AMVALWEB");

                entity.Property(e => e.CATEGORY).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.TITLE).HasMaxLength(2000);

                entity.HasOne(d => d.CODE)
                    .WithMany(p => p.ERP_TASK_REFs)
                    .HasForeignKey(d => d.CODEID)
                    .HasConstraintName("FK_TASKR_01");
            });

            modelBuilder.Entity<ERP_TEMPPAPER>(entity =>
            {
                entity.ToTable("ERP_TEMPPAPER", "AMVALWEB");

                entity.Property(e => e.AWB).HasMaxLength(2000);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.EMITTER).HasMaxLength(2000);

                entity.Property(e => e.INVOICE_NO).HasMaxLength(2000);

                entity.Property(e => e.NO)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_TEMPPAPERITEM>(entity =>
            {
                entity.ToTable("ERP_TEMPPAPERITEM", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.MODEL).HasMaxLength(2000);

                entity.Property(e => e.PN).HasMaxLength(2000);

                entity.Property(e => e.SNBN).HasMaxLength(2000);

                entity.Property(e => e.TITLE).HasMaxLength(2000);

                entity.HasOne(d => d.TEMPPAPER)
                    .WithMany(p => p.ERP_TEMPPAPERITEMs)
                    .HasForeignKey(d => d.TEMPPAPERID)
                    .HasConstraintName("FK_TPI_01");
            });

            modelBuilder.Entity<ERP_USER>(entity =>
            {
                entity.ToTable("ERP_USERS", "AMVALWEB");

                entity.HasIndex(e => e.DELETED, "IDX_USER_DEL");

                entity.HasIndex(e => e.LOCATIONID, "IDX_USER_LOC");

                entity.HasIndex(e => e.PERSONNELID, "IDX_USER_PID");

                entity.HasIndex(e => e.ROOTLOCATION, "IDX_USER_ROOT");

                entity.HasIndex(e => e.USERNAME, "IDX_USER_UID");

                entity.Property(e => e.ACTIVE).HasDefaultValueSql("((1))");

                entity.Property(e => e.ADDRESS).HasMaxLength(2000);

                entity.Property(e => e.BUILDINGNO).HasMaxLength(2000);

                entity.Property(e => e.EMAIL).HasMaxLength(2000);

                entity.Property(e => e.FIRSTNAME).HasMaxLength(2000);

                entity.Property(e => e.GROUPID).HasMaxLength(16);

                entity.Property(e => e.LASTLOGING).HasPrecision(0);

                entity.Property(e => e.LASTNAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.NID).HasMaxLength(2000);

                entity.Property(e => e.PASSWORD).HasMaxLength(2000);

                entity.Property(e => e.PERSONNELID)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.PHONE1).HasMaxLength(2000);

                entity.Property(e => e.PHONE2).HasMaxLength(2000);

                entity.Property(e => e.PICTUREURL).HasMaxLength(2000);

                entity.Property(e => e.ROOM).HasMaxLength(2000);

                entity.Property(e => e.SIGNATUREURL).HasMaxLength(2000);

                entity.Property(e => e.USERNAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.LOCATION)
                    .WithMany(p => p.ERP_USERLOCATIONs)
                    .HasForeignKey(d => d.LOCATIONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_USERS_ERP_LOCATION_ID2");

                entity.HasOne(d => d.ROOTLOCATIONNavigation)
                    .WithMany(p => p.ERP_USERROOTLOCATIONNavigations)
                    .HasForeignKey(d => d.ROOTLOCATION)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERP_USERS_ERP_LOCATION_ID1");
            });

            modelBuilder.Entity<ERP_USERCODINGACCESS>(entity =>
            {
                entity.ToTable("ERP_USERCODINGACCESS", "AMVALWEB");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.ERP_USERCODINGACCESSes)
                    .HasForeignKey(d => d.USERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAUSER_01");
            });

            modelBuilder.Entity<ERP_USERLOCATIONACCESS>(entity =>
            {
                entity.ToTable("ERP_USERLOCATIONACCESS", "AMVALWEB");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.ERP_USERLOCATIONACCESSes)
                    .HasForeignKey(d => d.USERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ULA_01");
            });

            modelBuilder.Entity<ERP_USERROLE>(entity =>
            {
                entity.ToTable("ERP_USERROLE", "AMVALWEB");

                entity.HasOne(d => d.ROLE)
                    .WithMany(p => p.ERP_USERROLEs)
                    .HasForeignKey(d => d.ROLEID)
                    .HasConstraintName("FK_URA_01");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.ERP_USERROLEs)
                    .HasForeignKey(d => d.USERID)
                    .HasConstraintName("FK_URA_02");
            });

            modelBuilder.Entity<ERP_USER_ACTIVITY>(entity =>
            {
                entity.ToTable("ERP_USER_ACTIVITY", "AMVALWEB");

                entity.Property(e => e.ACTIVITY)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.DATE_CREATE_G).HasPrecision(0);

                entity.Property(e => e.ENTITYNO).HasMaxLength(2000);

                entity.Property(e => e.IP).HasMaxLength(2000);

                entity.Property(e => e.MAC).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.USERNAME).HasMaxLength(2000);

                entity.Property(e => e.USERPID).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_USER_ACTIVITY_TMP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ERP_USER_ACTIVITY_TMP", "AMVALWEB");

                entity.Property(e => e.ACTIVITY)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.DATE_CREATE_G).HasPrecision(6);

                entity.Property(e => e.ENTITYNO).HasMaxLength(2000);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.IP).HasMaxLength(2000);

                entity.Property(e => e.MAC).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.USERNAME).HasMaxLength(2000);

                entity.Property(e => e.USERPID).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_USER_ACTIVITY_copy1>(entity =>
            {
                entity.ToTable("ERP_USER_ACTIVITY_copy1", "AMVALWEB");

                entity.Property(e => e.ACTIVITY)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.DATE_CREATE_G).HasPrecision(6);

                entity.Property(e => e.ENTITYNO).HasMaxLength(2000);

                entity.Property(e => e.IP).HasMaxLength(2000);

                entity.Property(e => e.MAC).HasMaxLength(2000);

                entity.Property(e => e.REMARK).HasMaxLength(2000);

                entity.Property(e => e.USERNAME).HasMaxLength(2000);

                entity.Property(e => e.USERPID).HasMaxLength(2000);
            });

            modelBuilder.Entity<ERP_USER_CODING>(entity =>
            {
                entity.ToTable("ERP_USER_CODING", "AMVALWEB");
            });

            modelBuilder.Entity<ERP_USER_LOCATION>(entity =>
            {
                entity.ToTable("ERP_USER_LOCATION", "AMVALWEB");

                entity.HasIndex(e => e.LOCATIONID, "IDX_UL_LOCATIONID");

                entity.HasIndex(e => e.USERID, "IDX_UL_USERID");

                entity.Property(e => e.ACTIVE).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.ERP_USER_LOCATIONs)
                    .HasForeignKey(d => d.USERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UL_01");
            });

            modelBuilder.Entity<HELPER_ASSET>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HELPER_ASSET", "AMVALWEB");

                entity.Property(e => e.AMPERUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.AREAUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSETTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.BRAND_STR).HasMaxLength(2000);

                entity.Property(e => e.CAPACITYUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.CODE).HasMaxLength(2000);

                entity.Property(e => e.CODE_TITLE).HasMaxLength(2000);

                entity.Property(e => e.COLOR_STR).HasMaxLength(2000);

                entity.Property(e => e.CONDITION_STR).HasMaxLength(2000);

                entity.Property(e => e.COUNTRY_STR).HasMaxLength(2000);

                entity.Property(e => e.COURSEUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.CURRENCY_STR).HasMaxLength(2000);

                entity.Property(e => e.DIAMETERUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.EARNINGTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.EXTRACTFROM_LABEL)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EXTRACTFROM_SNBN)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FORCEUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.LABELTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.LENGTHXUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.LOC5_CODE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LOC5_TITLE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LOC7_CODE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LOC7_TITLE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MATERIAL_STR).HasMaxLength(2000);

                entity.Property(e => e.PARENT_LABEL)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PARENT_NAME)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PARENT_SNBN)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.POWERUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.PRESSUREUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.QUANTITYUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.RECLOCATION_CODE).HasMaxLength(2000);

                entity.Property(e => e.RECLOCATION_PARENTCODE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RECLOCATION_TITLE).HasMaxLength(2000);

                entity.Property(e => e.REC_NAME)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.REC_PID).HasMaxLength(2000);

                entity.Property(e => e.RESISTANCEUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.ROOT_CODE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ROOT_TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.USAGE_STR).HasMaxLength(2000);

                entity.Property(e => e.VALUETYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.VOLTAGEUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.WEIGHTUNIT_STR).HasMaxLength(2000);
            });

            modelBuilder.Entity<LASTUPD>(entity =>
            {
                entity.ToTable("LASTUPD", "AMVALWEB");
            });

            modelBuilder.Entity<LOCKED_IP>(entity =>
            {
                entity.ToTable("LOCKED_IP", "AMVALWEB");

                entity.Property(e => e.DATE_CREATE).HasPrecision(6);

                entity.Property(e => e.IP)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.MAC)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<LOG>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG", "AMVALWEB");

                entity.Property(e => e.INFO).HasMaxLength(2000);

                entity.Property(e => e.NAME).HasMaxLength(2000);

                entity.Property(e => e.RTYPE).HasMaxLength(2000);

                entity.Property(e => e.TNAME).HasMaxLength(2000);
            });

            modelBuilder.Entity<LTEST>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LTEST", "AMVALWEB");

                entity.Property(e => e.STR).HasMaxLength(2000);
            });

            modelBuilder.Entity<MESSAGEX>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MESSAGEX", "AMVALWEB");

                entity.Property(e => e.BODY).IsRequired();

                entity.Property(e => e.FORWARDEDBY).HasMaxLength(16);

                entity.Property(e => e.FORWARDFROM).HasMaxLength(16);

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.REPLYTO).HasMaxLength(16);

                entity.Property(e => e.SUBJECT)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ORCL_COLUMN>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORCL_COLUMN", "AMVALWEB");

                entity.Property(e => e.Column_Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Data_Type)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EXPR).HasMaxLength(129);

                entity.Property(e => e.EXPR_VAR).HasMaxLength(130);

                entity.Property(e => e.EXPR_VAR_TYPE).HasMaxLength(461);

                entity.Property(e => e.Table_Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ORCL_TABLE>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ORCL_TABLE", "AMVALWEB");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<REPORTITEM>(entity =>
            {
                entity.HasKey(e => e.PK)
                    .HasName("SYS_C0010861");

                entity.ToTable("REPORTITEM", "AMVALWEB");

                entity.Property(e => e.PK).ValueGeneratedNever();

                entity.Property(e => e.AGGREGATEFUNCTION).HasMaxLength(200);

                entity.Property(e => e.COMBOSTR).HasDefaultValueSql("((0))");

                entity.Property(e => e.CONVERTMETHOD).HasMaxLength(1000);

                entity.Property(e => e.DATATYPE).HasMaxLength(300);

                entity.Property(e => e.FIELDDATATYPE)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FIELDNAME).HasMaxLength(1000);

                entity.Property(e => e.FILTERCOMBO).HasMaxLength(300);

                entity.Property(e => e.FILTERCOMBOTYPE).HasMaxLength(1000);

                entity.Property(e => e.FILTERMASKEDIT).HasMaxLength(1000);

                entity.Property(e => e.GROUPTITLE).HasMaxLength(500);

                entity.Property(e => e.ID).HasMaxLength(16);

                entity.Property(e => e.OLD_REPORTTABLEID).HasMaxLength(16);

                entity.Property(e => e.ORDERBYFIELD).HasMaxLength(1000);

                entity.Property(e => e.PIVOTGRIDLOCATION).HasMaxLength(200);

                entity.Property(e => e.PIVOTSUMMARTTYPE).HasMaxLength(200);

                entity.Property(e => e.PREFIX).HasMaxLength(1000);

                entity.Property(e => e.SEARCHENABLED).HasDefaultValueSql("((1))");

                entity.Property(e => e.SEARCHMETHOD).HasMaxLength(1000);

                entity.Property(e => e.TITLE).HasMaxLength(1000);
            });

            modelBuilder.Entity<REPORTITEMTABLE>(entity =>
            {
                entity.HasKey(e => e.PK)
                    .HasName("SYS_C0010862");

                entity.ToTable("REPORTITEMTABLE", "AMVALWEB");
            });

            modelBuilder.Entity<REPORTITEMTABLE_TEMP>(entity =>
            {
                entity.HasKey(e => e.PK)
                    .HasName("SYS_C0011003");

                entity.ToTable("REPORTITEMTABLE_TEMP", "AMVALWEB");
            });

            modelBuilder.Entity<REPORTITEM_TEMP2>(entity =>
            {
                entity.HasKey(e => e.PK)
                    .HasName("SYS_C0011011");

                entity.ToTable("REPORTITEM_TEMP2", "AMVALWEB");

                entity.Property(e => e.PK).ValueGeneratedNever();

                entity.Property(e => e.AGGREGATEFUNCTION).HasMaxLength(200);

                entity.Property(e => e.COMBOSTR).HasDefaultValueSql("((0))");

                entity.Property(e => e.CONVERTMETHOD).HasMaxLength(1000);

                entity.Property(e => e.DATATYPE).HasMaxLength(300);

                entity.Property(e => e.FIELDDATATYPE)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FIELDNAME).HasMaxLength(1000);

                entity.Property(e => e.FILTERCOMBO).HasMaxLength(300);

                entity.Property(e => e.FILTERCOMBOTYPE).HasMaxLength(1000);

                entity.Property(e => e.FILTERMASKEDIT).HasMaxLength(1000);

                entity.Property(e => e.GROUPTITLE).HasMaxLength(500);

                entity.Property(e => e.ID).HasMaxLength(16);

                entity.Property(e => e.OLD_REPORTTABLEID).HasMaxLength(16);

                entity.Property(e => e.ORDERBYFIELD).HasMaxLength(1000);

                entity.Property(e => e.PIVOTGRIDLOCATION).HasMaxLength(200);

                entity.Property(e => e.PIVOTSUMMARTTYPE).HasMaxLength(200);

                entity.Property(e => e.PREFIX).HasMaxLength(1000);

                entity.Property(e => e.SEARCHENABLED).HasDefaultValueSql("((1))");

                entity.Property(e => e.SEARCHMETHOD).HasMaxLength(1000);

                entity.Property(e => e.TITLE).HasMaxLength(1000);
            });

            modelBuilder.Entity<REPORTITEM_temp>(entity =>
            {
                entity.ToTable("REPORTITEM_temp", "AMVALWEB");

                entity.Property(e => e.ID).HasMaxLength(16);

                entity.Property(e => e.AGGREGATEFUNCTION).HasMaxLength(200);

                entity.Property(e => e.CONVERTMETHOD).HasMaxLength(1000);

                entity.Property(e => e.DATATYPE).HasMaxLength(300);

                entity.Property(e => e.FIELDDATATYPE)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.FIELDNAME).HasMaxLength(1000);

                entity.Property(e => e.FILTERCOMBO).HasMaxLength(300);

                entity.Property(e => e.FILTERCOMBOTYPE).HasMaxLength(1000);

                entity.Property(e => e.FILTERMASKEDIT).HasMaxLength(1000);

                entity.Property(e => e.GROUPTITLE).HasMaxLength(500);

                entity.Property(e => e.ORDERBYFIELD).HasMaxLength(1000);

                entity.Property(e => e.PIVOTGRIDLOCATION).HasMaxLength(200);

                entity.Property(e => e.PIVOTSUMMARTTYPE).HasMaxLength(200);

                entity.Property(e => e.PREFIX).HasMaxLength(1000);

                entity.Property(e => e.REPORTTABLEID).HasMaxLength(16);

                entity.Property(e => e.SEARCHENABLED).HasDefaultValueSql("((1))");

                entity.Property(e => e.SEARCHMETHOD).HasMaxLength(1000);

                entity.Property(e => e.TITLE).HasMaxLength(1000);
            });

            modelBuilder.Entity<REPORTRELATION>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORTRELATIONS", "AMVALWEB");

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.REPORTITEM1_FUNCTION).HasMaxLength(1000);

                entity.Property(e => e.REPORTITEM2_FUNCTION).HasMaxLength(1000);

                entity.Property(e => e.REPORTITEMID1)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.REPORTITEMID2)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<REPORTSETTING>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORTSETTING", "AMVALWEB");

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ISGENERAL).HasDefaultValueSql("((1))");

                entity.Property(e => e.REPORTID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<REPORTSETTINGCOLUMN>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORTSETTINGCOLUMNS", "AMVALWEB");

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.REPORTFIELDITEM)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.REPORTSETTINGID)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<REPORTSETTINGFILTERITEM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORTSETTINGFILTERITEM", "AMVALWEB");

                entity.Property(e => e.CMBCOMBOSELECTED_TEXT).HasMaxLength(1000);

                entity.Property(e => e.CMBFIELDSELECTED_TEXT).HasMaxLength(1000);

                entity.Property(e => e.CMBFIELDVALUE).HasMaxLength(16);

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.REPORTSETTINGID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.TXTVALUE1).HasMaxLength(1000);

                entity.Property(e => e.TXTVALUE2).HasMaxLength(1000);
            });

            modelBuilder.Entity<REPORTTABLE>(entity =>
            {
                entity.HasKey(e => e.PK)
                    .HasName("SYS_C0010860");

                entity.ToTable("REPORTTABLES", "AMVALWEB");

                entity.Property(e => e.PK).ValueGeneratedNever();

                entity.Property(e => e.ALIAS).HasMaxLength(200);

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.OLD_REPORTID).HasMaxLength(16);

                entity.Property(e => e.TABLENAME)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TITLE).HasMaxLength(2000);
            });

            modelBuilder.Entity<REPORTUSER>(entity =>
            {
                entity.ToTable("REPORTUSER", "AMVALWEB");

                entity.Property(e => e.CATEGORY).HasMaxLength(2000);

                entity.Property(e => e.CATEGORY2).HasMaxLength(2000);

                entity.Property(e => e.COL_FONTNAME).HasMaxLength(2000);

                entity.Property(e => e.HEADER_FONTNAME).HasMaxLength(2000);

                entity.Property(e => e.SIGNS).HasMaxLength(2000);

                entity.Property(e => e.SUBTITLE).HasMaxLength(2000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<REPORTUSERSELECTEDCOLUMN>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORTUSERSELECTEDCOLUMNS", "AMVALWEB");

                entity.Property(e => e.BRANCHKEY).HasMaxLength(2000);

                entity.Property(e => e.COLUMNFONTNAME)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('B Nazanin')");

                entity.Property(e => e.COLUMNFONTSIZE).HasDefaultValueSql("((12))");

                entity.Property(e => e.COLUMNHEADERFONTBOLD).HasDefaultValueSql("((1))");

                entity.Property(e => e.COLUMNHEADERFONTNAME)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('B Nazanin')");

                entity.Property(e => e.COLUMNHEADERFONTSIZE).HasDefaultValueSql("((12))");

                entity.Property(e => e.COLUMNPERCENTWIDTH).HasDefaultValueSql("((0))");

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.PIVOTGRIDLOCATION).HasMaxLength(500);

                entity.Property(e => e.PIVOTSUMMARTTYPE).HasMaxLength(500);

                entity.Property(e => e.REPORTITEMID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.REPORTSETTINGID).HasMaxLength(16);

                entity.Property(e => e.REPORTXID)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.SUMMARYTYPE).HasMaxLength(500);

                entity.Property(e => e.TAJMISUMMARYTYPE).HasMaxLength(500);

                entity.Property(e => e.TEMPLATENAME).HasMaxLength(2000);
            });

            modelBuilder.Entity<REPORTUSER_ACCESS>(entity =>
            {
                entity.ToTable("REPORTUSER_ACCESS", "AMVALWEB");

                entity.HasOne(d => d.REPORT)
                    .WithMany(p => p.REPORTUSER_ACCESSes)
                    .HasForeignKey(d => d.REPORTID)
                    .HasConstraintName("FK_REPACC_01");
            });

            modelBuilder.Entity<REPORTUSER_ALLOWED>(entity =>
            {
                entity.ToTable("REPORTUSER_ALLOWED", "AMVALWEB");
            });

            modelBuilder.Entity<REPORTUSER_CODE>(entity =>
            {
                entity.ToTable("REPORTUSER_CODE", "AMVALWEB");

                entity.HasOne(d => d.TABLE)
                    .WithMany(p => p.REPORTUSER_CODEs)
                    .HasForeignKey(d => d.TABLEID)
                    .HasConstraintName("FK_FCODE_01");
            });

            modelBuilder.Entity<REPORTUSER_FILTER>(entity =>
            {
                entity.ToTable("REPORTUSER_FILTER", "AMVALWEB");

                entity.Property(e => e.FILTER_NAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.FILTER_VALUE).HasMaxLength(2000);

                entity.Property(e => e.VALUE_TYPE).HasMaxLength(2000);

                entity.HasOne(d => d.TABLE)
                    .WithMany(p => p.REPORTUSER_FILTERs)
                    .HasForeignKey(d => d.TABLEID)
                    .HasConstraintName("FK_FILTER_01");
            });

            modelBuilder.Entity<REPORTUSER_ITEM>(entity =>
            {
                entity.ToTable("REPORTUSER_ITEM", "AMVALWEB");

                entity.HasOne(d => d.REPORTABLE)
                    .WithMany(p => p.REPORTUSER_ITEMs)
                    .HasForeignKey(d => d.REPORTABLEID)
                    .HasConstraintName("FK_RPTITEM_01");
            });

            modelBuilder.Entity<REPORTUSER_TABLE>(entity =>
            {
                entity.ToTable("REPORTUSER_TABLE", "AMVALWEB");

                entity.HasOne(d => d.REPORT)
                    .WithMany(p => p.REPORTUSER_TABLEs)
                    .HasForeignKey(d => d.REPORTID)
                    .HasConstraintName("FK_RPTTBL_01");
            });

            modelBuilder.Entity<REPORTX>(entity =>
            {
                entity.ToTable("REPORTX", "AMVALWEB");

                entity.Property(e => e.ID).HasMaxLength(16);

                entity.Property(e => e.TABLENAME).HasMaxLength(1000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<STATE>(entity =>
            {
                entity.HasKey(e => e.PK)
                    .HasName("SYS_C0010988");

                entity.ToTable("STATE", "AMVALWEB");

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<USER_ASSET_TYPE>(entity =>
            {
                entity.ToTable("USER_ASSET_TYPE", "AMVALWEB");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.USER_ASSET_TYPEs)
                    .HasForeignKey(d => d.USERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UATYPE_0");
            });

            modelBuilder.Entity<USER_GRIDSETTING>(entity =>
            {
                entity.ToTable("USER_GRIDSETTING", "AMVALWEB");

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.COLUMNS).IsUnicode(false);

                entity.Property(e => e.FORM).HasMaxLength(2000);

                entity.Property(e => e.GRIDTYPE).HasMaxLength(2000);
            });

            modelBuilder.Entity<USER_PROPERTy>(entity =>
            {
                entity.HasKey(e => new { e.USERID, e.KEY })
                    .HasName("SYS_C0011034");

                entity.ToTable("USER_PROPERTIES", "AMVALWEB");

                entity.Property(e => e.USERID).ValueGeneratedOnAdd();

                entity.Property(e => e.VALUE).HasMaxLength(2000);
            });

            modelBuilder.Entity<VIEW_ASSET>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ASSET", "AMVALWEB");

                entity.Property(e => e.AMPERUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.AREAUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_ASSETTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_BRAND_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_CODE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_COLOR_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_CONDITION_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_COUNTRY_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_CREATEDATE).HasColumnType("numeric(38, 10)");

                entity.Property(e => e.ASSET_CURRENCY_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.ASSET_EARNINGTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_ENTEZAMI).HasMaxLength(2000);

                entity.Property(e => e.ASSET_EXITTO).HasMaxLength(2000);

                entity.Property(e => e.ASSET_EXPDATEG).HasPrecision(0);

                entity.Property(e => e.ASSET_EXTRACTFROM_LABEL)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ASSET_EXTRACTFROM_SNBN)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ASSET_LABEL).IsUnicode(false);

                entity.Property(e => e.ASSET_LABEL2)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ASSET_LABELTYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_LATINNAME).HasMaxLength(2000);

                entity.Property(e => e.ASSET_LETTERNO).HasMaxLength(2000);

                entity.Property(e => e.ASSET_LETTERSUBJECT).HasMaxLength(2000);

                entity.Property(e => e.ASSET_MATERIAL_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_MODEL).HasMaxLength(2000);

                entity.Property(e => e.ASSET_MOTOR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_NAME)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ASSET_OLDLABEL).HasMaxLength(2000);

                entity.Property(e => e.ASSET_OLDOWNER).HasMaxLength(2000);

                entity.Property(e => e.ASSET_PARENT_LABEL).HasMaxLength(2000);

                entity.Property(e => e.ASSET_PARENT_NAME).HasMaxLength(2000);

                entity.Property(e => e.ASSET_PARENT_SNBN).HasMaxLength(2000);

                entity.Property(e => e.ASSET_PHONE_NO).HasMaxLength(2000);

                entity.Property(e => e.ASSET_PN).HasMaxLength(2000);

                entity.Property(e => e.ASSET_POSTALCODE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_PRODATEG).HasPrecision(0);

                entity.Property(e => e.ASSET_QUANTITYUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_RECLOCATION_CODE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_RECLOCATION_PARENTCODE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ASSET_RECLOCATION_TITLE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_REC_NAME)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ASSET_REC_PID).HasMaxLength(2000);

                entity.Property(e => e.ASSET_ROOT_CODE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ASSET_ROOT_TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ASSET_SABTI_ASLI).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SABTI_FAREI).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SELLERADDRESS).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SELLERNAME).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SELLERPHONE).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SHASI).HasMaxLength(2000);

                entity.Property(e => e.ASSET_SNBN).HasMaxLength(4000);

                entity.Property(e => e.ASSET_TRACKINGNO).HasMaxLength(2000);

                entity.Property(e => e.ASSET_USAGE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_VALUETYPE_STR).HasMaxLength(2000);

                entity.Property(e => e.ASSET_VARAGHE_MALEKIAT).HasMaxLength(2000);

                entity.Property(e => e.ASSET_WARANTY).HasMaxLength(2000);

                entity.Property(e => e.BUYFORCODE).HasMaxLength(2000);

                entity.Property(e => e.BUYFORTITLE).HasMaxLength(2000);

                entity.Property(e => e.CAPACITYUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.COURSEUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.DIAMETERUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.FORCEUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.LENGTHXUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.LOC5_CODE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LOC5_TITLE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LOC7_CODE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LOC7_TITLE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MAHRAMANENO).HasMaxLength(2000);

                entity.Property(e => e.MALEK).HasMaxLength(2000);

                entity.Property(e => e.POWERUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.PRESSUREUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.RESISTANCEUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.USERSTR).HasMaxLength(2000);

                entity.Property(e => e.VOLTAGEUNIT_STR).HasMaxLength(2000);

                entity.Property(e => e.WEIGHTUNIT_STR).HasMaxLength(2000);
            });

            modelBuilder.Entity<VIEW_ERP_CODING_DET>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ERP_CODING_DET", "AMVALWEB");

                entity.Property(e => e.ASSETTYPE_TITLE)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ASSET_TYPE_TITLE).HasMaxLength(2000);

                entity.Property(e => e.COLOR_TITLE).HasMaxLength(2000);

                entity.Property(e => e.DEPTYPE_STR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FACTORY_TITLE).HasMaxLength(2000);

                entity.Property(e => e.FULLCODE)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.MATERIAL_TITLE).HasMaxLength(2000);

                entity.Property(e => e.MODEL_TITLE).HasMaxLength(2000);

                entity.Property(e => e.NFULLCODE).HasColumnType("numeric(38, 10)");

                entity.Property(e => e.PARENT_FULLCODE).HasMaxLength(2000);

                entity.Property(e => e.PN_TITLE).HasMaxLength(2000);

                entity.Property(e => e.SN_TITLE).HasMaxLength(2000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<VIEW_OPTION>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_OPTION", "AMVALWEB");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(2000);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.PARENTTITLE).HasMaxLength(2000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<VIEW_USERCODINGACCESS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_USERCODINGACCESS", "AMVALWEB");

                entity.Property(e => e.FULLCODE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<VIEW_USERLOCATIONACCESS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_USERLOCATIONACCESS", "AMVALWEB");

                entity.Property(e => e.FULLCODE)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<WASSET>(entity =>
            {
                entity.HasKey(e => e.ASSETID)
                    .HasName("SYS_C0011017");

                entity.ToTable("WASSET", "AMVALWEB");

                entity.Property(e => e.ASSETID).ValueGeneratedNever();
            });

            modelBuilder.Entity<X_REPORT>(entity =>
            {
                entity.ToTable("X_REPORT", "AMVALWEB");

                entity.Property(e => e.ID).HasMaxLength(16);

                entity.Property(e => e.CATEGORY).HasMaxLength(2000);

                entity.Property(e => e.TABLENAME).HasMaxLength(1000);

                entity.Property(e => e.TITLE)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<_ORCL_ERROR>(entity =>
            {
                entity.ToTable("_ORCL_ERROR", "AMVALWEB");

                entity.Property(e => e.ErrorNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.RowKey)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_ORCL_INSERT>(entity =>
            {
                entity.ToTable("_ORCL_INSERT", "AMVALWEB");

                entity.Property(e => e.RowKey)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_ORCL_Result>(entity =>
            {
                entity.ToTable("_ORCL_Result", "AMVALWEB");

                entity.Property(e => e.TableName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_test>(entity =>
            {
                entity.ToTable("_test", "AMVALWEB");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
