using Dut.Get.Good.GetGoodApplicationContracts.Attributes;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

namespace Dut.Get.Good.Web.Pages.Attributes
{
    public class AddNewAttributeModel : GoodPageModel
    {
        [BindProperty]
        public NewAttributeViewModel ObjectToCreate { get; set; }

        private readonly IAttributesAppService _attributesAppService;

        public AddNewAttributeModel(IAttributesAppService attributesAppService)
        {
            _attributesAppService = attributesAppService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var newAttributeDto = ObjectMapper.Map<NewAttributeViewModel, NewAttributeDto>(ObjectToCreate);
                await _attributesAppService.AddAttribute(newAttributeDto);
                return Redirect("~/Attributes");
            }
            return Page();
            
        }
    }
}
