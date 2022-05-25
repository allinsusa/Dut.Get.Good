using System;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.Ranks
{
    public class Rank : Entity<Guid>
    {
        public string RankDescription { get; set; }
    }
}
