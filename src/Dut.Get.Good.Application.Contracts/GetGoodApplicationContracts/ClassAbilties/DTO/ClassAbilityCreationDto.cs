using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using System.Collections.Generic;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO
{
    public class ClassAbilityCreationDto
    {
        public List<AttributeBasicInfoDto> Attributes { get; set; }
        public List<ClassBasicInfoDto> Classess { get; set; }

        public ClassAbilityCreationDto()
        {
            Attributes = new List<AttributeBasicInfoDto>();
            Classess = new List<ClassBasicInfoDto>();
        }
    }
}
