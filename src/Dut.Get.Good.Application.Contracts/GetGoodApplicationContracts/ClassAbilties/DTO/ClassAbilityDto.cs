using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Dut.Get.Good.GetGoodApplicationContracts.ClassAbilties.DTO
{
    public class ClassAbilityDto : EntityDto<Guid>
    {
        public Guid ClassId { get; set; }
        public Guid AttributeId { get; set; }
        public string AbilityDescription { get; set; }
    }
}
