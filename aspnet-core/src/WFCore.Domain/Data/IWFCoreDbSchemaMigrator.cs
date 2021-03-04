using System.Threading.Tasks;

namespace WFCore.Data
{
    public interface IWFCoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
