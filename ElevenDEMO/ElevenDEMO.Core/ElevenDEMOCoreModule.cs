using System.Reflection;
using Abp.Modules;

namespace ElevenDEMO
{
    public class ElevenDEMOCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
