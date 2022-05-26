using Dut.Get.Good.GetGoodApplicationContracts.Attributes;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Attributes
{
    public class AttributeDetailsModel : GoodPageModel
    {
        [BindProperty]
        public AttributeBasicInfoViewModel ObjectToDisplay { get; set; }

        private readonly IAttributesAppService _attributesAppService;

        public AttributeDetailsModel(IAttributesAppService attributesAppService)
        {
            _attributesAppService = attributesAppService;
        }
        public async Task OnGetAsync(Guid AttributeId)
        {
            var DtoObject = await _attributesAppService.GetAttributeById(AttributeId);
            ObjectToDisplay = ObjectMapper.Map<AttributeBasicInfoDto, AttributeBasicInfoViewModel>(DtoObject);
        }
    }
}
