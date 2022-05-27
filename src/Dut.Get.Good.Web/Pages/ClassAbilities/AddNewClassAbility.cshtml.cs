using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties;
using Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO;
using Dut.Get.Good.Web.ViewModels.ClassAbilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public List<SelectListItem> ClassSelectItem { get; set; }
        public List<SelectListItem> AttributeSelectItem { get; set; }
        private readonly IClassAbiltiesAppService _classAbilitiesAppService;

        public AddNewClassAbilityModel(IClassAbiltiesAppService ClassAbilitiesAppServiceObj)
        {
            _classAbilitiesAppService = ClassAbilitiesAppServiceObj;
        }
        public async void OnGetAsync()
        {
            var classAbiltyDto = await _classAbilitiesAppService.PopulateNewClassAbilityModel();
            ObjectToCreate = ObjectMapper.Map<NewClassAbilityDto, NewClassAbiltyViewModel >(classAbiltyDto);

            AttributeSelectItem = new List<SelectListItem>();
            ObjectToCreate.AllAttributes.ForEach(attribute => 
            {
                AttributeSelectItem.Add(new SelectListItem { Text = attribute.Text, Value = attribute.Value.ToString() });  
            });
            ClassSelectItem = new List<SelectListItem>();
            ObjectToCreate.AllClasses.ForEach(Class => 
            {
                ClassSelectItem.Add(new SelectListItem { Text = Class.Text, Value = Class.Value.ToString() }); ; 
            });

        }
        public async Task OnPostAsync()
        {
            var classAbiltyDto = ObjectMapper.Map<NewClassAbiltyViewModel, NewClassAbilityDto>(ObjectToCreate);
            await _classAbilitiesAppService.AddNewClassAbility(classAbiltyDto);
        }
    }
}
