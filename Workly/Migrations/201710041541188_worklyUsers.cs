namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class worklyUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorklyUsers",
                c => new
                    {
                        WorklyUserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Rating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.WorklyUserId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        Stars = c.Int(nullable: false),
                        Comment = c.String(maxLength: 2000),
                        WorklyUser_WorklyUserId = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.WorklyUsers", t => t.WorklyUser_WorklyUserId)
                .Index(t => t.WorklyUser_WorklyUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "WorklyUser_WorklyUserId", "dbo.WorklyUsers");
            DropIndex("dbo.Reviews", new[] { "WorklyUser_WorklyUserId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.WorklyUsers");
        }
    }
}
