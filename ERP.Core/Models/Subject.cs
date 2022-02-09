using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Models
{
  public class Subject
  {
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public bool IsExaminable { get; set; }
    public string ColorBytes { get; set; }
  }
}
