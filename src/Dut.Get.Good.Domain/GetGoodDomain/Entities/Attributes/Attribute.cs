using System;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.Attributes
{
    public class Attribute : Entity<Guid>
    {
        public string AttributeDescription { get; set; }
    }
}
