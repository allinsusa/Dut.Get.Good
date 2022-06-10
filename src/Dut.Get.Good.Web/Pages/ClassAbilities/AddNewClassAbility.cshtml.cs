using Dut.Get.Good.GetGoodApplicationContracts.Class.DTO;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.Web.ViewModels.ClassAbilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

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
            ObjectToCreate = new NewClassAbiltyViewModel();
            ObjectToCreate.AllClasses = ObjectMapper.Map<List<TextValuePairsDto>, List<TextValuePairViewModel>>(DtoObject.Classess) ;
            ObjectToCreate.AllAttribbutes = ObjectMapper.Map<List<TextValuePairsDto>, List<TextValuePairViewModel>>(DtoObject.Attributes);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var classAbiltyDto = ObjectMapper.Map<NewClassAbiltyViewModel, NewClassAbilityDto>(ObjectToCreate);
            await _classAbilitiesAppService.AddNewClassAbility(classAbiltyDto);
            return Redirect("~/ClassAbilities/Index");
        }
        
    }
}
