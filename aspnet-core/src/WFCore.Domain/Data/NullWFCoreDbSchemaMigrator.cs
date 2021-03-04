using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WFCore.Data
{
    /* This is used if database provider does't define
     * IWFCoreDbSchemaMigrator implementation.
     */
    public class NullWFCoreDbSchemaMigrator : IWFCoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}