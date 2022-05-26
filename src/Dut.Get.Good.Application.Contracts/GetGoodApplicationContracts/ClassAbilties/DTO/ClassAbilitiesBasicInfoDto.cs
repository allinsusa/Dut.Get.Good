using System;
using System.Collections.Generic;
using System.Text;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO
{
    public class ClassAbilitiesBasicInfoDto
    {
        public Guid ClassAbilityId { get; set; }
        public Guid ClassId { get; set; }
        public string ClassDescription { get; set; }
        public Guid AttributeId { get; set; }
        public string AttributeDescription { get; set; }
    }
}
