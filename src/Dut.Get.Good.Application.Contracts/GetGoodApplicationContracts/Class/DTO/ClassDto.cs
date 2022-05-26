using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Dut.Get.Good.GetGoodApplicationContracts.Class.DTO
{
    public class ClassDto : EntityDto<Guid>
    {
        public string ClassDescription { get; set; }
    }
}
