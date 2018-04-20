namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateIA_CarRentProject7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "UserType_Id", "dbo.User_Type");
            DropForeignKey("dbo.Cars", "Category_Id", "dbo.categories");
            DropIndex("dbo.Cars", new[] { "Category_Id" });
            DropIndex("dbo.Users", new[] { "UserType_Id" });
            AddColumn("dbo.Cars", "Car_Photo", c => c.Binary(nullable: false));
            AddColumn("dbo.Users", "Date_Of_Birth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "IsAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "IsBlocked", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Cars", "Car_Model", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Car_Name", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Category_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "SSN", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            CreateIndex("dbo.Cars", "Category_Id");
            AddForeignKey("dbo.Cars", "Category_Id", "dbo.categories", "Id", cascadeDelete: true);
            DropColumn("dbo.Cars", "Is_Available");
            DropColumn("dbo.Users", "Date_Of_Birht");
            DropColumn("dbo.Users", "UserType_Id");
            DropTable("dbo.User_Type");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User_Type",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "UserType_Id", c => c.Int());
            AddColumn("dbo.Users", "Date_Of_Birth", c => c.DateTime(nullable: true));
            AddColumn("dbo.Cars", "Is_Available", c => c.Boolean(nullable: true));
            DropForeignKey("dbo.Cars", "Category_Id", "dbo.categories");
            DropIndex("dbo.Cars", new[] { "Category_Id" });
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Users", "SSN", c => c.String());
            AlterColumn("dbo.Cars", "Category_Id", c => c.Int());
            AlterColumn("dbo.Cars", "Car_Name", c => c.String());
            AlterColumn("dbo.Cars", "Car_Model", c => c.String());
            DropColumn("dbo.Users", "IsBlocked");
            DropColumn("dbo.Users", "IsAdmin");
            DropColumn("dbo.Users", "Date_Of_Birth");
            DropColumn("dbo.Cars", "Car_Photo");
            CreateIndex("dbo.Users", "UserType_Id");
            CreateIndex("dbo.Cars", "Category_Id");
            AddForeignKey("dbo.Cars", "Category_Id", "dbo.categories", "Id");
            AddForeignKey("dbo.Users", "UserType_Id", "dbo.User_Type", "Id");
        }
    }
}
