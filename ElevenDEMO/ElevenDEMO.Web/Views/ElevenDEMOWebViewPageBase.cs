using Abp.Web.Mvc.Views;

namespace ElevenDEMO.Web.Views
{
    public abstract class ElevenDEMOWebViewPageBase : ElevenDEMOWebViewPageBase<dynamic>
    {

    }

    public abstract class ElevenDEMOWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ElevenDEMOWebViewPageBase()
        {
            LocalizationSourceName = ElevenDEMOConsts.LocalizationSourceName;
        }
    }
}