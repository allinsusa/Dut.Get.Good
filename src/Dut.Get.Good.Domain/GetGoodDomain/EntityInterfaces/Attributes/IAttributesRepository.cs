using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Attribute = Dut.Get.Good.GetGoodDomain.Entities.Attributes.Attribute;

namespace Dut.Get.Good.GetGoodDomain.EntityInterfaces
{
    public interface IAttributesRepository : IBasicRepository<Attribute, Guid>
    {
        Task<List<AttributeBasicInfo>> GetAllAttributes(CancellationToken cancellationToken = default);
        Task<AttributeBasicInfo> GetAttributeById(Guid AttributeId, CancellationToken cancellationToken = default);
        Task AddAttribute(NewAttribute AttributeModel, CancellationToken cancellationToken = default);
    }
}
