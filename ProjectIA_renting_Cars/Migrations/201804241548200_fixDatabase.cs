namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabase : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cars", name: "Category_Id", newName: "CategoryID");
            RenameIndex(table: "dbo.Cars", name: "IX_Category_Id", newName: "IX_CategoryID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Cars", name: "IX_CategoryID", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.Cars", name: "CategoryID", newName: "Category_Id");
        }
    }
}
