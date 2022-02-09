using ERP.Core.Models;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Connections
{
  public static class InitializeData
  {
    public static Tuple
      <
        List<Subject>,
        List<Bank>,
        List<Teacher>
      >
      Initialize() =>
      new(
      GetSubjects(),
      GetBanks(),
      GetTeachers()
      );
    private static List<Teacher> GetTeachers() => TeacherRepository.GetAllTeachers().ToList();

    private static List<Subject> GetSubjects() => SubjectRepository.GetAllSubjects().ToList();
    private static List<Bank> GetBanks() => BankRepository.GetBanks().ToList();


  }
}
