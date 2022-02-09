using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace IntegratedERP
{
  public static class ContainerConfiguration
  {
    public static IContainer Configure()
    {
      var builder = new ContainerBuilder();
      builder.RegisterAssemblyTypes(Assembly.Load(nameof(Repository)))
        .Where(x => x.Namespace.Contains("Repositories"))
        .As(x => x.GetInterfaces().FirstOrDefault(t => t.Name == "I" + t.Name));
      return builder.Build();
    }
  }
}
