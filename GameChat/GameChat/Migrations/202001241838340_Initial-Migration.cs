namespace GameChat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerMessages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PlayersID = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 30),
                        MessageSent = c.String(nullable: false),
                        DateSent = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Players", t => t.PlayersID, cascadeDelete: true)
                .Index(t => t.PlayersID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerMessages", "PlayersID", "dbo.Players");
            DropIndex("dbo.PlayerMessages", new[] { "PlayersID" });
            DropTable("dbo.Players");
            DropTable("dbo.PlayerMessages");
        }
    }
}
