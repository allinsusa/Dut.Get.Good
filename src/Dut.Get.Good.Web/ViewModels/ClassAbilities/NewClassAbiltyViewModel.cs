using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dut.Get.Good.Web.ViewModels.ClassAbilities
{
    public class NewClassAbiltyViewModel
    {
        [Display(Name = "Abilty Description")]
        [Required(ErrorMessage ="Ability Required")]
        public string AbilityDescription { get; set; }

        [Required(ErrorMessage ="Select Class")]
        [DisplayName("Class")]
        public Guid ClassId { get; set; }

        [Required(ErrorMessage = "Select Attribute")]
        [DisplayName("Attribute")]
        public Guid AttributeId { get; set; }


    }
}
