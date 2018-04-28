namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabase3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "UserId", "dbo.Users");
            DropIndex("dbo.Cars", new[] { "UserId" });
            AlterColumn("dbo.Cars", "UserId", c => c.Int());
            CreateIndex("dbo.Cars", "UserId");
            AddForeignKey("dbo.Cars", "UserId", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "UserId", "dbo.Users");
            DropIndex("dbo.Cars", new[] { "UserId" });
            AlterColumn("dbo.Cars", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "UserId");
            AddForeignKey("dbo.Cars", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
