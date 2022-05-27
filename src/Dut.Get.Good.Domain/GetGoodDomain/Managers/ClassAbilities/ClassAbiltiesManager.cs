using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Classes;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Dut.Get.Good.GetGoodDomain.Managers.ClassAbilities
{
    public class ClassAbiltiesManager : DomainService
    {
        private readonly IAttributesRepository _attributesRepository;
        private readonly IClassRepository _classRepository;

        public ClassAbiltiesManager(IAttributesRepository AttributesRepositoryObj, IClassRepository ClassRepositoryObj)
        {
            _attributesRepository = AttributesRepositoryObj;
            _classRepository = ClassRepositoryObj;
        }

        public async Task<ClassAbilityCreation> PopulateNewClassAbilityModel()
        {
            var AttributeReturnResult = await _attributesRepository.GetAllAttributes();
            var ClassReturnResult = await _classRepository.GetAllClasses();

            return new ClassAbilityCreation
            {
                Attributes = AttributeReturnResult,
                Classess = ClassReturnResult
            };
        }

    }
}
