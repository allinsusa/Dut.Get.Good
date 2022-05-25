using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dut.Get.Good.Data;
using Volo.Abp.DependencyInjection;

namespace Dut.Get.Good.EntityFrameworkCore;

public class EntityFrameworkCoreGoodDbSchemaMigrator
    : IGoodDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGoodDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the GoodDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GoodDbContext>()
            .Database
            .MigrateAsync();
    }
}
