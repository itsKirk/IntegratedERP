using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Args
{
  public class SubjectArgs : EventArgs
  {
    public string SaveReport { get; private set; }
    public SubjectArgs(string saveReport)
    {
      SaveReport = saveReport;
    }
  }
}
