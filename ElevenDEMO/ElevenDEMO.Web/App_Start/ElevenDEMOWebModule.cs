using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Localization;
using Abp.Localization.Sources.Xml;
using Abp.Modules;
using System.Web.Http;
using System.Web.Http.Cors;
//using System.Web.Http.Cors;
//using System.Web.Http.co

namespace ElevenDEMO.Web
{
    [DependsOn(typeof(ElevenDEMODataModule), typeof(ElevenDEMOApplicationModule), typeof(ElevenDEMOWebApiModule))]
    public class ElevenDEMOWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    ElevenDEMOConsts.LocalizationSourceName,
                    HttpContext.Current.Server.MapPath("~/Localization/ElevenDEMO")
                    )
                );

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<ElevenDEMONavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //EnableCors();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private static void EnableCors()
        {
            //This method enables cross origin request

            var cors = new EnableCorsAttribute("*", "*", "*");
            GlobalConfiguration.Configuration.EnableCors(cors);

            //Then, we can call getTasks method from any web site like that:

            /*
             
                 $.ajax({
                    url: 'http://localhost:6247/api/services/tasksystem/task/GetTasks',
                    type: "POST",
                    dataType: 'json',
                    contentType: 'application/json',
                    data: JSON.stringify({})
                }).done(function(result) {
                    console.log(result);
                });
             
             */
        }
    }
}
