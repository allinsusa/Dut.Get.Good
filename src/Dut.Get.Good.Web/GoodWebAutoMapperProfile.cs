using AutoMapper;
using Dut.Get.Good.GetGoodApplicationContracts.Attributes.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Races.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.Attributes;
using Dut.Get.Good.Web.ViewModels.Class;
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

        CreateMap<NewClassAbiltyViewModel, NewClassAbilityDto>();
        CreateMap<NewClassAbilityDto, NewClassAbiltyViewModel>();

        CreateMap<AttributeBasicInfoDto, AttributeBasicInfoViewModel>();
        CreateMap<ClassBasicInfoDto, ClassBasicInfoViewModel>();
        CreateMap<NewAttributeViewModel, NewAttributeDto>();

        CreateMap<ClassSelectListDto, ClassSelectListViewModel>();
        CreateMap<AttributeSelectListDto, AttributeSelectListViewModel>();
        CreateMap<NewRankViewModel, NewRankDto>();
    }
}

