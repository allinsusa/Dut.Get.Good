using Dut.Get.Good.GetGoodApplicationContracts.Races;
using Dut.Get.Good.GetGoodApplicationContracts.Races.DTO;
using Dut.Get.Good.GetGoodDomain.Entities.Races;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodApplicationAppServices.Races
{
    public class RacesAppService : GoodAppService, IRacesAppService
    {
        private readonly IRacesRepository _racesRepository;
        public RacesAppService(IRacesRepository racesRepository)
        {
            _racesRepository = racesRepository;
        }
        public async Task AddNewRace(NewRaceDto NewRace)
        {
            var DbModel = ObjectMapper.Map<NewRaceDto,NewRace>(NewRace);
            await _racesRepository.AddNewRace(DbModel);
        }

        public async Task<List<RaceBasicInfoDto>> GetAllRaces()
        {
            var ReturnResult = await _racesRepository.GetAllRaces();
            return ObjectMapper.Map<List<RacesBasicInfo>,List<RaceBasicInfoDto>>(ReturnResult);
        }

        public async Task<RaceBasicInfoDto> GetRaceById(Guid RaceId)
        {
            var ReturnResult = await _racesRepository.GetRaceById(RaceId);
            return ObjectMapper.Map<RacesBasicInfo, RaceBasicInfoDto>(ReturnResult);
        }
    }
}
