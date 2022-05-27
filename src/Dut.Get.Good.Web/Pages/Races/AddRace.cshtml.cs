using Dut.Get.Good.GetGoodApplicationContracts.Races;
using Dut.Get.Good.GetGoodApplicationContracts.Races.DTO;
using Dut.Get.Good.Web.ViewModels.Races;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Races
{
    public class AddRaceModel :  GoodPageModel
    {
    [BindProperty]
    public NewRaceViewModel ObjectToCreate { get; set; }
    private readonly IRacesAppService _raceAppService;

    public AddRaceModel(IRacesAppService RaceAppServiceObj)
    {
            _raceAppService = RaceAppServiceObj;
    }

    public void OnGet()
    {
    }
    public async Task<IActionResult> OnPostAsync()
    {
        var DtoObject = ObjectMapper.Map<NewRaceViewModel, NewRaceDto>(ObjectToCreate);
        await _raceAppService.AddNewRace(DtoObject);
        return Redirect("~/Races/Index");
    }
}
}
