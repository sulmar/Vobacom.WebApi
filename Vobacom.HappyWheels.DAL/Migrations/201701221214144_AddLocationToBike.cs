namespace Vobacom.HappyWheels.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationToBike : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "Location_Latitude", c => c.Single(nullable: false));
            AddColumn("dbo.Bikes", "Location_Longitute", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "Location_Longitute");
            DropColumn("dbo.Bikes", "Location_Latitude");
        }
    }
}
