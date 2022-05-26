using AutoMapper;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.Ranks;

namespace Dut.Get.Good;

public class GoodApplicationAutoMapperProfile : Profile
{
    public GoodApplicationAutoMapperProfile()
    {
        CreateMap<NewRankDto, NewRank>();
        CreateMap<RankBasicInfo, RankBasicInfoDto>();
    }
}
