using Dut.Get.Good.GetGoodApplicationContracts.Ranks;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.Ranks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Ranks
{
    public class RankingDetailsModel : GoodPageModel
    {
        [BindProperty]
        public RankBasicInfoViewModel ObjectToDisplay { get; set; }

        private readonly IRanksAppService _ranksAppService;

        public RankingDetailsModel(IRanksAppService RanksAppServiceObj)
        {
            _ranksAppService = RanksAppServiceObj;
        }
        public async Task OnGetAsync(Guid RankingId)
        {
            var DtoObject = await _ranksAppService.GetRankByIdAsync(RankingId);
            ObjectToDisplay = ObjectMapper.Map<RankBasicInfoDto, RankBasicInfoViewModel>(DtoObject);
        }
    }
}
