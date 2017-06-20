namespace C4W.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactoModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contactoes", "Ciudad", c => c.String(nullable: false));
            AddColumn("dbo.Contactoes", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contactoes", "Telefono");
            DropColumn("dbo.Contactoes", "Ciudad");
        }
    }
}
