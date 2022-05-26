using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationContracts.Class
{
    public interface IClassAppService
    {
        Task AddNewClass(AddNewClassDto ClassAbilty);
        Task<List<ClassBasicInfoDto>> GetAllClasses();
        Task<ClassBasicInfoDto> GetClassById(Guid ClassId);
    }
}
