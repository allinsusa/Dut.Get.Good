using Dut.Get.Good.GetGoodDomain.Entities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodDomain.EntityInterfaces.Races
{
    public interface IRacesRepository
    {
        Task<List<RacesBasicInfo>> GetAllRaces(CancellationToken cancellationToken = default);
        Task AddNewRace(NewRace NewRace, CancellationToken cancellationToken = default);
        Task<RacesBasicInfo> GetRaceById(Guid ClassAbilityId, CancellationToken cancellationToken = default);
    }
}
