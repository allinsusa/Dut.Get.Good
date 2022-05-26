using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Dut.Get.Good.GetGoodApplicationContracts.Attributes
{
    public interface IAttributesAppService : IApplicationService
    {
        Task<List<AttributeBasicInfoDto>> GetAllAttributes();
        Task<AttributeBasicInfoDto> GetAttributeById(Guid AttributeId);
        Task AddAttribute(NewAttributeDto AttributeModel);
    }
}
