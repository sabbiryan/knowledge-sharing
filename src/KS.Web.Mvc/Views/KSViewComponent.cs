using Abp.AspNetCore.Mvc.ViewComponents;

namespace KS.Web.Views
{
    public abstract class KSViewComponent : AbpViewComponent
    {
        protected KSViewComponent()
        {
            LocalizationSourceName = KSConsts.LocalizationSourceName;
        }
    }
}
