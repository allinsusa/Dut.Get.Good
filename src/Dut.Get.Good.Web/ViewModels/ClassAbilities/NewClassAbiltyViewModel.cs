using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Dut.Get.Good.Web.Pages.ClassAbilities.AddNewClassAbilityModel;

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

        [NotMapped]
        public List<TextValuePairViewModel> AllClasses { get; set; }
        [NotMapped]
        public List<TextValuePairViewModel> AllAttribbutes { get; set; }
    }
}
