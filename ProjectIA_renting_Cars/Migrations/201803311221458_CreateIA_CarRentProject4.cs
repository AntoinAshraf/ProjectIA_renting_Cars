namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateIA_CarRentProject4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Rented_From", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cars", "Rented_Till", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Rented_Till", c => c.DateTime());
            AlterColumn("dbo.Cars", "Rented_From", c => c.DateTime());
        }
    }
}
