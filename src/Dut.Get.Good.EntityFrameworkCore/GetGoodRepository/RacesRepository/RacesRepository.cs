using Dut.Get.Good.EntityFrameworkCore;
using Dut.Get.Good.GetGoodDomain.Entities.Races;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Races;
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

namespace Dut.Get.Good.GetGoodRepository.RacesRepository
{
    public class RacesRepository : EfCoreRepository<GoodDbContext, Race, Guid>, IRacesRepository
    {
        public RacesRepository(IDbContextProvider<GoodDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        }
      
        public async Task AddNewRace(NewRace NewRace, CancellationToken cancellationToken = default)
        {
            var parameters = new SqlParameter[] {
                new SqlParameter("@RaceDescription", NewRace.RaceDescription),
              
            };
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Race_AddNewRace", CommandType.StoredProcedure, parameters);
            await command.ExecuteScalarAsync(cancellationToken);
        }

        public async Task<List<RacesBasicInfo>> GetAllRaces(CancellationToken cancellationToken = default)
        {
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Race_GetAllRaces", CommandType.StoredProcedure);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToList<RacesBasicInfo>(cancellationToken);
        }

       
        public async Task<RacesBasicInfo> GetRaceById(Guid RaceId, CancellationToken cancellationToken = default)
        {
            var parameters = new SqlParameter[]
             {
                 new SqlParameter("@RaceId",RaceId)
             };
            await Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = Configuration.CommandAndConnectionManager.RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Race_GetRaceById", CommandType.StoredProcedure, parameters);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToObject<RacesBasicInfo>(cancellationToken);
        }
    }
}
