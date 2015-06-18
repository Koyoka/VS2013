namespace ElevenDEMO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MWVendor", "Id", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MWVendor", "Id");
        }
    }
}
