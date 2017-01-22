namespace Vobacom.HappyWheels.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        BikeId = c.Int(nullable: false, identity: true),
                        SerialNumber = c.String(nullable: false, maxLength: 10),
                        Color = c.String(maxLength: 100),
                        BikeType = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BikeId);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        RentalId = c.Int(nullable: false, identity: true),
                        RentDateFrom = c.DateTime(nullable: false),
                        RentDateTo = c.DateTime(),
                        Cost = c.Decimal(precision: 18, scale: 2),
                        Bike_BikeId = c.Int(),
                        Rentee_UserId = c.Int(),
                        StationFrom_StationId = c.Int(),
                        StationTo_StationId = c.Int(),
                    })
                .PrimaryKey(t => t.RentalId)
                .ForeignKey("dbo.Bikes", t => t.Bike_BikeId)
                .ForeignKey("dbo.Users", t => t.Rentee_UserId)
                .ForeignKey("dbo.Stations", t => t.StationFrom_StationId)
                .ForeignKey("dbo.Stations", t => t.StationTo_StationId)
                .Index(t => t.Bike_BikeId)
                .Index(t => t.Rentee_UserId)
                .Index(t => t.StationFrom_StationId)
                .Index(t => t.StationTo_StationId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Gender = c.Int(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        StationId = c.Int(nullable: false, identity: true),
                        Number = c.String(maxLength: 50),
                        Capacity = c.Byte(nullable: false),
                        Address = c.String(),
                        Location_Latitude = c.Single(nullable: false),
                        Location_Longitute = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.StationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "StationTo_StationId", "dbo.Stations");
            DropForeignKey("dbo.Rentals", "StationFrom_StationId", "dbo.Stations");
            DropForeignKey("dbo.Rentals", "Rentee_UserId", "dbo.Users");
            DropForeignKey("dbo.Rentals", "Bike_BikeId", "dbo.Bikes");
            DropIndex("dbo.Rentals", new[] { "StationTo_StationId" });
            DropIndex("dbo.Rentals", new[] { "StationFrom_StationId" });
            DropIndex("dbo.Rentals", new[] { "Rentee_UserId" });
            DropIndex("dbo.Rentals", new[] { "Bike_BikeId" });
            DropTable("dbo.Stations");
            DropTable("dbo.Users");
            DropTable("dbo.Rentals");
            DropTable("dbo.Bikes");
        }
    }
}
