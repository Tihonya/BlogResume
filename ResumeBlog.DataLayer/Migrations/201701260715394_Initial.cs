namespace ResumeBlog.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BadIps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ip = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Url = c.String(maxLength: 64),
                        Title = c.String(nullable: false, maxLength: 80),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AuthorId = c.String(nullable: false, maxLength: 128),
                        Url = c.String(maxLength: 256),
                        Title = c.String(nullable: false, maxLength: 256),
                        Summary = c.String(maxLength: 1024),
                        Content = c.String(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        ModificationAppliedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AuthorId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.AuthorId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 22),
                        MiddleName = c.String(maxLength: 25),
                        LastName = c.String(maxLength: 25),
                        IsRecruiter = c.Boolean(nullable: false),
                        IsDeveloper = c.Boolean(nullable: false),
                        PhotoUrl = c.String(maxLength: 256),
                        PhoneMobile = c.String(maxLength: 20),
                        AboutMe = c.String(maxLength: 512),
                        Ip = c.String(maxLength: 16),
                        CompanyId = c.Int(),
                        DeveloperProfileId = c.Int(),
                        IsBlocked = c.Boolean(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
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
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ParentId = c.Guid(),
                        AuthorId = c.String(maxLength: 128),
                        PostId = c.Guid(nullable: false),
                        UnauthorizedUserId = c.Int(),
                        IsPending = c.Boolean(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        IsSpam = c.Boolean(nullable: false),
                        IsAuthorizedUser = c.Boolean(nullable: false),
                        Avatar = c.String(maxLength: 2048),
                        Title = c.String(maxLength: 128),
                        RelativeLink = c.String(maxLength: 512),
                        Ip = c.String(maxLength: 16),
                        Content = c.String(nullable: false, maxLength: 1536),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        ModificationAppliedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.ParentId)
                .ForeignKey("dbo.UnauthorizedUsers", t => t.UnauthorizedUserId)
                .ForeignKey("dbo.AspNetUsers", t => t.AuthorId)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.ParentId)
                .Index(t => t.AuthorId)
                .Index(t => t.PostId)
                .Index(t => t.UnauthorizedUserId);
            
            CreateTable(
                "dbo.UnauthorizedUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Ip = c.String(maxLength: 16),
                        IsBlocked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        CompanyName = c.String(nullable: false, maxLength: 512),
                        WebSite = c.String(nullable: false, maxLength: 256),
                        CityTown = c.String(nullable: false, maxLength: 128),
                        RegionState = c.String(nullable: false, maxLength: 64),
                        Country = c.String(nullable: false, maxLength: 64),
                        OfferDetails = c.String(nullable: false, maxLength: 2048),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.DeveloperProfiles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Birthday = c.DateTime(nullable: false),
                        ContactPhone = c.String(maxLength: 20),
                        Email = c.String(maxLength: 64),
                        SelfIntroduce = c.String(nullable: false, maxLength: 1024),
                        Position = c.String(nullable: false, maxLength: 160),
                        GitHubUrl = c.String(maxLength: 256),
                        BlogUrl = c.String(maxLength: 256),
                        LinkedInUrl = c.String(maxLength: 256),
                        AdditionalInformation = c.String(maxLength: 1024),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        School = c.String(nullable: false, maxLength: 512),
                        Specialization = c.String(nullable: false, maxLength: 256),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(),
                        DeveloperProfile_UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeveloperProfiles", t => t.DeveloperProfile_UserId, cascadeDelete: true)
                .Index(t => t.DeveloperProfile_UserId);
            
            CreateTable(
                "dbo.KeyPoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        About = c.String(nullable: false, maxLength: 256),
                        Education_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Educations", t => t.Education_Id, cascadeDelete: true)
                .Index(t => t.Education_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 256),
                        Description = c.String(nullable: false, maxLength: 1024),
                        GitHub = c.String(maxLength: 256),
                        DemoUrl = c.String(maxLength: 256),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(),
                        DeveloperId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeveloperProfiles", t => t.DeveloperId, cascadeDelete: true)
                .Index(t => t.DeveloperId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 128),
                        Level = c.Int(nullable: false),
                        Specification = c.Int(nullable: false),
                        DeveloperProfile_UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeveloperProfiles", t => t.DeveloperProfile_UserId, cascadeDelete: true)
                .Index(t => t.DeveloperProfile_UserId);
            
            CreateTable(
                "dbo.WorkExperiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 512),
                        Position = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 1024),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(),
                        DeveloperProfile_UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeveloperProfiles", t => t.DeveloperProfile_UserId, cascadeDelete: true)
                .Index(t => t.DeveloperProfile_UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostId = c.Guid(nullable: false),
                        Tag = c.String(nullable: false, maxLength: 48),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.PostTags", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Posts", "AuthorId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.DeveloperProfiles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.WorkExperiences", "DeveloperProfile_UserId", "dbo.DeveloperProfiles");
            DropForeignKey("dbo.Skills", "DeveloperProfile_UserId", "dbo.DeveloperProfiles");
            DropForeignKey("dbo.Projects", "DeveloperId", "dbo.DeveloperProfiles");
            DropForeignKey("dbo.Educations", "DeveloperProfile_UserId", "dbo.DeveloperProfiles");
            DropForeignKey("dbo.KeyPoints", "Education_Id", "dbo.Educations");
            DropForeignKey("dbo.Companies", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "AuthorId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "UnauthorizedUserId", "dbo.UnauthorizedUsers");
            DropForeignKey("dbo.Comments", "ParentId", "dbo.Comments");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.PostTags", new[] { "PostId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.WorkExperiences", new[] { "DeveloperProfile_UserId" });
            DropIndex("dbo.Skills", new[] { "DeveloperProfile_UserId" });
            DropIndex("dbo.Projects", new[] { "DeveloperId" });
            DropIndex("dbo.KeyPoints", new[] { "Education_Id" });
            DropIndex("dbo.Educations", new[] { "DeveloperProfile_UserId" });
            DropIndex("dbo.DeveloperProfiles", new[] { "UserId" });
            DropIndex("dbo.Companies", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "UnauthorizedUserId" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropIndex("dbo.Comments", new[] { "AuthorId" });
            DropIndex("dbo.Comments", new[] { "ParentId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Posts", new[] { "CategoryId" });
            DropIndex("dbo.Posts", new[] { "AuthorId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PostTags");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.WorkExperiences");
            DropTable("dbo.Skills");
            DropTable("dbo.Projects");
            DropTable("dbo.KeyPoints");
            DropTable("dbo.Educations");
            DropTable("dbo.DeveloperProfiles");
            DropTable("dbo.Companies");
            DropTable("dbo.UnauthorizedUsers");
            DropTable("dbo.Comments");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Posts");
            DropTable("dbo.Categories");
            DropTable("dbo.BadIps");
        }
    }
}
