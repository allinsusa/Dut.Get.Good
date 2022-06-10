using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using System.Collections.Generic;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO
{
    public class ClassAbilityCreationDto
    {
        public List<TextValuePairsDto> Attributes { get; set; }
        public List<TextValuePairsDto> Classess { get; set; }

        public ClassAbilityCreationDto()
        {
            Attributes = new List<TextValuePairsDto>();
            Classess = new List<TextValuePairsDto>();
        }
    }
}
