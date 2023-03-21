namespace PMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allupdatefkss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Lasttime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orders", "OrderDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orders", "Lasttime");
        }
    }
}
