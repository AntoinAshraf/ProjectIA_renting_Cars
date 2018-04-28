namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabase2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "Rented_To_Id", "dbo.Users");
            DropIndex("dbo.Cars", new[] { "Rented_To_Id" });
            RenameColumn(table: "dbo.Cars", name: "Rented_To_Id", newName: "UserId");
            AlterColumn("dbo.Cars", "UserId", c => c.Int(nullable: true));
            CreateIndex("dbo.Cars", "UserId");
            AddForeignKey("dbo.Cars", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.Cars", "RentedId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "RentedId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Cars", "UserId", "dbo.Users");
            DropIndex("dbo.Cars", new[] { "UserId" });
            AlterColumn("dbo.Cars", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Cars", name: "UserId", newName: "Rented_To_Id");
            CreateIndex("dbo.Cars", "Rented_To_Id");
            AddForeignKey("dbo.Cars", "Rented_To_Id", "dbo.Users", "Id");
        }
    }
}
