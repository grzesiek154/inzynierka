namespace RCPSystem
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using RCPSystem.DbClass;
    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("name=EFModel")
        {
        }

        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<genLogin> genLogins { get; set; }
        public virtual DbSet<genOrgUnit> genOrgUnits { get; set; }
        public virtual DbSet<genRole> genRoles { get; set; }
        public virtual DbSet<genUser> genUsers { get; set; }
        public virtual DbSet<rcpDay> rcpDays { get; set; }
        public virtual DbSet<rcpHarmo> rcpHarmoes { get; set; }
        public virtual DbSet<rcpTranType> rcpTranTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<zadElement> zadElements { get; set; }
        public virtual DbSet<zadOrder> zadOrders { get; set; }
        public virtual DbSet<zadProduct> zadProducts { get; set; }
        public virtual DbSet<zadTaskList> zadTaskLists { get; set; }
        public virtual DbSet<zadType> zadTypes { get; set; }
        public virtual DbSet<genOrgUnitPriv> genOrgUnitPrivs { get; set; }
        public virtual DbSet<genOrgUser> genOrgUsers { get; set; }
        public virtual DbSet<genUserDet> genUserDets { get; set; }
        public virtual DbSet<rcpHarmoDef> rcpHarmoDefs { get; set; }
        public virtual DbSet<rcpPairsBRK> rcpPairsBRKs { get; set; }
        public virtual DbSet<rcpPairsIO> rcpPairsIOs { get; set; }
        public virtual DbSet<rcpPairsOnB> rcpPairsOnBs { get; set; }
        public virtual DbSet<zadOrderProduct> zadOrderProducts { get; set; }
        public virtual DbSet<zadTaskProduction> zadTaskProductions { get; set; }
        public virtual DbSet<zadDuty> zadDutys { get; set; }
        public virtual DbSet<zadDutyType> zadDutyTypes { get; set; }
        public virtual DbSet<zadUserDuty> zadUserDutys { get; set; }
        public virtual DbSet<zadProdElem> zadProdElems { get; set; }
        public virtual DbSet<rcpTransactionAll> rcpTransactionAlls { get; set; }
        public virtual DbSet<rcpUserHarmoList> rcpUserHarmoes { get; set; }
        public virtual DbSet<zadClient> zadClients { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calendar>()
                .Property(e => e.DaySuffix)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.WeekDayName)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.HolidayText)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.MonthName)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.QuarterName)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.MMYYYY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.MonthYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<genOrgUnit>()
                .HasMany(e => e.genOrgUnitPrivs)
                .WithRequired(e => e.genOrgUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genOrgUnit>()
                .HasMany(e => e.genOrgUsers)
                .WithRequired(e => e.genOrgUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genRole>()
                .HasMany(e => e.genUsers)
                .WithRequired(e => e.genRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genUser>()
                .HasMany(e => e.genLogins)
                .WithRequired(e => e.genUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genUser>()
                .HasMany(e => e.genOrgUnitPrivs)
                .WithRequired(e => e.genUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genUser>()
                .HasMany(e => e.genOrgUsers)
                .WithRequired(e => e.genUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genUser>()
                .HasOptional(e => e.genUserDet)
                .WithRequired(e => e.genUser);

            modelBuilder.Entity<genUser>()
                .HasMany(e => e.rcpTransactions)
                .WithRequired(e => e.genUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genUser>()
                .HasMany(e => e.rcpUserHarmoes)
                .WithRequired(e => e.genUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genUser>()
                .HasMany(e => e.zadOrders)
                .WithRequired(e => e.genUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genUser>()
                .HasMany(e => e.zadTaskProductions)
                .WithRequired(e => e.genUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rcpDay>()
                .HasMany(e => e.rcpHarmoDefs)
                .WithRequired(e => e.rcpDay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rcpHarmo>()
                .HasMany(e => e.rcpHarmoDefs)
                .WithRequired(e => e.rcpHarmo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rcpHarmo>()
                .HasMany(e => e.rcpUserHarmoes)
                .WithRequired(e => e.rcpHarmo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rcpTranType>()
                .HasMany(e => e.rcpTransactions)
                .WithRequired(e => e.rcpTranType)
                .HasForeignKey(e => e.IdTransType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zadElement>()
                .HasMany(e => e.zadTaskLists)
                .WithRequired(e => e.zadElement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zadOrder>()
                .HasMany(e => e.zadOrderProducts)
                .WithRequired(e => e.zadOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zadOrder>()
                .HasMany(e => e.zadTaskLists)
                .WithRequired(e => e.zadOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zadProduct>()
                .HasMany(e => e.zadOrderProducts)
                .WithRequired(e => e.zadProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zadType>()
                .HasMany(e => e.zadElements)
                .WithRequired(e => e.zadType)
                .WillCascadeOnDelete(false);
        }
    }
}
