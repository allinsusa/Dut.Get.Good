using Dut.Get.Good.GetGoodApplicationContracts.Class;
using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.Web.ViewModels.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Class
{
    public class ClassBasicInfoDetailsModel : GoodPageModel
    {
        [BindProperty]
        public ClassBasicInfoViewModel ObjectToDisplay { get; set; }

        private readonly IClassAppService _classAppService;

        public ClassBasicInfoDetailsModel(IClassAppService classAppService)
        {
            _classAppService = classAppService;
        }
        public async Task OnGetAsync(Guid ClassId)
        {
            var DtoObject = await _classAppService.GetClassById(ClassId);
            ObjectToDisplay = ObjectMapper.Map<ClassBasicInfoDto, ClassBasicInfoViewModel>(DtoObject);
        }
    }
}

