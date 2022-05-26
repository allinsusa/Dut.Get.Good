using Dut.Get.Good.GetGoodApplicationContracts.Class;
using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationAppServices.Class
{
    public class ClassAppService : GoodAppService, IClassAppService
    {
        private readonly IClassRepository _classRepository;
        public ClassAppService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task AddNewClass(AddNewClassDto ClassAbilty)
        {
            var classEntity = ObjectMapper.Map<AddNewClassDto, AddNewClass>(ClassAbilty);
            await _classRepository.AddNewClass(classEntity);
        }

        public async Task<List<ClassBasicInfoDto>> GetAllClasses()
        {
            var allClasses = await _classRepository.GetAllClasses();
            return ObjectMapper.Map<List<ClassBasicInfo>,List<ClassBasicInfoDto>>(allClasses);
        }

        public async Task<ClassBasicInfoDto> GetClassById(Guid ClassId)
        {
            var classes = await _classRepository.GetClassById(ClassId);
            return ObjectMapper.Map<ClassBasicInfo, ClassBasicInfoDto>(classes);
        }
    }
}
