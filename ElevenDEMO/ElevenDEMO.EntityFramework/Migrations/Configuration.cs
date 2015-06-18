namespace ElevenDEMO.Migrations
{
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
        }
    }
}
