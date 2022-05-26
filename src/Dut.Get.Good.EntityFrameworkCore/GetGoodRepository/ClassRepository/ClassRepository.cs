using Dut.Get.Good.EntityFrameworkCore;
using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Dut.Get.Good.GetGoodRepository.ClassRepository
{
    public class ClassRepository : EfCoreRepository<GoodDbContext, Class, Guid>, IClassRepository
    {
        public ClassRepository(IDbContextProvider<GoodDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        }

        public async Task AddNewClass(AddNewClass Class, CancellationToken cancellationToken = default)
        {
            var parameters = new SqlParameter[] {
                new SqlParameter("@ClassDescription", Class.ClassDescription)
            };
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Class_AddNewClass", CommandType.StoredProcedure, parameters);
            await command.ExecuteScalarAsync(cancellationToken);
        }

        public async Task<List<ClassBasicInfo>> GetAllClasses(CancellationToken cancellationToken = default)
        {
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Class_GetAllClasses", CommandType.StoredProcedure);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToList<ClassBasicInfo>(cancellationToken);
        }

        public async Task<ClassBasicInfo> GetClassById(Guid ClassId, CancellationToken cancellationToken = default)
        {
            var parameters = new SqlParameter[] {
                new SqlParameter("@ClassId",ClassId)
            };
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Class_GetClassById", CommandType.StoredProcedure);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToObject<ClassBasicInfo>(cancellationToken);
        }
    }
}
