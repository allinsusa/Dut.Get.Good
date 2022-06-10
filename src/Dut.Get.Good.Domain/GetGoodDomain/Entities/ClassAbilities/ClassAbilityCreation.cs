using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using System.Collections.Generic;

namespace Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities
{
    public class ClassAbilityCreation
    {
        public List<TextValuePairs> Attributes { get; set; }
        public List<TextValuePairs> Classess { get; set; }

        public ClassAbilityCreation()
        { 
            Attributes = new List<TextValuePairs>();
            Classess = new List<TextValuePairs>();
        }
    }
}
