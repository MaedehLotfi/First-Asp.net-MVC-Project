namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class selfm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelfManagementActivities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        drug = c.Boolean(nullable: false),
                        reports = c.Boolean(nullable: false),
                        reminders = c.Boolean(nullable: false),
                        daily = c.Boolean(nullable: false),
                        shoppong = c.Boolean(nullable: false),
                        other = c.Boolean(nullable: false),
                        discription = c.String(),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SelfManagementActivities", "Pid", "dbo.Patients");
            DropIndex("dbo.SelfManagementActivities", new[] { "Pid" });
            DropTable("dbo.SelfManagementActivities");
        }
    }
}
