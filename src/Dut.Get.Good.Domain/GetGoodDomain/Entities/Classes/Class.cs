using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Dut.Get.Good.GetGoodDomain.Entities.Classes
{
    public class Class : Entity<Guid>
    {
        public string ClassDescription { get; set; }
    }
}
