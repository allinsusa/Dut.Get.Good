using Dut.Get.Good.GetGoodDomain.Entities.ClassAbilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodDomain.EntityInterfaces.CallAbilities
{
    public interface ICallAbilitiesRepository
    {
        Task AddNewClassAbility(NewClassAbility ClassAbilty, CancellationToken cancellationToken = default);
        Task<List<ClassAbilitiesFullDetails>> GetAllClassAbilities(CancellationToken cancellationToken = default);
        Task<ClassAbilitiesFullDetails> GetAttributeById(Guid ClassAbilityId, CancellationToken cancellationToken = default);
        Task<List<ClassAbilitiesFullDetails>> GetAllClassAbilitiesByClassId(Guid ClassId, CancellationToken cancellationToken = default);


    }
}
