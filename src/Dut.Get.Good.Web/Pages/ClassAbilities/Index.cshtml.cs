using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.Web.ViewModels.ClassAbilities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.ClassAbilities
{
    public class IndexModel : GoodPageModel
    {
        [BindProperty]
        public IEnumerable<ClassAbilityBasicInfoViewModel> ObjectToDisplay { get; set; }

        private readonly IClassAbiltiesAppService _classAbilitiesAppService;

        public IndexModel(IClassAbiltiesAppService ClassAbilitiesAppServiceObj)
        {
            _classAbilitiesAppService = ClassAbilitiesAppServiceObj;
        }
        public async Task OnGetAsync()
        {
            var DtoObject = await _classAbilitiesAppService.GetAllClassAbilities();
            ObjectToDisplay = ObjectMapper.Map<IEnumerable<ClassAbilityBasicInfoDto>, IEnumerable<ClassAbilityBasicInfoViewModel>>(DtoObject);
        }
    }
}
