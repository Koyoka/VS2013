namespace ElevenDEMO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MWVendor",
                c => new
                    {
                        VendorCode = c.String(nullable: false, maxLength: 20),
                        Vendor = c.String(maxLength: 45),
                        Address = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.VendorCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MWVendor");
        }
    }
}
