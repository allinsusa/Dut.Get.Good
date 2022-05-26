using System;

namespace Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities
{
    public class ClassAbilityBasicInfo
    {
        public Guid ClassAbilityId { get; set; }
        public Guid ClassId { get; set; }
        public string ClassDescription { get; set; }
        public Guid AttributeId { get; set; }
        public string AttributeDescription { get; set; }
        public string AbilityDescription { get; set; }
    }
}
