using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO
{
    public class ClassAbilityUpdateDto
    {
        public ClassAbilityBasicInfoDto ClassAbilityBasicInfo { get; set; }
        public List<TextValuePairsDto> AllClasses { get; set; }
        public List<TextValuePairsDto> AllAttribbutes { get; set; }
    }
}
