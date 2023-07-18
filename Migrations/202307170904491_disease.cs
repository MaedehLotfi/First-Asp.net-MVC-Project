namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class disease : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PDrugHistories", "userId", "dbo.Patients");
            DropIndex("dbo.PDrugHistories", new[] { "userId" });
            CreateTable(
                "dbo.DiseaseRecords",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DiseaseTitle = c.String(),
                        DiseaseDescription = c.String(),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
            DropTable("dbo.PDrugHistories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PDrugHistories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DrugHistoryTitle = c.String(),
                        DrugDescription = c.String(),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropForeignKey("dbo.DiseaseRecords", "userId", "dbo.Patients");
            DropIndex("dbo.DiseaseRecords", new[] { "userId" });
            DropTable("dbo.DiseaseRecords");
            CreateIndex("dbo.PDrugHistories", "userId");
            AddForeignKey("dbo.PDrugHistories", "userId", "dbo.Patients", "id", cascadeDelete: true);
        }
    }
}
