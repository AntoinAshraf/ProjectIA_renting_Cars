namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabase1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "RentedId", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "RentedId");
        }
    }
}
