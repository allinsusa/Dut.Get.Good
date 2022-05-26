using Dut.Get.Good.Configuration.CommandAndConnectionManager;
using Dut.Get.Good.EntityFrameworkCore;
using Dut.Get.Good.GetGoodDomain.Entities.Ranks;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Ranks;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Dut.Get.Good.GetGoodRepository.RanksRepository
{
    public class RanksRepository : EfCoreRepository<GoodDbContext, Rank, Guid>, IRanksRepository
    {
        public RanksRepository(IDbContextProvider<GoodDbContext> DbContextProvider) : base(DbContextProvider)
        {
        }

        public async Task AddNewRankAsync(NewRank Model, CancellationToken Token = default)
        {
            var Parameters = new[]
            {
               new SqlParameter("@RankDescription", Model.RankDescription)
            };
            await RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), Token);

            await using var Command = RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Rank_AddNewRank", CommandType.StoredProcedure, Parameters);
            await Command.ExecuteReaderAsync(Token);
        }

        public async Task<IEnumerable<RankBasicInfo>> GetAllRanksAsync(CancellationToken Token = default)
        {
            await RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), Token);

            using var command = RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Rank_GetAllRanks", CommandType.StoredProcedure);
            using var dataReader = await command.ExecuteReaderAsync(Token);
            return await dataReader.MapToList<RankBasicInfo>(Token);
        }

        public async Task<RankBasicInfo> GetRankByIdAsync(Guid RankId, CancellationToken Token = default)
        {
            var Parameters = new[]
            {
               new SqlParameter("@RankId", RankId)
            };

            await RepositoryCommandAndConnectionManager.EnsureConnectionOpenAsync(await GetDbContextAsync(), Token);
            await using var Command = RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "Rank_GetRankById", CommandType.StoredProcedure, Parameters);
            await using var DataReader = await Command.ExecuteReaderAsync(Token);
            return await DataReader.MapToObject<RankBasicInfo>(Token);
        }
    }
}
