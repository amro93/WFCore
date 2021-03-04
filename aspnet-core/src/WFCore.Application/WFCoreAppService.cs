using System;
using System.Collections.Generic;
using System.Text;
using WFCore.Localization;
using Volo.Abp.Application.Services;

namespace WFCore
{
    /* Inherit your application services from this class.
     */
    public abstract class WFCoreAppService : ApplicationService
    {
        protected WFCoreAppService()
        {
            LocalizationResource = typeof(WFCoreResource);
        }
    }
}
