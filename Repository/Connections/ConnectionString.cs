using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Connections
{
  public static class ConnectionString
  {
    public const string Name = "ERPDB";
    public static string GetString(string name)
    {
      return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }

  }
}
