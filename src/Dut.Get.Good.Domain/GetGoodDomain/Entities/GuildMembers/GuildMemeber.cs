using System;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.GuildMembers
{
    public class GuildMemeber : Entity<Guid>
    {
        public Guid GuildId { get; set; }
        public Guid PlayerId { get; set; }
        public Guid PlayerGuildRankingId { get; set; }
    }
}
