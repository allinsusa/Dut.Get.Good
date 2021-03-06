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
using static Dut.Get.Good.Web.Pages.ClassAbilities.AddNewClassAbilityModel;

namespace Dut.Get.Good.Web;

public class GoodWebAutoMapperProfile : Profile
{
    public GoodWebAutoMapperProfile()
    {
        CreateMap<RankBasicInfoDto, RankBasicInfoViewModel>();
        CreateMap<RaceBasicInfoDto, RaceBasicInfoViewModel>();
        CreateMap<ClassAbilityBasicInfoDto, ClassAbilityBasicInfoViewModel>();
       
        CreateMap<ClassAbilityUpdateDto, ClassAbilityUpdateViewModel>();

        CreateMap<NewClassAbiltyViewModel, NewClassAbilityDto>();
        CreateMap<NewClassAbilityDto, NewClassAbiltyViewModel>();

        CreateMap<AttributeBasicInfoDto, AttributeBasicInfoViewModel>();
        CreateMap<ClassBasicInfoDto, ClassBasicInfoViewModel>();
        CreateMap<NewAttributeViewModel, NewAttributeDto>();

        CreateMap<TextValuePairsDto, ClassSelectListViewModel>();
        CreateMap<AttributeSelectListDto, AttributeSelectListViewModel>();
        CreateMap<NewRankViewModel, NewRankDto>();
        CreateMap<AddNewClassViewModel, AddNewClassDto>();
        CreateMap<NewRaceViewModel, NewRaceDto>();
        CreateMap<TextValuePairsDto, TextValuePairViewModel>();


    }
}

