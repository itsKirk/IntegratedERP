using Dapper;
using ERP.Core.Models;
using Repository.Repositories.Args;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Generics
{
  public static class ModelProcessor
  {
    public static async Task<T> Save<T>(T model, DynamicParameters p, string connectionString, string sqlQuery) where T : class
    {
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(connectionString));
      await connection.ExecuteAsync(sqlQuery, p, commandType: CommandType.StoredProcedure)
        .ConfigureAwait(false);
      p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
      return model;
    }
  }
}

