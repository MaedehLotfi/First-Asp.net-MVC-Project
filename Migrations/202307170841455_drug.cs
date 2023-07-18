namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drug : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PDrugHistories", "userId", "dbo.Patients");
            DropIndex("dbo.PDrugHistories", new[] { "userId" });
            DropTable("dbo.PDrugHistories");
        }
    }
}
