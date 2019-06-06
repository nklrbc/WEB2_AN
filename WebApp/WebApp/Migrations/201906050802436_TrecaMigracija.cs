namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrecaMigracija : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kartas", "Cena", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kartas", "Cena");
        }
    }
}
