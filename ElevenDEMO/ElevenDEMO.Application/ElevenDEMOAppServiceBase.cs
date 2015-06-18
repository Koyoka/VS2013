using Abp.Application.Services;

namespace ElevenDEMO
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ElevenDEMOAppServiceBase : ApplicationService
    {
        protected ElevenDEMOAppServiceBase()
        {
            LocalizationSourceName = ElevenDEMOConsts.LocalizationSourceName;
        }
    }
}