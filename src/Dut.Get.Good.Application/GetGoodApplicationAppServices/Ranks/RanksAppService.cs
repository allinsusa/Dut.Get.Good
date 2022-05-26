using Dut.Get.Good.GetGoodApplicationContracts.Ranks;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.Ranks;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Ranks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationAppServices.Ranks
{
    public class RanksAppService : GoodAppService, IRanksAppService
    {
        private readonly IRanksRepository _ranksRepository;
        public RanksAppService(IRanksRepository RanksRepositoryObj)
        {
            _ranksRepository = RanksRepositoryObj;
        }

        public async Task AddNewRankAsync(NewRankDto Model)
        {
            var DbModel = ObjectMapper.Map<NewRankDto, NewRank>(Model);
            await _ranksRepository.AddNewRankAsync(DbModel);
        }

        public async Task<IEnumerable<RankBasicInfoDto>> GetAllRanksAsync()
        {
            var ReturnResult = await _ranksRepository.GetAllRanksAsync();
            return ObjectMapper.Map<IEnumerable<RankBasicInfo>, IEnumerable<RankBasicInfoDto>>(ReturnResult);
        }

        public async Task<RankBasicInfoDto> GetRankByIdAsync(Guid RankId)
        {
            var ReturnResult = await _ranksRepository.GetRankByIdAsync(RankId);
            return ObjectMapper.Map<RankBasicInfo, RankBasicInfoDto>(ReturnResult);
        }
    }
}
