namespace Vobacom.HappyWheels.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRowVersionToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RowVersion");
        }
    }
}
