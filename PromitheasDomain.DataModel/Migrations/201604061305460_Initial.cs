namespace PromitheasDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        GalleryId = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        TattooCategory = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Galleries", t => t.GalleryId, cascadeDelete: true)
                .Index(t => t.GalleryId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        ShopId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryId)
                .ForeignKey("dbo.Shops", t => t.ShopId, cascadeDelete: true)
                .Index(t => t.ShopId);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ShopId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SubTitle = c.String(),
                        SmallDescription = c.String(),
                        FullDescription = c.String(),
                        LogoUrl = c.String(),
                        Address = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                        State = c.String(),
                        LandLine1 = c.String(),
                        LandLine2 = c.String(),
                        Mobile1 = c.String(),
                        Mobile2 = c.String(),
                        Email = c.String(),
                        Skype = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        ShopMembershipType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShopId);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        ShopId = c.Int(nullable: false),
                        SocialMediaUrl = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaId)
                .ForeignKey("dbo.Shops", t => t.ShopId, cascadeDelete: true)
                .Index(t => t.ShopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialMedias", "ShopId", "dbo.Shops");
            DropForeignKey("dbo.Galleries", "ShopId", "dbo.Shops");
            DropForeignKey("dbo.Images", "GalleryId", "dbo.Galleries");
            DropIndex("dbo.SocialMedias", new[] { "ShopId" });
            DropIndex("dbo.Galleries", new[] { "ShopId" });
            DropIndex("dbo.Images", new[] { "GalleryId" });
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Shops");
            DropTable("dbo.Galleries");
            DropTable("dbo.Images");
        }
    }
}
