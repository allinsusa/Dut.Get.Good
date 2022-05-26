using Dut.Get.Good.GetGoodDomain.Entities.Ranks;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Dut.Get.Good.GetGoodDomain.EntityInterfaces.Ranks
{
    public interface IRanksRepository : IBasicRepository<Rank, Guid>
    {
        Task AddNewRankAsync(NewRank Model, CancellationToken Token = default);
        Task<IEnumerable<RankBasicInfo>> GetAllRanksAsync(CancellationToken Token = default);
        Task<RankBasicInfo> GetRankByIdAsync(Guid RankId, CancellationToken Token = default);
    }
}
