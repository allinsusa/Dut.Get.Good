using AutoMapper;
using Dut.Get.Good.GetGoodApplicationContracts.Attributes.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Races.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using Dut.Get.Good.GetGoodDomain.Entities.Races;
using Dut.Get.Good.GetGoodDomain.Entities.Ranks;

namespace Dut.Get.Good;

public class GoodApplicationAutoMapperProfile : Profile
{
    public GoodApplicationAutoMapperProfile()
    {
        CreateMap<NewRankDto, NewRank>();
        CreateMap<RankBasicInfo, RankBasicInfoDto>();
        CreateMap<NewAttributeDto, NewAttribute>();
        CreateMap<AttributeBasicInfo, AttributeBasicInfoDto>();
        CreateMap<NewClassAbilityDto, NewClassAbility>();
        CreateMap<NewClassAbility, NewClassAbilityDto>();
        CreateMap<ClassAbilityBasicInfo, ClassAbilityBasicInfoDto>();
        CreateMap<AddNewClassDto, AddNewClass>(); 
        CreateMap<ClassBasicInfo, ClassBasicInfoDto>();
        CreateMap<NewRaceDto, NewRace>();
        CreateMap<RacesBasicInfo, RaceBasicInfoDto>();
        CreateMap<AttributeSelectList, AttributeSelectListDto>();
        CreateMap<ClassSelectList, TextValuePairsDto>();
        CreateMap<ClassAbilityCreation, ClassAbilityCreationDto>();
        CreateMap<TextValuePairs, TextValuePairsDto>();
        CreateMap<ClassAbilityUpdate, ClassAbilityUpdateDto>();

    }
}
