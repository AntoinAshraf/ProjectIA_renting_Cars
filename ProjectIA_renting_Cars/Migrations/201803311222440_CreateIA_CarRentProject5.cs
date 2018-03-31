namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateIA_CarRentProject5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Rented_From", c => c.DateTime());
            AlterColumn("dbo.Cars", "Rented_Till", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Rented_Till", c => c.DateTime(nullable: true));
            AlterColumn("dbo.Cars", "Rented_From", c => c.DateTime(nullable: true));
        }
    }
}
