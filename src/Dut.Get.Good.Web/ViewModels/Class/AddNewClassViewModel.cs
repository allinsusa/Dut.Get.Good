using System.ComponentModel.DataAnnotations;

namespace Dut.Get.Good.Web.ViewModels.Class
{
    public class AddNewClassViewModel
    {
        [Display(Name = "Class Description")]
        public string ClassDescription { get; set; }
    }
}
