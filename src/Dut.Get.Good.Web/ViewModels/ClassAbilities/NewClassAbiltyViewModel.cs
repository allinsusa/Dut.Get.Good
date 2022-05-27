using Dut.Get.Good.Web.ViewModels.Attributes;
using Dut.Get.Good.Web.ViewModels.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dut.Get.Good.Web.ViewModels.ClassAbilities
{
    public class NewClassAbiltyViewModel
    {
        [Display(Name = "Abilty Description")]
        public string AbilityDescription { get; set; }
        public Guid ClassId { get; set; }
        public List<ClassSelectListViewModel> AllClasses { get; set; }
        public Guid AttributeId { get; set; }
        public List<AttributeSelectListViewModel> AllAttributes { get; set; }
    }
}
