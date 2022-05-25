using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.Attributes
{
    public class Attribute : Entity<Guid>
    {
        public string AttributeDescription { get; set; }
    }
}
