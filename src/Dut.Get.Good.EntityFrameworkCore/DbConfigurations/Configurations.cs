using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dut.Get.Good.DbConfigurations
{
    public class Configurations
    {
        public static DbCommand CreateCommand(DbContext dbContext, string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            var command = dbContext.Database.GetDbConnection().CreateCommand();

            command.CommandText = commandText;
            command.CommandType = commandType;
            command.Transaction = dbContext.Database.CurrentTransaction?.GetDbTransaction();

            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command;
        }
        public static async Task EnsureConnectionOpenAsync(DbContext dbContext, CancellationToken cancellationToken = default)
        {
            var connection = dbContext.Database.GetDbConnection();

            if (connection.State != ConnectionState.Open)
            {
                await connection.OpenAsync(cancellationToken);
            }
            dbContext.Database.SetCommandTimeout(0);

        }
    }
}
