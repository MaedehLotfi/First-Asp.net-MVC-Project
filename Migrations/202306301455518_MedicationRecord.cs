namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MedicationRecord : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicationRecords",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MedicationTitle = c.String(),
                        MedicationDescription = c.String(),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MedicationRecords", "userId", "dbo.Patients");
            DropIndex("dbo.MedicationRecords", new[] { "userId" });
            DropTable("dbo.MedicationRecords");
        }
    }
}
