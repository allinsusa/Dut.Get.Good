using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Dut.Get.Good.GetGoodDomain.Managers.ClassAbilities
{
    public class ClassAbiltiesManager: DomainService
    {
        private readonly IAttributesRepository _attributesRepository;
        private readonly IClassRepository _classRepository;
        public ClassAbiltiesManager(IAttributesRepository attributesRepository, IClassRepository classRepository)
        {
            _attributesRepository = attributesRepository;
            _classRepository = classRepository;
        }
        public async Task<NewClassAbility> PopulateNewClassAbilityModel()
        {
            var newClassAbility = new NewClassAbility();
            var classSelect = new List<ClassSelectList>();
            var attributeSelect = new List<AttributeSelectList>();
            var attributesList = await _attributesRepository.GetAllAttributes();
            attributesList.ForEach(a => {
                attributeSelect.Add(new AttributeSelectList
                {
                    Text = a.AttributeDescription,
                    Value = a.AttributeId
                });
            });
            var allClasses = await _classRepository.GetAllClasses();
            allClasses.ForEach(a => {
                classSelect.Add(new ClassSelectList
                {
                    Text = a.ClassDescription,
                    Value = a.ClassId
                });
            });
            newClassAbility.AllClasses = classSelect;
            newClassAbility.AllAttributes = attributeSelect;
            return newClassAbility;
        }
      
    }
}
