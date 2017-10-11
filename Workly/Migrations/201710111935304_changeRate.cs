namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeRate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorklyUsers", "Rating_Rate", c => c.Int(nullable: false));
            AddColumn("dbo.WorklyUsers", "Rating_Email", c => c.String());
            AddColumn("dbo.Reviews", "Email", c => c.String());
            DropColumn("dbo.Reviews", "Stars");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Stars", c => c.Int(nullable: false));
            DropColumn("dbo.Reviews", "Email");
            DropColumn("dbo.WorklyUsers", "Rating_Email");
            DropColumn("dbo.WorklyUsers", "Rating_Rate");
        }
    }
}
