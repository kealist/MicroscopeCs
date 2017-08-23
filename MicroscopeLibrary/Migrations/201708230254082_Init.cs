namespace MicroscopeLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CharacterModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SceneModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        Dialog = c.String(),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventModels", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.EventModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PeriodModels", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.PeriodModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameModels", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.GameModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameModels", t => t.GameModel_Id)
                .Index(t => t.GameModel_Id);
            
            CreateTable(
                "dbo.PaletteModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Definition = c.String(),
                        Allowed = c.Boolean(nullable: false),
                        GameModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameModels", t => t.GameModel_Id)
                .Index(t => t.GameModel_Id);
            
            CreateTable(
                "dbo.PlayerModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SceneModelCharacterModels",
                c => new
                    {
                        SceneModel_Id = c.Int(nullable: false),
                        CharacterModel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SceneModel_Id, t.CharacterModel_Id })
                .ForeignKey("dbo.SceneModels", t => t.SceneModel_Id, cascadeDelete: true)
                .ForeignKey("dbo.CharacterModels", t => t.CharacterModel_Id, cascadeDelete: true)
                .Index(t => t.SceneModel_Id)
                .Index(t => t.CharacterModel_Id);
            
            CreateTable(
                "dbo.PlayerModelGameModels",
                c => new
                    {
                        PlayerModel_Id = c.Int(nullable: false),
                        GameModel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlayerModel_Id, t.GameModel_Id })
                .ForeignKey("dbo.PlayerModels", t => t.PlayerModel_Id, cascadeDelete: true)
                .ForeignKey("dbo.GameModels", t => t.GameModel_Id, cascadeDelete: true)
                .Index(t => t.PlayerModel_Id)
                .Index(t => t.GameModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SceneModels", "Parent_Id", "dbo.EventModels");
            DropForeignKey("dbo.PlayerModelGameModels", "GameModel_Id", "dbo.GameModels");
            DropForeignKey("dbo.PlayerModelGameModels", "PlayerModel_Id", "dbo.PlayerModels");
            DropForeignKey("dbo.PeriodModels", "Parent_Id", "dbo.GameModels");
            DropForeignKey("dbo.PaletteModels", "GameModel_Id", "dbo.GameModels");
            DropForeignKey("dbo.LogModels", "GameModel_Id", "dbo.GameModels");
            DropForeignKey("dbo.EventModels", "Parent_Id", "dbo.PeriodModels");
            DropForeignKey("dbo.SceneModelCharacterModels", "CharacterModel_Id", "dbo.CharacterModels");
            DropForeignKey("dbo.SceneModelCharacterModels", "SceneModel_Id", "dbo.SceneModels");
            DropIndex("dbo.PlayerModelGameModels", new[] { "GameModel_Id" });
            DropIndex("dbo.PlayerModelGameModels", new[] { "PlayerModel_Id" });
            DropIndex("dbo.SceneModelCharacterModels", new[] { "CharacterModel_Id" });
            DropIndex("dbo.SceneModelCharacterModels", new[] { "SceneModel_Id" });
            DropIndex("dbo.PaletteModels", new[] { "GameModel_Id" });
            DropIndex("dbo.LogModels", new[] { "GameModel_Id" });
            DropIndex("dbo.PeriodModels", new[] { "Parent_Id" });
            DropIndex("dbo.EventModels", new[] { "Parent_Id" });
            DropIndex("dbo.SceneModels", new[] { "Parent_Id" });
            DropTable("dbo.PlayerModelGameModels");
            DropTable("dbo.SceneModelCharacterModels");
            DropTable("dbo.PlayerModels");
            DropTable("dbo.PaletteModels");
            DropTable("dbo.LogModels");
            DropTable("dbo.GameModels");
            DropTable("dbo.PeriodModels");
            DropTable("dbo.EventModels");
            DropTable("dbo.SceneModels");
            DropTable("dbo.CharacterModels");
        }
    }
}
