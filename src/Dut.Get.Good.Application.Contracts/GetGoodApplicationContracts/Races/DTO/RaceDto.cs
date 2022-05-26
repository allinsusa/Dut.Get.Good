using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Dut.Get.Good.GetGoodApplicationContracts.Races.DTO
{
    public class RaceDto : EntityDto<Guid>
    {
        public string RaceDescription { get; set; }
    }
}
