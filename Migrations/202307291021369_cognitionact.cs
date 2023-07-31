namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cognitionact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CognitionActivities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        reading = c.Boolean(nullable: false),
                        watching = c.Boolean(nullable: false),
                        quiz = c.Boolean(nullable: false),
                        game = c.Boolean(nullable: false),
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
            DropForeignKey("dbo.CognitionActivities", "Pid", "dbo.Patients");
            DropIndex("dbo.CognitionActivities", new[] { "Pid" });
            DropTable("dbo.CognitionActivities");
        }
    }
}
