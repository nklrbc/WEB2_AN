namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PetaMigracija : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArhivaCenovnikas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        Tip = c.Int(nullable: false),
                        Cena = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Popusts",
                c => new
                    {
                        Korisnik = c.Int(nullable: false),
                        Koeficijent = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Korisnik);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Popusts");
            DropTable("dbo.ArhivaCenovnikas");
        }
    }
}
