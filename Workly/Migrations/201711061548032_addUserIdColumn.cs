namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserIdColumn : DbMigration
    {
        public override void Up()
        {
        //    AddColumn("dbo.Jobs", "UserId", c => c.String());
        }
        
        public override void Down()
        {
        //    DropColumn("dbo.Jobs", "UserId");
        }
    }
}
