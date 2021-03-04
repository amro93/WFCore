using Volo.Abp.Modularity;

namespace WFCore
{
    [DependsOn(
        typeof(WFCoreApplicationModule),
        typeof(WFCoreDomainTestModule)
        )]
    public class WFCoreApplicationTestModule : AbpModule
    {

    }
}