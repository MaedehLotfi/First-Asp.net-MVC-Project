namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ASelfManagement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ASelfManagements",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Level1 = c.Boolean(nullable: false),
                        Level2 = c.Boolean(nullable: false),
                        Level3 = c.Boolean(nullable: false),
                        Level4 = c.Boolean(nullable: false),
                        SelfManagementDescription = c.String(),
                        SId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.SId, cascadeDelete: true)
                .Index(t => t.SId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ASelfManagements", "SId", "dbo.Patients");
            DropIndex("dbo.ASelfManagements", new[] { "SId" });
            DropTable("dbo.ASelfManagements");
        }
    }
}
