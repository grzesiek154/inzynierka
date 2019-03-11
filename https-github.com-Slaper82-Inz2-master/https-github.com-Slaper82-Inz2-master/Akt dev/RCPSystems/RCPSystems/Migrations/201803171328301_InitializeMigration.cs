namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calendar",
                c => new
                    {
                        DateKey = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Day = c.Byte(nullable: false),
                        DaySuffix = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Weekday = c.Byte(nullable: false),
                        WeekDayName = c.String(nullable: false, maxLength: 10, unicode: false),
                        IsWeekend = c.Boolean(nullable: false),
                        IsHoliday = c.Boolean(nullable: false),
                        HolidayText = c.String(maxLength: 64, unicode: false),
                        DOWInMonth = c.Byte(nullable: false),
                        DayOfYear = c.Short(nullable: false),
                        WeekOfMonth = c.Byte(nullable: false),
                        WeekOfYear = c.Byte(nullable: false),
                        ISOWeekOfYear = c.Byte(nullable: false),
                        Month = c.Byte(nullable: false),
                        MonthName = c.String(nullable: false, maxLength: 10, unicode: false),
                        Quarter = c.Byte(nullable: false),
                        QuarterName = c.String(nullable: false, maxLength: 6, unicode: false),
                        Year = c.Int(nullable: false),
                        MMYYYY = c.String(nullable: false, maxLength: 6, fixedLength: true, unicode: false),
                        MonthYear = c.String(nullable: false, maxLength: 7, fixedLength: true, unicode: false),
                        FirstDayOfMonth = c.DateTime(nullable: false, storeType: "date"),
                        LastDayOfMonth = c.DateTime(nullable: false, storeType: "date"),
                        FirstDayOfQuarter = c.DateTime(nullable: false, storeType: "date"),
                        LastDayOfQuarter = c.DateTime(nullable: false, storeType: "date"),
                        FirstDayOfYear = c.DateTime(nullable: false, storeType: "date"),
                        LastDayOfYear = c.DateTime(nullable: false, storeType: "date"),
                        FirstDayOfNextMonth = c.DateTime(nullable: false, storeType: "date"),
                        FirstDayOfNextYear = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.DateKey);
            
            CreateTable(
                "dbo.genLogin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        Login = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Try = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.genUsers", t => t.IdUser)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.genUsers",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        IdRole = c.Int(nullable: false),
                        Active = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.genRoles", t => t.IdRole)
                .Index(t => t.IdRole);
            
            CreateTable(
                "dbo.genOrgUnitPriv",
                c => new
                    {
                        IdUser = c.Int(nullable: false),
                        IdOrgUnit = c.Int(nullable: false),
                        Active = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.IdUser, t.IdOrgUnit })
                .ForeignKey("dbo.genOrgUnit", t => t.IdOrgUnit)
                .ForeignKey("dbo.genUsers", t => t.IdUser)
                .Index(t => t.IdUser)
                .Index(t => t.IdOrgUnit);
            
            CreateTable(
                "dbo.genOrgUnit",
                c => new
                    {
                        IdOrgUnit = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        IdHigherOrgUnit = c.Int(),
                    })
                .PrimaryKey(t => t.IdOrgUnit);
            
            CreateTable(
                "dbo.genOrgUsers",
                c => new
                    {
                        Lp = c.Int(nullable: false),
                        IdUser = c.Int(nullable: false),
                        IdOrgUnit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Lp)
                .ForeignKey("dbo.genOrgUnit", t => t.IdOrgUnit)
                .ForeignKey("dbo.genUsers", t => t.IdUser)
                .Index(t => t.IdUser)
                .Index(t => t.IdOrgUnit);
            
            CreateTable(
                "dbo.genRoles",
                c => new
                    {
                        IdRole = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 30),
                        Active = c.Short(),
                    })
                .PrimaryKey(t => t.IdRole);
            
            CreateTable(
                "dbo.genUserDet",
                c => new
                    {
                        IdUser = c.Int(nullable: false),
                        DateBirth = c.DateTime(),
                        PlaceBirth = c.String(maxLength: 255),
                        Adrress = c.String(maxLength: 255),
                        Adrress2 = c.String(maxLength: 255),
                        City = c.String(maxLength: 255),
                        ZipCode = c.String(maxLength: 10),
                        IsWoman = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.genUsers", t => t.IdUser)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.rcpPairsBRK",
                c => new
                    {
                        Lp = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        Start = c.DateTime(),
                        Stop = c.DateTime(),
                    })
                .PrimaryKey(t => t.Lp)
                .ForeignKey("dbo.genUsers", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.rcpPairsIO",
                c => new
                    {
                        Lp = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        Start = c.DateTime(),
                        Stop = c.DateTime(),
                    })
                .PrimaryKey(t => t.Lp)
                .ForeignKey("dbo.genUsers", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.rcpPairsOnB",
                c => new
                    {
                        Lp = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        Start = c.DateTime(),
                        Stop = c.DateTime(),
                    })
                .PrimaryKey(t => t.Lp)
                .ForeignKey("dbo.genUsers", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.rcpTransactionAll",
                c => new
                    {
                        IdTrans = c.Long(nullable: false, identity: true),
                        DateAndTime = c.DateTime(nullable: false),
                        IdUser = c.Int(nullable: false),
                        IdTransType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdTrans)
                .ForeignKey("dbo.rcpTranType", t => t.IdTransType)
                .ForeignKey("dbo.genUsers", t => t.IdUser)
                .Index(t => t.IdUser)
                .Index(t => t.IdTransType);
            
            CreateTable(
                "dbo.rcpTranType",
                c => new
                    {
                        IdTranType = c.Int(nullable: false),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.IdTranType);
            
            CreateTable(
                "dbo.rcpUserHarmo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdHarmo = c.Int(nullable: false),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.rcpHarmo", t => t.IdHarmo)
                .ForeignKey("dbo.genUsers", t => t.IdUser)
                .Index(t => t.IdUser)
                .Index(t => t.IdHarmo);
            
            CreateTable(
                "dbo.rcpHarmo",
                c => new
                    {
                        IdHarmo = c.Int(nullable: false, identity: true),
                        HarmoName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.IdHarmo);
            
            CreateTable(
                "dbo.rcpHarmoDef",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdHarmo = c.Int(nullable: false),
                        WDay = c.Int(nullable: false),
                        IdDay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.rcpDay", t => t.IdDay)
                .ForeignKey("dbo.rcpHarmo", t => t.IdHarmo)
                .Index(t => t.IdHarmo)
                .Index(t => t.IdDay);
            
            CreateTable(
                "dbo.rcpDay",
                c => new
                    {
                        IdDay = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        CStart = c.Time(precision: 7),
                        CStop = c.Time(precision: 7),
                        IEarly = c.Short(),
                        ILate = c.Short(),
                        OEarly = c.Short(),
                        OLate = c.Short(),
                        Break = c.Short(),
                        Active = c.Boolean(),
                    })
                .PrimaryKey(t => t.IdDay);
            
            CreateTable(
                "dbo.rcpUserHarmoList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdHarmo = c.Int(nullable: false),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.genUsers", t => t.IdUser, cascadeDelete: true)
                .ForeignKey("dbo.rcpHarmo", t => t.IdHarmo, cascadeDelete: true)
                .Index(t => t.IdUser)
                .Index(t => t.IdHarmo);
            
            CreateTable(
                "dbo.zadOrder",
                c => new
                    {
                        IdOrder = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        IdUser = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 250),
                        Done = c.Boolean(),
                        Active = c.Boolean(),
                        IdClient = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOrder)
                .ForeignKey("dbo.zadClient", t => t.IdClient, cascadeDelete: true)
                .ForeignKey("dbo.genUsers", t => t.IdUser)
                .Index(t => t.IdUser)
                .Index(t => t.IdClient);
            
            CreateTable(
                "dbo.zadClient",
                c => new
                    {
                        IdClient = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdClient);
            
            CreateTable(
                "dbo.zadOrderProduct",
                c => new
                    {
                        IdKey = c.Int(nullable: false, identity: true),
                        IdOrder = c.Int(nullable: false),
                        IdProduct = c.Int(nullable: false),
                        Active = c.Boolean(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdKey)
                .ForeignKey("dbo.zadProduct", t => t.IdProduct)
                .ForeignKey("dbo.zadOrder", t => t.IdOrder)
                .Index(t => t.IdOrder)
                .Index(t => t.IdProduct);
            
            CreateTable(
                "dbo.zadProduct",
                c => new
                    {
                        IdProduct = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Active = c.Boolean(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IdProduct);
            
            CreateTable(
                "dbo.zadProdElem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        IdElement = c.Int(nullable: false),
                        IdProduct = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.zadElement", t => t.IdElement, cascadeDelete: true)
                .ForeignKey("dbo.zadProduct", t => t.IdProduct, cascadeDelete: true)
                .Index(t => t.IdElement)
                .Index(t => t.IdProduct);
            
            CreateTable(
                "dbo.zadElement",
                c => new
                    {
                        IdElement = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        IdType = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Symbol = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.IdElement)
                .ForeignKey("dbo.zadTypes", t => t.IdType)
                .Index(t => t.IdType);
            
            CreateTable(
                "dbo.zadTaskList",
                c => new
                    {
                        IdTask = c.Int(nullable: false, identity: true),
                        IdOrder = c.Int(nullable: false),
                        IdElement = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Active = c.Boolean(),
                        Done = c.Boolean(),
                    })
                .PrimaryKey(t => t.IdTask)
                .ForeignKey("dbo.zadElement", t => t.IdElement)
                .ForeignKey("dbo.zadOrder", t => t.IdOrder)
                .Index(t => t.IdOrder)
                .Index(t => t.IdElement);
            
            CreateTable(
                "dbo.zadTaskProduction",
                c => new
                    {
                        IdUser = c.Int(nullable: false),
                        Start = c.DateTime(nullable: false),
                        IdTask = c.Int(),
                        Stop = c.DateTime(),
                        Active = c.Boolean(),
                        AddInfo = c.String(),
                        genUser_IdUser = c.Int(),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.zadTaskList", t => t.IdTask)
                .Index(t => t.IdTask);
            
            CreateTable(
                "dbo.zadTypes",
                c => new
                    {
                        IdType = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false, maxLength: 100),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdType);
            
            CreateTable(
                "dbo.zadDutyTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IdType = c.Int(nullable: false),
                        IdDuty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.zadDuties", t => t.IdDuty, cascadeDelete: true)
                .ForeignKey("dbo.zadTypes", t => t.IdType, cascadeDelete: true)
                .Index(t => t.IdType)
                .Index(t => t.IdDuty);
            
            CreateTable(
                "dbo.zadDuties",
                c => new
                    {
                        IdDuty = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IdDuty);
            
            CreateTable(
                "dbo.zadUserDuties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdDuty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.genUsers", t => t.IdUser, cascadeDelete: true)
                .ForeignKey("dbo.zadDuties", t => t.IdDuty, cascadeDelete: true)
                .Index(t => t.IdUser)
                .Index(t => t.IdDuty);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.zadOrder", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.zadTaskList", "IdOrder", "dbo.zadOrder");
            DropForeignKey("dbo.zadOrderProduct", "IdOrder", "dbo.zadOrder");
            DropForeignKey("dbo.zadProdElem", "IdProduct", "dbo.zadProduct");
            DropForeignKey("dbo.zadElement", "IdType", "dbo.zadTypes");
            DropForeignKey("dbo.zadDutyTypes", "IdType", "dbo.zadTypes");
            DropForeignKey("dbo.zadUserDuties", "IdDuty", "dbo.zadDuties");
            DropForeignKey("dbo.zadUserDuties", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.zadDutyTypes", "IdDuty", "dbo.zadDuties");
            DropForeignKey("dbo.zadTaskList", "IdElement", "dbo.zadElement");
            DropForeignKey("dbo.zadTaskProduction", "IdTask", "dbo.zadTaskList");
            DropForeignKey("dbo.zadProdElem", "IdElement", "dbo.zadElement");
            DropForeignKey("dbo.zadOrderProduct", "IdProduct", "dbo.zadProduct");
            DropForeignKey("dbo.zadOrder", "IdClient", "dbo.zadClient");
            DropForeignKey("dbo.rcpUserHarmo", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.rcpUserHarmoList", "IdHarmo", "dbo.rcpHarmo");
            DropForeignKey("dbo.rcpUserHarmoList", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.rcpUserHarmo", "IdHarmo", "dbo.rcpHarmo");
            DropForeignKey("dbo.rcpHarmoDef", "IdHarmo", "dbo.rcpHarmo");
            DropForeignKey("dbo.rcpHarmoDef", "IdDay", "dbo.rcpDay");
            DropForeignKey("dbo.rcpTransactionAll", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.rcpTransactionAll", "IdTransType", "dbo.rcpTranType");
            DropForeignKey("dbo.rcpPairsOnB", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.rcpPairsIO", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.rcpPairsBRK", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.genUserDet", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.genUsers", "IdRole", "dbo.genRoles");
            DropForeignKey("dbo.genOrgUsers", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.genOrgUnitPriv", "IdUser", "dbo.genUsers");
            DropForeignKey("dbo.genOrgUsers", "IdOrgUnit", "dbo.genOrgUnit");
            DropForeignKey("dbo.genOrgUnitPriv", "IdOrgUnit", "dbo.genOrgUnit");
            DropForeignKey("dbo.genLogin", "IdUser", "dbo.genUsers");
            DropIndex("dbo.zadUserDuties", new[] { "IdDuty" });
            DropIndex("dbo.zadUserDuties", new[] { "IdUser" });
            DropIndex("dbo.zadDutyTypes", new[] { "IdDuty" });
            DropIndex("dbo.zadDutyTypes", new[] { "IdType" });
            DropIndex("dbo.zadTaskProduction", new[] { "IdTask" });
            DropIndex("dbo.zadTaskList", new[] { "IdElement" });
            DropIndex("dbo.zadTaskList", new[] { "IdOrder" });
            DropIndex("dbo.zadElement", new[] { "IdType" });
            DropIndex("dbo.zadProdElem", new[] { "IdProduct" });
            DropIndex("dbo.zadProdElem", new[] { "IdElement" });
            DropIndex("dbo.zadOrderProduct", new[] { "IdProduct" });
            DropIndex("dbo.zadOrderProduct", new[] { "IdOrder" });
            DropIndex("dbo.zadOrder", new[] { "IdClient" });
            DropIndex("dbo.zadOrder", new[] { "IdUser" });
            DropIndex("dbo.rcpUserHarmoList", new[] { "IdHarmo" });
            DropIndex("dbo.rcpUserHarmoList", new[] { "IdUser" });
            DropIndex("dbo.rcpHarmoDef", new[] { "IdDay" });
            DropIndex("dbo.rcpHarmoDef", new[] { "IdHarmo" });
            DropIndex("dbo.rcpUserHarmo", new[] { "IdHarmo" });
            DropIndex("dbo.rcpUserHarmo", new[] { "IdUser" });
            DropIndex("dbo.rcpTransactionAll", new[] { "IdTransType" });
            DropIndex("dbo.rcpTransactionAll", new[] { "IdUser" });
            DropIndex("dbo.rcpPairsOnB", new[] { "IdUser" });
            DropIndex("dbo.rcpPairsIO", new[] { "IdUser" });
            DropIndex("dbo.rcpPairsBRK", new[] { "IdUser" });
            DropIndex("dbo.genUserDet", new[] { "IdUser" });
            DropIndex("dbo.genOrgUsers", new[] { "IdOrgUnit" });
            DropIndex("dbo.genOrgUsers", new[] { "IdUser" });
            DropIndex("dbo.genOrgUnitPriv", new[] { "IdOrgUnit" });
            DropIndex("dbo.genOrgUnitPriv", new[] { "IdUser" });
            DropIndex("dbo.genUsers", new[] { "IdRole" });
            DropIndex("dbo.genLogin", new[] { "IdUser" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.zadUserDuties");
            DropTable("dbo.zadDuties");
            DropTable("dbo.zadDutyTypes");
            DropTable("dbo.zadTypes");
            DropTable("dbo.zadTaskProduction");
            DropTable("dbo.zadTaskList");
            DropTable("dbo.zadElement");
            DropTable("dbo.zadProdElem");
            DropTable("dbo.zadProduct");
            DropTable("dbo.zadOrderProduct");
            DropTable("dbo.zadClient");
            DropTable("dbo.zadOrder");
            DropTable("dbo.rcpUserHarmoList");
            DropTable("dbo.rcpDay");
            DropTable("dbo.rcpHarmoDef");
            DropTable("dbo.rcpHarmo");
            DropTable("dbo.rcpUserHarmo");
            DropTable("dbo.rcpTranType");
            DropTable("dbo.rcpTransactionAll");
            DropTable("dbo.rcpPairsOnB");
            DropTable("dbo.rcpPairsIO");
            DropTable("dbo.rcpPairsBRK");
            DropTable("dbo.genUserDet");
            DropTable("dbo.genRoles");
            DropTable("dbo.genOrgUsers");
            DropTable("dbo.genOrgUnit");
            DropTable("dbo.genOrgUnitPriv");
            DropTable("dbo.genUsers");
            DropTable("dbo.genLogin");
            DropTable("dbo.Calendar");
        }
    }
}
