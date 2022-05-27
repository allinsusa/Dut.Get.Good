using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.CallAbilities;
using Dut.Get.Good.GetGoodDomain.Managers.ClassAbilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationAppServices.ClassAbilties
{
    public class ClassAbiltiesAppService : GoodAppService, IClassAbiltiesAppService
    {
        private readonly ClassAbiltiesManager _classAbiltiesManager;
        private readonly IClassAbilitiesRepository _callAbilitiesRepository;
        public ClassAbiltiesAppService(IClassAbilitiesRepository callAbilitiesRepository, ClassAbiltiesManager classAbiltiesManager)
        {
            _callAbilitiesRepository = callAbilitiesRepository;
            _classAbiltiesManager = classAbiltiesManager;
        }
        public async Task AddNewClassAbility(NewClassAbilityDto ClassAbilty)
        {
            var Model = ObjectMapper.Map<NewClassAbilityDto, NewClassAbility>(ClassAbilty);
            await _callAbilitiesRepository.AddNewClassAbility(Model);
        }

        public async Task<List<ClassAbilityBasicInfoDto>> GetAllClassAbilities()
        {
            var DbModel = await _callAbilitiesRepository.GetAllClassAbilities();
            return ObjectMapper.Map<List<ClassAbilityBasicInfo>,List<ClassAbilityBasicInfoDto>>(DbModel);
        }

        public async Task<List<ClassAbilityBasicInfoDto>> GetAllClassAbilitiesByClassId(Guid ClassId)
        {
            var DbModel = await _callAbilitiesRepository.GetAllClassAbilitiesByClassId(ClassId);
            return ObjectMapper.Map<List<ClassAbilityBasicInfo>, List<ClassAbilityBasicInfoDto>>(DbModel);
        }

        public async Task<ClassAbilityBasicInfoDto> GetClassAbilityById(Guid ClassAbilityId)
        {
            var DbModel = await _callAbilitiesRepository.GetClassAbilityById(ClassAbilityId);
            return ObjectMapper.Map<ClassAbilityBasicInfo, ClassAbilityBasicInfoDto>(DbModel);
        }

        public async Task<NewClassAbilityDto> PopulateNewClassAbilityModel()
        {
           var DbModel = await _classAbiltiesManager.PopulateNewClassAbilityModel();
            return ObjectMapper.Map<NewClassAbility, NewClassAbilityDto>(DbModel);
        }
    }
}
