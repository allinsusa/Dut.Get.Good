using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodDomain.EntityInterfaces.CallAbilities
{
    public interface IClassAbilitiesRepository
    {
        Task AddNewClassAbility(NewClassAbility ClassAbilty, CancellationToken cancellationToken = default);
        Task<List<ClassAbilityBasicInfo>> GetAllClassAbilities(CancellationToken cancellationToken = default);
        Task<ClassAbilityBasicInfo> GetClassAbilityById(Guid ClassAbilityId, CancellationToken cancellationToken = default);
        Task<List<ClassAbilityBasicInfo>> GetAllClassAbilitiesByClassId(Guid ClassId, CancellationToken cancellationToken = default);


    }
}
