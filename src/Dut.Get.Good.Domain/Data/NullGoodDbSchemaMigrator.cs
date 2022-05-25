using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dut.Get.Good.Data;

/* This is used if database provider does't define
 * IGoodDbSchemaMigrator implementation.
 */
public class NullGoodDbSchemaMigrator : IGoodDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
