namespace SoulHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dailyRecord : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyRecords",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        morningDrug = c.Boolean(nullable: false),
                        eveningDrug = c.Boolean(nullable: false),
                        nightDrug = c.Boolean(nullable: false),
                        ACognition = c.Boolean(nullable: false),
                        APhysical = c.Boolean(nullable: false),
                        ASocial = c.Boolean(nullable: false),
                        Weight = c.String(),
                        Height = c.String(),
                        bPressure = c.String(),
                        hBeat = c.String(),
                        bSugar = c.String(),
                        iid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Patients", t => t.iid, cascadeDelete: true)
                .Index(t => t.iid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DailyRecords", "iid", "dbo.Patients");
            DropIndex("dbo.DailyRecords", new[] { "iid" });
            DropTable("dbo.DailyRecords");
        }
    }
}
