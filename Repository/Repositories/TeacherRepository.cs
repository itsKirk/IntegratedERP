using Dapper;
using ERP.Core.Models;
using Repository.Connections;
using Repository.Repositories.Args;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repositories
{
  /// <summary>
  /// Manages all things Teachers in the ERP
  /// </summary>
  public static class TeacherRepository
  {
    private const string CONNECTION = ConnectionString.Name;
#nullable enable
    public static event EventHandler<TeacherArgs>? TeacherAdded;
    /// <summary>
    /// retrieves all teachers in the system
    /// </summary>
    /// <returns>a list of teachers</returns>
    public static IEnumerable<Teacher> GetAllTeachers()
    {
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      var teacherList = connection.Query<Teacher>("getTeachers", commandType: CommandType.StoredProcedure).ToList();
      var p = new DynamicParameters();
      foreach (var item in teacherList)
      {
        p.Add("@TeacherId", item.Id);
        item.Contact = connection.QueryFirst<Contact>("getTeacherContacts", p, commandType: CommandType.StoredProcedure);
      }
      return teacherList;
    }
    /// <summary>
    /// adds a new teacher to the ERP system
    /// </summary>
    /// <param name="teacher">teacher to be added</param>
    /// <returns>a copy of the newly added teacher</returns>
    public static async Task<Teacher> AddTeacher(Teacher teacher)
    {
      var success = false;
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      var p = new DynamicParameters();
      p.Add("@FirstName", teacher.FirstName);
      p.Add("@MiddleName", teacher.MiddleName);
      p.Add("@LastName", teacher.LastName);
      p.Add("@RegistrationNumber", teacher.RegistrationNumber);
      p.Add("@HudumaNumber", teacher.HudumaNumber);
      p.Add("@EmployerName", teacher.EmployerName);
      p.Add("@StaffNumber", teacher.StaffNumber);
      p.Add("@EducationLevel", teacher.EducationLevel);
      p.Add("@IdNumber", teacher.IdNumber);
      p.Add("@BankName", teacher.BankName);
      p.Add("@PINNumber", teacher.PINNumber);
      p.Add("@AccountNumber", teacher.AccountNumber);
      p.Add("@EmailAddress", teacher.Contact.EmailAddress);
      p.Add("@PhysicalAddress", teacher.Contact.PhysicalAddress);
      p.Add("@Town", teacher.Contact.Town);
      p.Add("@PhoneNumber1", teacher.Contact.PhoneNumbers[0]);
      p.Add("@PhoneNumber2", teacher.Contact.PhoneNumbers[1]);
      await connection.ExecuteAsync("insertTeacher", p, commandType: CommandType.StoredProcedure)
        .ConfigureAwait(false);
      p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
      teacher.Id = p.Get<int>("@Id");
      success = true;
      if (success)
      {
        const string? response = "teacher added successfully";
        TeacherAdded?.Invoke(null, new TeacherArgs(response));
        return teacher;
      }
      else
      {
        const string? response = "error registering teacher. try again";
        TeacherAdded?.Invoke(null, new TeacherArgs(response));
        return teacher;
      }

    }
  }
}
