using System;
using System.ComponentModel.DataAnnotations;

namespace Dut.Get.Good.Web.ViewModels.Attributes
{
    public class NewAttributeViewModel
    {
        [Display(Name = "Attribute Description")]
        public string AttributeDescription { get; set; }

    }
}
