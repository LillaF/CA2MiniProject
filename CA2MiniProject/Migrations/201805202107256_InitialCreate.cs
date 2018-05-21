namespace CA2MiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appliance",
                c => new
                    {
                        ApplianceID = c.Int(nullable: false, identity: true),
                        EnergySrc = c.String(),
                        Brand = c.String(),
                        Type = c.String(),
                        Power = c.Int(nullable: false),
                        CostPerMin = c.Int(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ApplianceID)
                .ForeignKey("dbo.User", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        MinsUsed = c.Int(nullable: false),
                        ApplianceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appliance", "User_UserID", "dbo.User");
            DropIndex("dbo.Appliance", new[] { "User_UserID" });
            DropTable("dbo.User");
            DropTable("dbo.Appliance");
        }
    }
}
