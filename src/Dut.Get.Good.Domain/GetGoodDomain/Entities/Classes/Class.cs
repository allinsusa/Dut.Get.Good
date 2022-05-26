using System;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.Classes
{
    public class Class : Entity<Guid>
    {
        public string ClassDescription { get; set; }
    }
}
