namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class physicaltbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhysicalActivities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        walking = c.Boolean(nullable: false),
                        walkingMore = c.Boolean(nullable: false),
                        softness = c.Boolean(nullable: false),
                        running = c.Boolean(nullable: false),
                        building = c.Boolean(nullable: false),
                        fitness = c.Boolean(nullable: false),
                        exercise = c.Boolean(nullable: false),
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
            DropForeignKey("dbo.PhysicalActivities", "Pid", "dbo.Patients");
            DropIndex("dbo.PhysicalActivities", new[] { "Pid" });
            DropTable("dbo.PhysicalActivities");
        }
    }
}
