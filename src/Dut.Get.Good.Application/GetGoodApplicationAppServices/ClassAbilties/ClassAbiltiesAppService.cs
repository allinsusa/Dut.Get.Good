using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.CallAbilities;
using System;
using System.Collections.Generic;
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
            var DbModel = ObjectMapper.Map<NewClassAbilityDto, NewClassAbility>(ClassAbilty);
            await _callAbilitiesRepository.AddNewClassAbility(DbModel);
        }

        public async Task<List<ClassAbilityBasicInfoDto>> GetAllClassAbilities()
        {
            var ReturnResult = await _callAbilitiesRepository.GetAllClassAbilities();
            return ObjectMapper.Map<List<ClassAbilityBasicInfo>,List<ClassAbilityBasicInfoDto>>(ReturnResult);
        }

        public async Task<List<ClassAbilityBasicInfoDto>> GetAllClassAbilitiesByClassId(Guid ClassId)
        {
            var ReturnResult = await _callAbilitiesRepository.GetAllClassAbilitiesByClassId(ClassId);
            return ObjectMapper.Map<List<ClassAbilityBasicInfo>, List<ClassAbilityBasicInfoDto>>(ReturnResult);
        }

        public async Task<ClassAbilityBasicInfoDto> GetClassAbilityById(Guid ClassAbilityId)
        {
            var ReturnResult = await _callAbilitiesRepository.GetClassAbilityById(ClassAbilityId);
            return ObjectMapper.Map<ClassAbilityBasicInfo, ClassAbilityBasicInfoDto>(ReturnResult);
        }
    }
}
