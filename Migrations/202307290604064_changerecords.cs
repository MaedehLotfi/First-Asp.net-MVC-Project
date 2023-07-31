
namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changerecords : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DailyRecords", "ACognition");
            DropColumn("dbo.DailyRecords", "APhysical");
            DropColumn("dbo.DailyRecords", "ASocial");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DailyRecords", "ASocial", c => c.Boolean(nullable: false));
            AddColumn("dbo.DailyRecords", "APhysical", c => c.Boolean(nullable: false));
            AddColumn("dbo.DailyRecords", "ACognition", c => c.Boolean(nullable: false));
        }
    }
}
