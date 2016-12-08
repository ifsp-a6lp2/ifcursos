namespace ifcurso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nova : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dashboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dashboards");
        }
    }
}
