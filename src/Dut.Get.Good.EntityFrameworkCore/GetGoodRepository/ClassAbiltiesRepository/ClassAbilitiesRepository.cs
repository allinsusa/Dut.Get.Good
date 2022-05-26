using Dut.Get.Good.EntityFrameworkCore;
using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.CallAbilities;
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

namespace Dut.Get.Good.GetGoodRepository.ClassAbiltiesRepository
{
    public class ClassAbilitiesRepository : EfCoreRepository<GoodDbContext, ClassAbility, Guid>, IClassAbilitiesRepository
    {
        public ClassAbilitiesRepository(IDbContextProvider<GoodDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        }
        public async Task AddNewClassAbility(NewClassAbility ClassAbilty, CancellationToken cancellationToken = default)
        {
            var parameters = new SqlParameter[] { 
                new SqlParameter("@ClassId", ClassAbilty.ClassId),
                new SqlParameter("@AttributeId", ClassAbilty.AttributeId),
                new SqlParameter("@AbilityDescription", ClassAbilty.AbilityDescription),
            };
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "ClassAbi_AddNewClassAbility", CommandType.StoredProcedure, parameters);
            await command.ExecuteScalarAsync(cancellationToken);
        }


        public async Task<List<ClassAbilityBasicInfo>> GetAllClassAbilities(CancellationToken cancellationToken = default)
        {
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "ClassAbi_GetAllClassAbilities", CommandType.StoredProcedure);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToList<ClassAbilityBasicInfo>(cancellationToken);
        }

        public async Task<ClassAbilityBasicInfo> GetClassAbilityById(Guid ClassAbilityId, CancellationToken cancellationToken = default)
        {
            var parameters = new SqlParameter[]
             {
                 new SqlParameter("@ClassAbilityId",ClassAbilityId)
             };
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "ClassAbi_GetAllClassAbilitiesById", CommandType.StoredProcedure, parameters);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToObject<ClassAbilityBasicInfo>(cancellationToken);
        }
        public async Task<List<ClassAbilityBasicInfo>> GetAllClassAbilitiesByClassId(Guid ClassId, CancellationToken cancellationToken = default)
        {
            var parameters = new SqlParameter[]
             {
                 new SqlParameter("@ClassId",ClassId)
             };
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "ClassAbi_GetAllClassAbilitiesByClassId", CommandType.StoredProcedure, parameters);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToList<ClassAbilityBasicInfo>(cancellationToken);
        }
    }
}
