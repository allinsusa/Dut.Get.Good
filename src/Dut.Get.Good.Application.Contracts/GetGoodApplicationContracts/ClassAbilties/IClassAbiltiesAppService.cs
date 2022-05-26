using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties
{
    public interface IClassAbiltiesAppService
    {
        Task AddNewClassAbility(NewClassAbilityDto ClassAbilty);
        Task<List<ClassAbilitiesBasicInfoDto>> GetAllClassAbilities();
        Task<ClassAbilitiesBasicInfoDto> GetAttributeById(Guid ClassAbilityId);
        Task<List<ClassAbilitiesBasicInfoDto>> GetAllClassAbilitiesByClassId(Guid ClassId);

    }
}
