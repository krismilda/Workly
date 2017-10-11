namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeRates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "WorklyUser_WorklyUserId", c => c.Int());
            CreateIndex("dbo.Reviews", "WorklyUser_WorklyUserId");
            AddForeignKey("dbo.Reviews", "WorklyUser_WorklyUserId", "dbo.WorklyUsers", "WorklyUserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "WorklyUser_WorklyUserId", "dbo.WorklyUsers");
            DropIndex("dbo.Reviews", new[] { "WorklyUser_WorklyUserId" });
            DropColumn("dbo.Reviews", "WorklyUser_WorklyUserId");
        }
    }
}
