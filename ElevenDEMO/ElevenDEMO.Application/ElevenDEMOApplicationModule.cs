using System.Reflection;
using Abp.Modules;

namespace ElevenDEMO
{
    [DependsOn(typeof(ElevenDEMOCoreModule))]
    public class ElevenDEMOApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
