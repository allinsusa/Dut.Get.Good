using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using System.Collections.Generic;

namespace Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities
{
    public class ClassAbilityCreation
    {
        public List<AttributeBasicInfo> Attributes { get; set; }
        public List<ClassBasicInfo> Classess { get; set; }

        public ClassAbilityCreation()
        { 
            Attributes = new List<AttributeBasicInfo>();
            Classess = new List<ClassBasicInfo>();
        }
    }
}
