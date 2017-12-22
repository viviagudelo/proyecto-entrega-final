namespace MySmallBusiness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiotipostring : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "CategoryName", c => c.String());
            DropColumn("dbo.Category", "Categories");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "Categories", c => c.Int(nullable: false));
            DropColumn("dbo.Category", "CategoryName");
        }
    }
}
