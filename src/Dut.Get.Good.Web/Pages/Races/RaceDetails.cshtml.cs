using Dut.Get.Good.GetGoodApplicationContracts.Races;
using Dut.Get.Good.GetGoodApplicationContracts.Races.DTO;
using Dut.Get.Good.Web.ViewModels.Races;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Races
{
    public class RaceDetailsModel : GoodPageModel
    {
        [BindProperty]
        public RaceBasicInfoViewModel ObjectToDisplay { get; set; }

        private readonly IRacesAppService _racesAppService;

        public RaceDetailsModel(IRacesAppService RacesAppServiceObj)
        {
            _racesAppService = RacesAppServiceObj;
        }
        public async Task OnGetAsync(Guid RaceId)
        {
            var DtoObject = await _racesAppService.GetRaceById(RaceId);
            ObjectToDisplay = ObjectMapper.Map<RaceBasicInfoDto, RaceBasicInfoViewModel>(DtoObject);
        }
    }
}
