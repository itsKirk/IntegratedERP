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
using Repository.Connections;

namespace Repository.Repositories
{
  public static class BankRepository
  {
    private const string CONNECTION = ConnectionString.Name;
    private static bool BanksLoaded { get; set; }
    public static async Task<bool> AddBank(Bank bank)
    {
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      var p = new DynamicParameters();
      p.Add("@Name", bank.Name);
      var rows = await connection.ExecuteAsync("insertBank", p, commandType: CommandType.StoredProcedure)
        .ConfigureAwait(false);
      return rows >= 1;
    }

    private static List<Bank> InitializeBanks() =>
      new()
      {
        new Bank(){Name = "Absa Bank Kenya"},
        new Bank(){Name = "Kenya Commercial Bank"},
        new Bank(){Name = "Equity Bank Ltd."},
        new Bank(){Name = "Co-operative Bank of Kenya"},
        new Bank(){Name = "Family Bank Ltd." },
        new Bank(){Name = "National Bank of Kenya Ltd." },
        new Bank(){Name = "Mwalimu National Sacco"},
        new Bank(){Name = "Consolidated Bank of Kenya Ltd." }
      };
    public static IEnumerable<Bank> GetBanks()
    {
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      var banks = connection.Query<Bank>("getBanks", commandType: CommandType.StoredProcedure).ToList();
      switch (Enumerable.Any(banks))
      {
        case false:
        {
          var p = new DynamicParameters();
          foreach (var readyBank in InitializeBanks())
          {
            p.Add("@Name", readyBank.Name);
            connection.Execute("insertBank", p, commandType: CommandType.StoredProcedure);
          }
          break;
        }
      }
      BanksLoaded = true;
      return banks;
    }
  }
}

