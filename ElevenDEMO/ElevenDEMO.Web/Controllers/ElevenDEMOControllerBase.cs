using Abp.Web.Mvc.Controllers;

namespace ElevenDEMO.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ElevenDEMOControllerBase : AbpController
    {
        protected ElevenDEMOControllerBase()
        {
            LocalizationSourceName = ElevenDEMOConsts.LocalizationSourceName;
        }
    }
}