namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class socialchng : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialActivities", "outsideCity", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SocialActivities", "discription", c => c.String());
            DropColumn("dbo.SocialActivities", "cityActivity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SocialActivities", "cityActivity", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SocialActivities", "discription", c => c.Boolean(nullable: false));
            DropColumn("dbo.SocialActivities", "outsideCity");
        }
    }
}
