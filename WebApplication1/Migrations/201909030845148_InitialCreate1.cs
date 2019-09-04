namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "Secret");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "Secret", c => c.String());
        }
    }
}
