using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.Web.ViewModels.ClassAbilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ObjectToCreate.AllClasses = new List<SelectListItem>();
            ObjectToCreate.AllAttribbutes = new List<SelectListItem>();
            DtoObject.Classess.ForEach(obj =>
            {
                ObjectToCreate.AllClasses.Add(new SelectListItem()
                {
                    Text = obj.ClassDescription,
                    Value = obj.ClassId.ToString()
                });
            });
            DtoObject.Attributes.ForEach(obj =>
            {
                ObjectToCreate.AllAttribbutes.Add(new SelectListItem()
                {
                    Text = obj.AttributeDescription,
                    Value = obj.AttributeId.ToString()
                });
            });
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var classAbiltyDto = ObjectMapper.Map<NewClassAbiltyViewModel, NewClassAbilityDto>(ObjectToCreate);
            await _classAbilitiesAppService.AddNewClassAbility(classAbiltyDto);
            return Redirect("~/ClassAbilities/Index");
        }
    }
}
