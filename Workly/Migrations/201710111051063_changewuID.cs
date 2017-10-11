namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changewuID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorklyUsers", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorklyUsers", "UserID");
        }
    }
}
