using Dut.Get.Good.GetGoodApplicationContracts.Attributes.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO
{
    public class NewClassAbilityDto
    {
        public Guid ClassId { get; set; }
        public string AbilityDescription { get; set; }
        public List<ClassSelectListDto> AllClasses { get; set; }
        public Guid AttributeId { get; set; }
        public List<AttributeSelectListDto> AllAttributes { get; set; }
    }
}
