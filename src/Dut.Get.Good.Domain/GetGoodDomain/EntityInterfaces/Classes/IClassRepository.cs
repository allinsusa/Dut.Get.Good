using Dut.Get.Good.GetGoodDomain.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dut.Get.Good.GetGoodDomain.EntityInterfaces.Classes
{
    public interface IClassRepository
    {
        Task AddNewClass(AddNewClass ClassAbilty, CancellationToken cancellationToken = default);
        Task<List<ClassFullDetails>> GetAllClasses(CancellationToken cancellationToken = default);
        Task<ClassFullDetails> GetClassById(Guid ClassId, CancellationToken cancellationToken = default);
    }
}
