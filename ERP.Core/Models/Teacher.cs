using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Models
{
  public class Teacher
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string RegistrationNumber { get; set; }
    public string HudumaNumber { get; set; }
    public string EmployerName { get; set; }
    public string StaffNumber { get; set; }
    public string EducationLevel { get; set; }
    public string IdNumber { get; set; }
    public string PINNumber { get; set; }
    public string BankName { get; set; }
    public string AccountNumber { get; set; }
    public Contact Contact { get; set; }
  }
}
