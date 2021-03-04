using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WFCore.Data;
using Volo.Abp.DependencyInjection;

namespace WFCore.EntityFrameworkCore
{
    public class EntityFrameworkCoreWFCoreDbSchemaMigrator
        : IWFCoreDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreWFCoreDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the WFCoreMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<WFCoreMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}