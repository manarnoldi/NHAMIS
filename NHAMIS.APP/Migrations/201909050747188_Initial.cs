namespace NHAMIS.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcademicQualification",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NominationId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nomination", t => t.NominationId)
                .Index(t => t.NominationId);
            
            CreateTable(
                "dbo.Nomination",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdNumber = c.String(),
                        Surname = c.String(),
                        OtherNames = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        CountyOfBirth = c.String(),
                        Address = c.String(),
                        EmailAddress = c.String(),
                        MobileNumber = c.String(),
                        Location = c.String(),
                        SubLocation = c.String(),
                        Village = c.String(),
                        Occupation = c.String(),
                        PublicServiceRecords = c.String(),
                        Status = c.String(),
                        WardId = c.Int(nullable: false),
                        SalutationId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Salutation", t => t.SalutationId)
                .ForeignKey("dbo.Ward", t => t.WardId)
                .Index(t => t.WardId)
                .Index(t => t.SalutationId);
            
            CreateTable(
                "dbo.NominationBody",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Surname = c.String(),
                        OtherNames = c.String(),
                        Designation = c.String(),
                        Address = c.String(),
                        EmailAddress = c.String(),
                        TelephoneNo = c.String(),
                        MobileNo = c.String(),
                        NominationId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nomination", t => t.NominationId)
                .Index(t => t.NominationId);
            
            CreateTable(
                "dbo.NominationPeriod",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        NominationDate = c.DateTime(nullable: false),
                        NominationId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nomination", t => t.NominationId)
                .Index(t => t.NominationId);
            
            CreateTable(
                "dbo.Salutation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ward",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WardName = c.String(),
                        WardCode = c.String(),
                        SubCountyId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subcounty", t => t.SubCountyId)
                .Index(t => t.SubCountyId);
            
            CreateTable(
                "dbo.Subcounty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubCountyName = c.String(),
                        SubCountyCode = c.String(),
                        CountyId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.County", t => t.CountyId)
                .Index(t => t.CountyId);
            
            CreateTable(
                "dbo.County",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountyName = c.String(),
                        CountyCode = c.String(),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Citation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Achievement = c.String(),
                        Engagements = c.String(),
                        OtherContributions = c.String(),
                        NominationId = c.Int(nullable: false),
                        MedalId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medal", t => t.MedalId)
                .ForeignKey("dbo.Nomination", t => t.NominationId)
                .Index(t => t.NominationId)
                .Index(t => t.MedalId);
            
            CreateTable(
                "dbo.Medal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abbreviation = c.String(),
                        Quantity = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HonorRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SerialNo = c.String(),
                        ConfirementDate = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        SalutationId = c.Int(nullable: false),
                        MedalId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medal", t => t.MedalId)
                .ForeignKey("dbo.Salutation", t => t.SalutationId)
                .Index(t => t.SalutationId)
                .Index(t => t.MedalId);
            
            CreateTable(
                "dbo.NominatingBody",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        Ministry = c.String(),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NominationAttachment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AttachmentType = c.String(),
                        AttachmentUrl = c.String(),
                        NominationId = c.Int(nullable: false),
                        CreateBy = c.String(maxLength: 128),
                        CreateDate = c.DateTime(),
                        ModifyBy = c.String(maxLength: 128),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nomination", t => t.NominationId)
                .Index(t => t.NominationId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(maxLength: 500),
                        SecurityStamp = c.String(maxLength: 500),
                        PhoneNumber = c.String(maxLength: 50),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(maxLength: 150),
                        ClaimValue = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.NominationAttachment", "NominationId", "dbo.Nomination");
            DropForeignKey("dbo.HonorRole", "SalutationId", "dbo.Salutation");
            DropForeignKey("dbo.HonorRole", "MedalId", "dbo.Medal");
            DropForeignKey("dbo.Citation", "NominationId", "dbo.Nomination");
            DropForeignKey("dbo.Citation", "MedalId", "dbo.Medal");
            DropForeignKey("dbo.Nomination", "WardId", "dbo.Ward");
            DropForeignKey("dbo.Ward", "SubCountyId", "dbo.Subcounty");
            DropForeignKey("dbo.Subcounty", "CountyId", "dbo.County");
            DropForeignKey("dbo.Nomination", "SalutationId", "dbo.Salutation");
            DropForeignKey("dbo.NominationPeriod", "NominationId", "dbo.Nomination");
            DropForeignKey("dbo.NominationBody", "NominationId", "dbo.Nomination");
            DropForeignKey("dbo.AcademicQualification", "NominationId", "dbo.Nomination");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.NominationAttachment", new[] { "NominationId" });
            DropIndex("dbo.HonorRole", new[] { "MedalId" });
            DropIndex("dbo.HonorRole", new[] { "SalutationId" });
            DropIndex("dbo.Citation", new[] { "MedalId" });
            DropIndex("dbo.Citation", new[] { "NominationId" });
            DropIndex("dbo.Subcounty", new[] { "CountyId" });
            DropIndex("dbo.Ward", new[] { "SubCountyId" });
            DropIndex("dbo.NominationPeriod", new[] { "NominationId" });
            DropIndex("dbo.NominationBody", new[] { "NominationId" });
            DropIndex("dbo.Nomination", new[] { "SalutationId" });
            DropIndex("dbo.Nomination", new[] { "WardId" });
            DropIndex("dbo.AcademicQualification", new[] { "NominationId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.NominationAttachment");
            DropTable("dbo.NominatingBody");
            DropTable("dbo.HonorRole");
            DropTable("dbo.Medal");
            DropTable("dbo.Citation");
            DropTable("dbo.County");
            DropTable("dbo.Subcounty");
            DropTable("dbo.Ward");
            DropTable("dbo.Salutation");
            DropTable("dbo.NominationPeriod");
            DropTable("dbo.NominationBody");
            DropTable("dbo.Nomination");
            DropTable("dbo.AcademicQualification");
        }
    }
}
