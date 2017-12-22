namespace MySmallBusiness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablename : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Category", newName: "Categories");
            RenameTable(name: "dbo.Entrepreneurship", newName: "Entrepreneurships");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Entrepreneurships", newName: "Entrepreneurship");
            RenameTable(name: "dbo.Categories", newName: "Category");
        }
    }
}
