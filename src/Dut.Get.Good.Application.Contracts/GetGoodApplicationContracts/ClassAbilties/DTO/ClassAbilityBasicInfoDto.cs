using System;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO
{
    public class ClassAbilityBasicInfoDto
    {
        public Guid ClassAbilityId { get; set; }
        public Guid ClassId { get; set; }
        public string ClassDescription { get; set; }
        public Guid AttributeId { get; set; }
        public string AttributeDescription { get; set; }
        public string AbilityDescription { get; set; }
    }
}
