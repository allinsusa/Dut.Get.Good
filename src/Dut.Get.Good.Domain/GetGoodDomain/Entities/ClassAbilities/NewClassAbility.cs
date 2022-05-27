using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities
{
    public class NewClassAbility
    {
        public Guid ClassId { get; set; }
        public string AbilityDescription { get; set; }
        public List<ClassSelectList> AllClasses { get; set; }
        public Guid AttributeId { get; set; }
        public List<AttributeSelectList> AllAttributes { get; set; }
    }
}
