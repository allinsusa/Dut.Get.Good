using Dut.Get.Good.GetGoodApplicationContracts.Ranks;
using Dut.Get.Good.GetGoodApplicationContracts.Ranks.DTO;
using Dut.Get.Good.Web.ViewModels.Ranks;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dut.Get.Good.Web.Pages.Ranks
{
    [ValidateAntiForgeryToken]
    public class AddRankModel : GoodPageModel
    {
        [BindProperty]
        public NewRankViewModel ObjectToCreate { get; set; }
        private readonly IRanksAppService _ranksAppService;

        public AddRankModel(IRanksAppService RanksAppServiceObj)
        {
            _ranksAppService = RanksAppServiceObj;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var DtoObject = ObjectMapper.Map<NewRankViewModel, NewRankDto>(ObjectToCreate);
            await _ranksAppService.AddNewRankAsync(DtoObject);
            return RedirectToPage("/Ranks/Index");
        }
    }
}
