using System;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.Races
{
    public class Race : Entity<Guid>
    {
        public string RaceDescription { get; set; }
    }
}
