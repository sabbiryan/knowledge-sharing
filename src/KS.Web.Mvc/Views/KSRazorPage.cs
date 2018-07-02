using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace KS.Web.Views
{
    public abstract class KSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected KSRazorPage()
        {
            LocalizationSourceName = KSConsts.LocalizationSourceName;
        }
    }
}
