using Dut.Get.Good.GetGoodApplicationContracts.Attributes;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var attributeEntity = ObjectMapper.Map<NewAttributeDto, NewAttribute>(AttributeModel);
            await _attributesRepository.AddAttribute(attributeEntity);
        }
        public async Task<List<AttributeBasicInfoDto>> GetAllAttributes()
        {
           var allAttributes = await _attributesRepository.GetAllAttributes();
           return ObjectMapper.Map<List<AttributeBasicInfo>, List<AttributeBasicInfoDto>>(allAttributes);

        }
        public async Task<AttributeBasicInfoDto> GetAttributeById(Guid AttributeId)
        {
            var allAttributes = await _attributesRepository.GetAttributeById(AttributeId);
            return ObjectMapper.Map<AttributeBasicInfo, AttributeBasicInfoDto>(allAttributes);
        }
    }
}
