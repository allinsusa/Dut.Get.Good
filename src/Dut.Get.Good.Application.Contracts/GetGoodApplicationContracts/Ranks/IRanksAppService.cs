using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Dut.Get.Good.GetGoodApplicationContracts.Ranks
{
    public interface IRanksAppService : IApplicationService
    {
        Task AddNewRankAsync(NewRankDto Model);
        Task<IEnumerable<RankBasicInfoDto>> GetAllRanksAsync();
        Task<RankBasicInfoDto> GetRankByIdAsync(Guid RankId);
    }
}
