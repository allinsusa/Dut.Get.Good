using Dut.Get.Good.GetGoodApplicationContracts.Ranks;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.Ranks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Ranks
{
    public class IndexModel : GoodPageModel
    {
        [BindProperty]
        public IEnumerable<RankBasicInfoViewModel> ObjectToDisplay { get; set; }

        private readonly IRanksAppService _ranksAppService;

        public IndexModel(IRanksAppService RanksAppServiceObj)
        {
            _ranksAppService = RanksAppServiceObj;
        }
        public async Task OnGetAsync()
        {
            var DtoObject = await _ranksAppService.GetAllRanksAsync();
            ObjectToDisplay = ObjectMapper.Map<IEnumerable<RankBasicInfoDto>, IEnumerable<RankBasicInfoViewModel>>(DtoObject);
        }
    }
}
