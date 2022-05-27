using Dut.Get.Good.GetGoodApplicationContracts.Class;
using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.Web.ViewModels.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Classes
{
    public class AddNewClassModel : GoodPageModel
    {
        [BindProperty]
        public AddNewClassViewModel ObjectToCreate { get; set; }
        private readonly IClassAppService _classAppService;

        public AddNewClassModel(IClassAppService ClassAppServiceObj)
        {
            _classAppService = ClassAppServiceObj;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var DtoObject = ObjectMapper.Map<AddNewClassViewModel, AddNewClassDto>(ObjectToCreate);
            await _classAppService.AddNewClass(DtoObject);
            return Redirect("~/Classes/Index");
        }
    }
}
