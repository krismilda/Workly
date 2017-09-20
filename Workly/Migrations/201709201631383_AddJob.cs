namespace Workly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJob : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Work = c.String(nullable: false, maxLength: 250),
                        Field = c.String(nullable: false, maxLength: 50),
                        Start = c.DateTime(nullable: false),
                        Locality = c.String(nullable: false, maxLength: 50),
                        Salary = c.Single(nullable: false),
                        Duration = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jobs");
        }
    }
}
