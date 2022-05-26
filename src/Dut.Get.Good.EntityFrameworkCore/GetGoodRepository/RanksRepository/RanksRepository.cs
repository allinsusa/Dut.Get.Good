using Dut.Get.Good.EntityFrameworkCore;
using Dut.Get.Good.GetGoodDomain.Entities.Ranks;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Ranks;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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

            await using var Command = RepositoryCommandAndConnectionManager.CreateCommand(await GetDbContextAsync(), "CreateCategory", CommandType.StoredProcedure, Parameters);
            await Command.ExecuteReaderAsync(Token);
        }

        public async Task<IEnumerable<RankBasicInfo>> GetAllRanksAsync(CancellationToken Token = default)
        {
            throw new NotImplementedException();
        }

        public async Task<RankBasicInfo> GetRankByIdAsync(Guid RankId, CancellationToken Token = default)
        {
            throw new NotImplementedException();
        }
    }
}
