using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.Web.ViewModels.ClassAbilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.ClassAbilities
{
    public class ClassAbilityDetailsModel : GoodPageModel
    {
        [BindProperty]
        public ClassAbilityBasicInfoViewModel ObjectToDisplay { get; set; }

        private readonly IClassAbiltiesAppService _classAbilitiesAppService;

        public ClassAbilityDetailsModel(IClassAbiltiesAppService ClassAbilitiesAppServiceObj)
        {
            _classAbilitiesAppService = ClassAbilitiesAppServiceObj;
        }
        public async Task OnGetAsync(Guid ClassAbilityId)
        {
            var DtoObject = await _classAbilitiesAppService.GetClassAbilityById(ClassAbilityId);
            ObjectToDisplay = ObjectMapper.Map<ClassAbilityBasicInfoDto, ClassAbilityBasicInfoViewModel>(DtoObject);
        }
    }
}
