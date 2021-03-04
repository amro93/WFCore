using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace WFCore.EntityFrameworkCore
{
    [DependsOn(
        typeof(WFCoreEntityFrameworkCoreModule)
        )]
    public class WFCoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<WFCoreMigrationsDbContext>();
        }
    }
}
