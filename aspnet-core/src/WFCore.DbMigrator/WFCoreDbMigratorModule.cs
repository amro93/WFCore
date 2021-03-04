using WFCore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace WFCore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(WFCoreEntityFrameworkCoreDbMigrationsModule),
        typeof(WFCoreApplicationContractsModule)
        )]
    public class WFCoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
