using Dut.Get.Good.GetGoodApplicationContracts.Races.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationContracts.Races
{
    public interface IRacesAppService
    {
        Task<List<RaceBasicInfoDto>> GetAllRaces();
        Task AddNewRace(NewRaceDto NewRace);
        Task<RaceBasicInfoDto> GetRaceById(Guid ClassAbilityId);
    }
}
