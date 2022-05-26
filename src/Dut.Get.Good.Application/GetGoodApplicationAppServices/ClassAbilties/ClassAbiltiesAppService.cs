using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.CallAbilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationAppServices.ClassAbilties
{
    public class ClassAbiltiesAppService : GoodAppService, IClassAbiltiesAppService
    {
        private readonly IClassAbilitiesRepository _callAbilitiesRepository;
        public ClassAbiltiesAppService(IClassAbilitiesRepository callAbilitiesRepository)
        {
            _callAbilitiesRepository = callAbilitiesRepository;
        }
        public async Task AddNewClassAbility(NewClassAbilityDto ClassAbilty)
        {
            var classAbilityEntity = ObjectMapper.Map<NewClassAbilityDto, NewClassAbility>(ClassAbilty);
            await _callAbilitiesRepository.AddNewClassAbility(classAbilityEntity);
        }

        public async Task<List<ClassAbilityBasicInfoDto>> GetAllClassAbilities()
        {
            var allClassAbilities = await _callAbilitiesRepository.GetAllClassAbilities();
            return ObjectMapper.Map<List<ClassAbilitiesBasicInfo>,List<ClassAbilityBasicInfoDto>>(allClassAbilities);
        }

        public async Task<List<ClassAbilityBasicInfoDto>> GetAllClassAbilitiesByClassId(Guid ClassId)
        {
            var allClassAbilities = await _callAbilitiesRepository.GetAllClassAbilitiesByClassId(ClassId);
            return ObjectMapper.Map<List<ClassAbilitiesBasicInfo>, List<ClassAbilityBasicInfoDto>>(allClassAbilities);
        }

        public async Task<ClassAbilityBasicInfoDto> GetAttributeById(Guid ClassAbilityId)
        {
            var classAbility = await _callAbilitiesRepository.GetClassAbilityById(ClassAbilityId);
            return ObjectMapper.Map<ClassAbilitiesBasicInfo, ClassAbilityBasicInfoDto>(classAbility);
        }
    }
}
