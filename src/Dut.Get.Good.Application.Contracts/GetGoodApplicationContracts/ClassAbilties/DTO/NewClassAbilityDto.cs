using System;
using System.Collections.Generic;
using System.Text;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO
{
    public class NewClassAbilityDto
    {
        public Guid ClassId { get; set; }
        public Guid AttributeId { get; set; }
        public string AbilityDescription { get; set; }
    }
}
