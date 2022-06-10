using System;
using System.Collections.Generic;

namespace Dut.Get.Good.Web.ViewModels.ClassAbilities
{
    public class ClassAbilityUpdateViewModel
    {

        public ClassAbilityBasicInfoViewModel ClassAbilityBasicInfo { get; set; }
        public List<TextValuePairViewModel> AllClasses { get; set; }
        public List<TextValuePairViewModel> AllAttribbutes { get; set; }
    }
}
