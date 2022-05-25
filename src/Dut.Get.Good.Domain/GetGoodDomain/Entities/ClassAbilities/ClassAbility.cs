using System;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities
{
    public class ClassAbility : Entity<Guid>
    {
        public Guid ClassId { get; set; }
        public Guid AttributeId { get; set; }
        public string AbilityDescription { get; set; }
    }
}
