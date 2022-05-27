using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.Web.ViewModels.ClassAbilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.ClassAbilities
{
    public class AddNewClassAbilityModel : GoodPageModel
    {
        [BindProperty]
        public NewClassAbiltyViewModel ObjectToCreate { get; set; }

        private readonly IClassAbiltiesAppService _classAbilitiesAppService;

        public AddNewClassAbilityModel(IClassAbiltiesAppService ClassAbilitiesAppServiceObj)
        {
            _classAbilitiesAppService = ClassAbilitiesAppServiceObj;
        }

        public async void OnGetAsync()
        {
            var DtoObject = await _classAbilitiesAppService.PopulateNewClassAbilityModel();
        }

        public async Task OnPostAsync()
        {
            var classAbiltyDto = ObjectMapper.Map<NewClassAbiltyViewModel, NewClassAbilityDto>(ObjectToCreate);
            await _classAbilitiesAppService.AddNewClassAbility(classAbiltyDto);
        }
    }
}
