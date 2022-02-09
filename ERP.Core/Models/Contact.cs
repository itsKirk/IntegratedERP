using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Models
{
  public class Contact
  {
    public string EmailAddress { get; set; }
    public string PhysicalAddress { get; set; }
    public string Town { get; set; }
    public List<string> PhoneNumbers { get; set; } = new List<string>();
    private string PhoneNumber1 { get; }
    private string PhoneNumber2 { get; }

    public Contact()
    {
      PhoneNumbers.Add(PhoneNumber1);
      PhoneNumbers.Add(PhoneNumber2);
    }
  }
}
