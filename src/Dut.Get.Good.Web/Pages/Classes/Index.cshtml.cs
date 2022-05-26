using Dut.Get.Good.GetGoodApplicationContracts.Class;
using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.Web.ViewModels.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Class
{
    public class IndexModel : GoodPageModel
    {
        [BindProperty]
        public IEnumerable<ClassBasicInfoViewModel> ObjectToDisplay { get; set; }

        private readonly IClassAppService _classAppService;

        public IndexModel(IClassAppService classAppService)
        {
            _classAppService = classAppService;
        }
        public async Task OnGetAsync()
        {
            var DtoObject = await _classAppService.GetAllClasses();
            ObjectToDisplay = ObjectMapper.Map<IEnumerable<ClassBasicInfoDto>, IEnumerable<ClassBasicInfoViewModel>>(DtoObject);
        }
    }
}
