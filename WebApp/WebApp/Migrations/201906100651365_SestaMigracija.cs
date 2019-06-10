namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SestaMigracija : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Linijas", "VremePolaska");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Linijas", "VremePolaska", c => c.String());
        }
    }
}
