using WFCore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WFCore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class WFCoreController : AbpController
    {
        protected WFCoreController()
        {
            LocalizationResource = typeof(WFCoreResource);
        }
    }
}