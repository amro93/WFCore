using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace WFCore
{
    [Dependency(ReplaceServices = true)]
    public class WFCoreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "WFCore";
    }
}
