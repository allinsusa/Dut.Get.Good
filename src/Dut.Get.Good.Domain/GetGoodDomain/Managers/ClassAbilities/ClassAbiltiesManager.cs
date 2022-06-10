using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.CallAbilities;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Dut.Get.Good.GetGoodDomain.Managers.ClassAbilities
{
    public class ClassAbiltiesManager : DomainService
    {
        private readonly IAttributesRepository _attributesRepository;
        private readonly IClassRepository _classRepository;
        private readonly IClassAbilitiesRepository _classAbilitiesRepository;
        public ClassAbiltiesManager(IAttributesRepository AttributesRepositoryObj, IClassRepository ClassRepositoryObj, IClassAbilitiesRepository ClassAbilitiesRepositoryObj)
        {
            _attributesRepository = AttributesRepositoryObj;
            _classRepository = ClassRepositoryObj;
            _classAbilitiesRepository = ClassAbilitiesRepositoryObj;
        }

        public async Task<ClassAbilityCreation> PopulateNewClassAbilityModel()
        {
            var AttributeReturnResult = await _attributesRepository.GetAllAttributes();
            
            var ClassReturnResult = await _classRepository.GetAllClasses();

            return new ClassAbilityCreation
            {
                Attributes = PopulateAttributeTextValuePairs(AttributeReturnResult),
                Classess = PopulateClassTextValuePairs(ClassReturnResult)
            };
        }
        public List<TextValuePairs> PopulateAttributeTextValuePairs(List<AttributeBasicInfo> AttributeReturnResult)
        {
            var AttributeTextValuePairs = new List<TextValuePairs>();
            if (AttributeReturnResult.Count > 0)
            {
                foreach (var attribute in AttributeReturnResult)
                {
                    AttributeTextValuePairs.Add(new TextValuePairs() { Text = attribute.AttributeDescription, Value = attribute.AttributeId });
                }
            }
            return AttributeTextValuePairs;
        }
        public List<TextValuePairs> PopulateClassTextValuePairs(List<ClassBasicInfo> ClassReturnResult)
        {
            var AttributeTextValuePairs = new List<TextValuePairs>();
            if (ClassReturnResult.Count > 0)
            {
                foreach (var attribute in ClassReturnResult)
                {
                    AttributeTextValuePairs.Add(new TextValuePairs() { Text = attribute.ClassDescription, Value = attribute.ClassId });
                }
            }
            return AttributeTextValuePairs;
        }

        public async Task<ClassAbilityUpdate> GetUpdateClassAbilityById(Guid ClassAbilityId)
        {
            var ReturnResult = await _classAbilitiesRepository.GetClassAbilityById(ClassAbilityId);
            var dropdownLists = await PopulateNewClassAbilityModel();

            return new ClassAbilityUpdate()
            {
                ClassAbilityBasicInfo = ReturnResult,
                AllClasses = dropdownLists.Classess,
                AllAttribbutes = dropdownLists.Attributes
            };
           
        }
    }
}
