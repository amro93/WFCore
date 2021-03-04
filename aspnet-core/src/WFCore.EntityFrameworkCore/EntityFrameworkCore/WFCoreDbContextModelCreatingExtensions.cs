using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace WFCore.EntityFrameworkCore
{
    public static class WFCoreDbContextModelCreatingExtensions
    {
        public static void ConfigureWFCore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(WFCoreConsts.DbTablePrefix + "YourEntities", WFCoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}