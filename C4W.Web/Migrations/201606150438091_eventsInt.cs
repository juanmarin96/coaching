namespace C4W.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventsInt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "MonthNro", c => c.Int());
            AddColumn("dbo.Events", "DaysNro", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "DaysNro");
            DropColumn("dbo.Events", "MonthNro");
        }
    }
}
