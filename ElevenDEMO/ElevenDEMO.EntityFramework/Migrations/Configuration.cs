namespace ElevenDEMO.Migrations
{
    using ElevenDEMO.Vendor;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ElevenDEMO.EntityFramework.ElevenDEMODbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ElevenDEMO";
        }

        protected override void Seed(ElevenDEMO.EntityFramework.ElevenDEMODbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            context.Vendors.AddOrUpdate(
                //x => x.VendorCode,
                //x => x.VendorCode,
                new TblVendor()
                {
                    VendorCode = "1",
                    Vendor = "1",
                    Address = "1"
                },
                new TblVendor()
                {
                    VendorCode = "2",
                    Vendor = "2",
                    Address = "2"
                },
                new TblVendor()
                {
                    VendorCode = "3",
                    Vendor = "3",
                    Address = "3"
                },
                new TblVendor()
                {
                    VendorCode = "4",
                    Vendor = "4",
                    Address = "4"
                }

                );
          
        }
    }
}
