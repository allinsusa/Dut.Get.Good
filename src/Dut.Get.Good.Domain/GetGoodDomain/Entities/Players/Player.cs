using System;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.Players
{
    public class Player : Entity<Guid>
    {
        public Guid PlayerRaceId { get; set; }
        public Guid PlayerClassId { get; set; }
        public Guid PlayerRankId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerMainWeapon { get; set; }
    }
}
