using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using ElevenDEMO.BizBaseData;

namespace ElevenDEMO
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ElevenDEMOApplicationModule))]
    public class ElevenDEMOWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //DynamicApiControllerBuilder.For<IBizBaseDataAppService>("BaseDataSercive/Vendor").Build();
            //  /api/services/BaseDataSercive/Vendor

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ElevenDEMOApplicationModule).Assembly, "app")
                .Build();
            
        }
    }
}
