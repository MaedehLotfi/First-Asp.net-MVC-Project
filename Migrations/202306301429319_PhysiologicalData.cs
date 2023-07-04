namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhysiologicalData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhysiologicalDatas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Weight = c.String(),
                        Height = c.String(),
                        bPressure = c.String(),
                        hBeat = c.String(),
                        bSugar = c.String(),
                        PaiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.PaiId, cascadeDelete: true)
                .Index(t => t.PaiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhysiologicalDatas", "PaiId", "dbo.Patients");
            DropIndex("dbo.PhysiologicalDatas", new[] { "PaiId" });
            DropTable("dbo.PhysiologicalDatas");
        }
    }
}
