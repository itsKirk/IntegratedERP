using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Core.Models;

namespace IntegratedERP.Blueprints
{
  public interface ISubjectLoader
  {
    Subject LoadSubject();
    void UpdateBindings();
  }
}
