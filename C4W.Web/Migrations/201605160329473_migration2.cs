namespace C4W.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactoLandings", "Ciudad", c => c.String(nullable: false));
            AddColumn("dbo.ContactoLandings", "Landing", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactoLandings", "Landing");
            DropColumn("dbo.ContactoLandings", "Ciudad");
        }
    }
}
