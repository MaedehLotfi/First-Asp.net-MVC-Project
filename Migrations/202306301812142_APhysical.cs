namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class APhysical : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.APhysicals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Level1 = c.Boolean(nullable: false),
                        Level2 = c.Boolean(nullable: false),
                        Level3 = c.Boolean(nullable: false),
                        Level4 = c.Boolean(nullable: false),
                        PhysicalDescription = c.String(),
                        PhId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.PhId, cascadeDelete: true)
                .Index(t => t.PhId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.APhysicals", "PhId", "dbo.Patients");
            DropIndex("dbo.APhysicals", new[] { "PhId" });
            DropTable("dbo.APhysicals");
        }
    }
}
