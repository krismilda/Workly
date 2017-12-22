namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addInterested : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InterestedJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorklyUserId = c.Int(nullable: false),
                        JobId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InterestedJobs");
        }
    }
}
