using WFCore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace WFCore
{
    [DependsOn(
        typeof(WFCoreEntityFrameworkCoreTestModule)
        )]
    public class WFCoreDomainTestModule : AbpModule
    {

    }
}