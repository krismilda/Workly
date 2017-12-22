namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changewuIDs : DbMigration
    {
        public override void Up()
        {
        /*    DropColumn("dbo.WorklyUsers", "Rating_Average");
            DropColumn("dbo.WorklyUsers", "Rating_Times");
            DropColumn("dbo.WorklyUsers", "Rating_Sum");
            AddColumn("dbo.WorklyUsers", "Rating_Sum", c => c.Int(nullable: false));
            AddColumn("dbo.WorklyUsers", "Rating_Times", c => c.Int(nullable: false));
            AddColumn("dbo.WorklyUsers", "Rating_Average", c => c.Double(nullable: false));
            DropColumn("dbo.WorklyUsers", "UserID");*/
        }
        
        public override void Down()
        {
         /*   AddColumn("dbo.WorklyUsers", "Rating", c => c.Single(nullable: false));
            AddColumn("dbo.WorklyUsers", "UserID", c => c.String());
            DropColumn("dbo.WorklyUsers", "Rating_Average");
            DropColumn("dbo.WorklyUsers", "Rating_Times");
            DropColumn("dbo.WorklyUsers", "Rating_Sum");*/
        }
    }
}
