using System;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.Guilds
{
    public class Guild : Entity<Guid>
    {
        public Guid GuildRankingId { get; set; }
        public string GuildName { get; set; }
    }
}
