using Dut.Get.Good.GetGoodApplicationContracts.Attributes;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationAppServices.Attributes
{
    public class AttributesAppService : GoodAppService, IAttributesAppService
    {
        private readonly IAttributesRepository _attributesRepository;
        public AttributesAppService(IAttributesRepository attributesRepository)
        {
            _attributesRepository = attributesRepository;
        }

        public async Task AddAttribute(NewAttributeDto AttributeModel)
        {
            var DbModel = ObjectMapper.Map<NewAttributeDto, NewAttribute>(AttributeModel);
            await _attributesRepository.AddAttribute(DbModel);
        }

        public async Task<List<AttributeBasicInfoDto>> GetAllAttributes()
        {
           var ReturnResult = await _attributesRepository.GetAllAttributes();
           return ObjectMapper.Map<List<AttributeBasicInfo>, List<AttributeBasicInfoDto>>(ReturnResult);
        }

        public async Task<AttributeBasicInfoDto> GetAttributeById(Guid AttributeId)
        {
            var ReturnResult = await _attributesRepository.GetAttributeById(AttributeId);
            return ObjectMapper.Map<AttributeBasicInfo, AttributeBasicInfoDto>(ReturnResult);
        }
    }
}
