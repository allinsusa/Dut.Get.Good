using AutoMapper;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.Ranks;

namespace Dut.Get.Good.Web;

public class GoodWebAutoMapperProfile : Profile
{
    public GoodWebAutoMapperProfile()
    {
        CreateMap<RankBasicInfoDto, RankBasicInfoViewModel>();
    }
}
