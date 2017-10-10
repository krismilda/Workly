namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _default : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "WorklyUser_WorklyUserId", "dbo.WorklyUsers");
            DropIndex("dbo.Reviews", new[] { "WorklyUser_WorklyUserId" });
            DropTable("dbo.WorklyUsers");
            DropTable("dbo.Reviews");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        Stars = c.Int(nullable: false),
                        Comment = c.String(maxLength: 2000),
                        WorklyUser_WorklyUserId = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewId);
            
            CreateTable(
                "dbo.WorklyUsers",
                c => new
                    {
                        WorklyUserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Rating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.WorklyUserId);
            
            CreateIndex("dbo.Reviews", "WorklyUser_WorklyUserId");
            AddForeignKey("dbo.Reviews", "WorklyUser_WorklyUserId", "dbo.WorklyUsers", "WorklyUserId");
        }
    }
}
