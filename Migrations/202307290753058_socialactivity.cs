namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class socialactivity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialActivities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Walking = c.Boolean(nullable: false),
                        party = c.Boolean(nullable: false),
                        picnic = c.Boolean(nullable: false),
                        cityActivity = c.Boolean(nullable: false),
                        groupActivity = c.Boolean(nullable: false),
                        helping = c.Boolean(nullable: false),
                        pray = c.Boolean(nullable: false),
                        art = c.Boolean(nullable: false),
                        travel = c.Boolean(nullable: false),
                        family = c.Boolean(nullable: false),
                        other = c.Boolean(nullable: false),
                        discription = c.Boolean(nullable: false),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialActivities", "Pid", "dbo.Patients");
            DropIndex("dbo.SocialActivities", new[] { "Pid" });
            DropTable("dbo.SocialActivities");
        }
    }
}
