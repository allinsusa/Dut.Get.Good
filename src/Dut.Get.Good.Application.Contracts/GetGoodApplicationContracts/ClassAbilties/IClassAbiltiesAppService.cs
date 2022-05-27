using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties
{
    public interface IClassAbiltiesAppService
    {
        Task AddNewClassAbility(NewClassAbilityDto ClassAbilty);
        Task<List<ClassAbilityBasicInfoDto>> GetAllClassAbilities();
        Task<ClassAbilityBasicInfoDto> GetClassAbilityById(Guid ClassAbilityId);
        Task<List<ClassAbilityBasicInfoDto>> GetAllClassAbilitiesByClassId(Guid ClassId);
        Task<ClassAbilityCreationDto> PopulateNewClassAbilityModel();

    }
}
