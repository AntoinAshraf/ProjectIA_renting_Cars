namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateIA_CarRentProject6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Car_Color", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Car_Color", c => c.Int(nullable: false));
        }
    }
}
