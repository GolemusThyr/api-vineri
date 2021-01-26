namespace api_vineri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "City");
        }
    }
}
