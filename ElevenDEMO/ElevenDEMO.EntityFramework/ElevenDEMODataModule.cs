using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using ElevenDEMO.EntityFramework;

namespace ElevenDEMO
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ElevenDEMOCoreModule))]
    public class ElevenDEMODataModule : AbpModule
    {
        //public override void PreInitialize()
        //{
        //    Configuration.DefaultNameOrConnectionString = "Default";
        //}

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ElevenDEMODbContext>(null);
        }
    }
}
