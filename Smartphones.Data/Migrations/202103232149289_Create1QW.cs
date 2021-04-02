namespace Smartphones.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create1QW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopNetworks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OwnerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            Sql("INSERT INTO [dbo].[Shops](Name,City,Address) VALUES('Beaty Bags','Kharkiv','Sumskaya 30')");
            AddColumn("dbo.Shops", "NetworkId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Shops", "NetworkId");
            AddForeignKey("dbo.Shops", "NetworkId", "dbo.ShopNetworks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopNetworks", "OwnerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Shops", "NetworkId", "dbo.ShopNetworks");
            DropIndex("dbo.Shops", new[] { "NetworkId" });
            DropIndex("dbo.ShopNetworks", new[] { "OwnerId" });
            DropColumn("dbo.AspNetUsers", "Discriminator");
            DropColumn("dbo.Shops", "NetworkId");
            DropTable("dbo.ShopNetworks");
        }
    }
}
