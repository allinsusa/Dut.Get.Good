using AutoMapper;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Races.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.ClassAbilities;
using Dut.Get.Good.Web.ViewModels.Races;
using Dut.Get.Good.Web.ViewModels.Ranks;

namespace Dut.Get.Good.Web;

public class GoodWebAutoMapperProfile : Profile
{
    public GoodWebAutoMapperProfile()
    {
        CreateMap<RankBasicInfoDto, RankBasicInfoViewModel>();
        CreateMap<RaceBasicInfoDto, RaceBasicInfoViewModel>();
        CreateMap<ClassAbilityBasicInfoDto, ClassAbilityBasicInfoViewModel>();
    }
}
