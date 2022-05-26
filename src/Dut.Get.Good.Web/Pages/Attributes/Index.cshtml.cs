using Dut.Get.Good.GetGoodApplicationContracts.Attributes;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Attributes
{
    public class IndexModel : GoodPageModel
    {
        [BindProperty]
        public IEnumerable<AttributeBasicInfoViewModel> ObjectToDisplay { get; set; }

        private readonly IAttributesAppService _attributesAppService;

        public IndexModel(IAttributesAppService attributesAppService)
        {
            _attributesAppService = attributesAppService;
        }
        public async Task OnGetAsync()
        {
            var DtoObject = await _attributesAppService.GetAllAttributes();
            ObjectToDisplay = ObjectMapper.Map<IEnumerable<AttributeBasicInfoDto>, IEnumerable<AttributeBasicInfoViewModel>>(DtoObject);
        }
    }
}
