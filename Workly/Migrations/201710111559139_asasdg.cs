namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asasdg : DbMigration
    {
        public override void Up()
        {
/*
            DropForeignKey("dbo.Reviews", "WorklyUser_WorklyUserId", "dbo.WorklyUsers");
            DropIndex("dbo.Reviews", new[] { "WorklyUser_WorklyUserId" });
            DropColumn("dbo.WorklyUsers", "Review_ReviewId");
            AddColumn("dbo.WorklyUsers", "Review_ReviewId", c => c.Int());
            CreateIndex("dbo.WorklyUsers", "Review_ReviewId");
            AddForeignKey("dbo.WorklyUsers", "Review_ReviewId", "dbo.Reviews", "ReviewId");
            DropColumn("dbo.Reviews", "WorklyUser_WorklyUserId");*/
        }
        
        public override void Down()
        {/*
            AddColumn("dbo.Reviews", "WorklyUser_WorklyUserId", c => c.Int());
            DropForeignKey("dbo.WorklyUsers", "Review_ReviewId", "dbo.Reviews");
            DropIndex("dbo.WorklyUsers", new[] { "Review_ReviewId" });
            DropColumn("dbo.WorklyUsers", "Review_ReviewId");
            CreateIndex("dbo.Reviews", "WorklyUser_WorklyUserId");
            AddForeignKey("dbo.Reviews", "WorklyUser_WorklyUserId", "dbo.WorklyUsers", "WorklyUserId");*/
        }
    }
}
