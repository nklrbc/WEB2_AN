namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CetvrtaMigracija : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kartas", "Cena");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kartas", "Cena", c => c.Int(nullable: false));
        }
    }
}
