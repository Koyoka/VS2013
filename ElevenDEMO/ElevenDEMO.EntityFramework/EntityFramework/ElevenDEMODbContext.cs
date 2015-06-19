using Abp.EntityFramework;
using ElevenDEMO.Vendor;
using System.Data.Entity;

namespace ElevenDEMO.EntityFramework
{
    public class ElevenDEMODbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<TblVendor> Vendors { get; set; }

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ElevenDEMODbContext()
            : base("local_2008_test")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<TblVendor>()
            //modelBuilder.Entity<TblVendor>().Ignore(t => t.Id);
            modelBuilder.Configurations.Add(new TblVendorConfig());
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ElevenDEMODataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ElevenDEMODbContext since ABP automatically handles it.
         */
        public ElevenDEMODbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
