namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorklyUsers", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorklyUsers", "Role");
        }
    }
}
