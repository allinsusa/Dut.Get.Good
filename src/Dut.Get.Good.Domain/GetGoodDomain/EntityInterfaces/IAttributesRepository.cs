using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Dut.Get.Good.GetGoodDomain.Entities.Attributes;
using Attribute = Dut.Get.Good.GetGoodDomain.Entities.Attributes.Attribute;

namespace Dut.Get.Good.GetGoodDomain.EntityInterfaces
{
    public interface IAttributesRepository : IBasicRepository<Attribute, Guid>
    {
        Task<List<Attribute>> GetAllAttributes(CancellationToken cancellationToken = default);
        Task<Attribute> GetAttributeById(Guid attributeId, CancellationToken cancellationToken = default);
        Task<Attribute> AddAttribute(Attribute attributeModel, CancellationToken cancellationToken = default);
    }
}
