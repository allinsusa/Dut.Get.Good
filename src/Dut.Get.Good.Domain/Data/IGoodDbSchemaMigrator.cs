using System.Threading.Tasks;

namespace Dut.Get.Good.Data;

public interface IGoodDbSchemaMigrator
{
    Task MigrateAsync();
}
