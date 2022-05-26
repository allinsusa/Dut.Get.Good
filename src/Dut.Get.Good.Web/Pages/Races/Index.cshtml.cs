using Dut.Get.Good.GetGoodApplicationContracts.Races;
using Dut.Get.Good.GetGoodApplicationContracts.Races.DTO;
using Dut.Get.Good.Web.ViewModels.Races;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Races
{
    public class IndexModel : GoodPageModel
    {
        [BindProperty]
        public IEnumerable<RaceBasicInfoViewModel> ObjectToDisplay { get; set; }

        private readonly IRacesAppService _racesAppService;

        public IndexModel(IRacesAppService RacesAppServiceObj)
        {
            _racesAppService = RacesAppServiceObj;
        }
        public async Task OnGetAsync()
        {
            var DtoObject = await _racesAppService.GetAllRaces();
            ObjectToDisplay = ObjectMapper.Map<IEnumerable<RaceBasicInfoDto>, IEnumerable<RaceBasicInfoViewModel>>(DtoObject);
        }
    }
}
