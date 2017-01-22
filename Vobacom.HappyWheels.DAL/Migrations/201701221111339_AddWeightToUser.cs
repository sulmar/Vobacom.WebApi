namespace Vobacom.HappyWheels.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeightToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Weight", c => c.Single());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Weight");
        }
    }
}
