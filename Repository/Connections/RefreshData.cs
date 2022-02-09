using ERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Repositories;

namespace Repository.Connections
{
  public static class RefreshData
  {
    public static IEnumerable<Teacher> RefreshTeachers() => TeacherRepository.GetAllTeachers().ToList();
    public static IEnumerable<Subject> RefreshSubjects() => SubjectRepository.GetAllSubjects().ToList();
    public static IEnumerable<Bank> RefreshBanks() => BankRepository.GetBanks().ToList();

  }
}
