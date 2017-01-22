namespace Vobacom.HappyWheels.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateWeightOnUser : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Users SET Weight = 70 WHERE Weight is null");
        }
        
        public override void Down()
        {
            Sql("UPDATE dbo.Users SET Weight = null WHERE Weight is not null");
        }
    }
}
