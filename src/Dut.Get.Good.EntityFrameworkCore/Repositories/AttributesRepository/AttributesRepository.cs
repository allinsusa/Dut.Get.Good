using Dut.Get.Good.EntityFrameworkCore;
using Dut.Get.Good.GetGoodDomain.EntityInterfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Attribute = Dut.Get.Good.GetGoodDomain.Entities.Attributes.Attribute;

namespace Dut.Get.Good.Repositories.AttributesRepository
{
    public class AttributesRepository : EfCoreRepository<GoodDbContext, Attribute, Guid>, IAttributesRepository
    {
        public AttributesRepository(IDbContextProvider<GoodDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        }

        public Task<Attribute> AddAttribute(Attribute attributeModel, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        //public Task<Attribute> AddAttribute(Attribute attributeModel, CancellationToken cancellationToken = default)
        //{
        //    var parameters = new SqlParameter[]
        //     {
        //         new SqlParameter("@AttributeId",attributeId)
        //     };
        //    await DbConfigurations.Configurations.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
        //    using var command = DbConfigurations.Configurations.CreateCommand(await GetDbContextAsync(), "Attr_GetAttributeById", CommandType.StoredProcedure, parameters);
        //    using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
        //    return await dataReader.MapToObject<Attribute>(cancellationToken);
        //}

        public async Task<List<Attribute>> GetAllAttributes(CancellationToken cancellationToken = default)
        {
            await DbConfigurations.Configurations.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = DbConfigurations.Configurations.CreateCommand(await GetDbContextAsync(), "Attr_GetAllAttributes", CommandType.StoredProcedure);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToList<Attribute>(cancellationToken);
        }

        public async Task<Attribute> GetAttributeById(Guid attributeId, CancellationToken cancellationToken = default)
        {
            var parameters = new SqlParameter[]
             {
                 new SqlParameter("@AttributeId",attributeId)
             };
            await DbConfigurations.Configurations.EnsureConnectionOpenAsync(await GetDbContextAsync(), cancellationToken);
            using var command = DbConfigurations.Configurations.CreateCommand(await GetDbContextAsync(), "Attr_GetAttributeById", CommandType.StoredProcedure,parameters);
            using var dataReader = await command.ExecuteReaderAsync(cancellationToken);
            return await dataReader.MapToObject<Attribute>(cancellationToken);
        }
    }
}
