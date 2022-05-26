using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities
{
    public class ClassAbilitiesFullDetails
    {
        public Guid ClassAbilityId { get; set; }
        public Guid ClassId { get; set; }
        public string ClassDescription { get; set; }
        public Guid AttributeId { get; set; }
        public string AttributeDescription { get; set; }    
    }
}
