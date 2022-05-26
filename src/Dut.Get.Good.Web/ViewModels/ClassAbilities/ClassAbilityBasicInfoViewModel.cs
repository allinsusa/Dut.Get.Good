using System;

namespace Dut.Get.Good.Web.ViewModels.ClassAbilities
{
    public class ClassAbilityBasicInfoViewModel
    {
        public Guid ClassAbilityId { get; set; }
        public Guid ClassId { get; set; }
        public string ClassDescription { get; set; }
        public Guid AttributeId { get; set; }
        public string AttributeDescription { get; set; }
        public string AbilityDescription { get; set; }
    }
}
