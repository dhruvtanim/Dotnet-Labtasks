namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finallabtask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(maxLength: 150),
                        Name = c.String(maxLength: 500),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Status = c.String(),
                        Startdate = c.DateTime(nullable: false),
                        Enddate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Project_Id", "dbo.Projects");
            DropIndex("dbo.Members", new[] { "Project_Id" });
            DropTable("dbo.Projects");
            DropTable("dbo.Members");
        }
    }
}
