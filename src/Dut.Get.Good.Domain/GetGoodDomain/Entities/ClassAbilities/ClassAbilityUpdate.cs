using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities
{
    public class ClassAbilityUpdate
    {
        public ClassAbilityBasicInfo ClassAbilityBasicInfo { get; set; }
        public List<TextValuePairs> AllClasses { get; set; }
        public List<TextValuePairs> AllAttribbutes { get; set; }
    }
}
