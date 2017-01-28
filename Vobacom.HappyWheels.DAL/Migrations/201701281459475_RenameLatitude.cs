namespace Vobacom.HappyWheels.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameLatitude : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "Location_Longitude", c => c.Single(nullable: false));
            AddColumn("dbo.Stations", "Location_Longitude", c => c.Single(nullable: false));
            DropColumn("dbo.Bikes", "Location_Longitute");
            DropColumn("dbo.Stations", "Location_Longitute");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stations", "Location_Longitute", c => c.Single(nullable: false));
            AddColumn("dbo.Bikes", "Location_Longitute", c => c.Single(nullable: false));
            DropColumn("dbo.Stations", "Location_Longitude");
            DropColumn("dbo.Bikes", "Location_Longitude");
        }
    }
}
