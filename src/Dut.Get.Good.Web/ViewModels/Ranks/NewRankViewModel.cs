using System.ComponentModel.DataAnnotations;

namespace Dut.Get.Good.Web.ViewModels.Ranks
{
    public class NewRankViewModel
    {
        [Required(ErrorMessage ="Rank Description Required")]
        public string RankDescription { get; set; }
    }
}
