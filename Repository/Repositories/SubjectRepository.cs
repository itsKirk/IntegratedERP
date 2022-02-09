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
  /// Manages all things Subjects in the ERP.
  /// </summary>
  public static class SubjectRepository
  {
    private const string CONNECTION = ConnectionString.Name;
#nullable enable
    public static event EventHandler<SubjectArgs>? SubjectAdded;

    /// <summary>
    /// retrieves all registered subjects in the system
    /// </summary>
    /// <returns>a list of subjects</returns>
    public static IEnumerable<Subject> GetAllSubjects()
    {
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      return connection.Query<Subject>("getSubjects", commandType: CommandType.StoredProcedure).ToList();
    }

    /// <summary>
    /// adds a new subject to the ERP system
    /// </summary>
    /// <param name="subject">subject to be added</param>
    /// <returns>a copy of the newly added subject</returns>
    public static async Task<Subject> AddSubject(Subject subject)
    {
      var success = false;
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      var p = new DynamicParameters();
      p.Add("@Name", subject.Name);
      p.Add("@Code", subject.Code);
      p.Add("@IsExaminable", subject.IsExaminable);
      p.Add("@ColorBytes", subject.ColorBytes);
      await connection.ExecuteAsync("insertSubject", p, commandType: CommandType.StoredProcedure)
        .ConfigureAwait(false);
      p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
      subject.Id = p.Get<int>("@Id");
      success = true;
      if (success)
      {
        const string? response = "Subject added successfully";
        SubjectAdded?.Invoke(null, new SubjectArgs(response));
        return subject;
      }
      else
      {
        const string? response = "Subject added successfully";
        SubjectAdded?.Invoke(null, new SubjectArgs(response));
        return subject;
      }

    }
    /// <summary>
    /// edits an existing subject in the system
    /// </summary>
    /// <param name="subject">subject being edited</param>
    /// <returns>the edited subject</returns>
    public static async Task<Subject> EditSubject(Subject subject)
    {
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      var p = new DynamicParameters();
      p.Add("@Name", subject.Name);
      p.Add("@Code", subject.Code);
      p.Add("@IsExaminable", subject.IsExaminable);
      p.Add("@ColorBytes", subject.ColorBytes);
      p.Add("@OldId", subject.Id);
      await connection.ExecuteAsync("updateSubject", p, commandType: CommandType.StoredProcedure)
        .ConfigureAwait(false);
      return subject;
    }
    /// <summary>
    /// deletes a subject from the system
    /// </summary>
    /// <param name="subject">subject being deleted</param>
    public static async Task DeleteSubject(Subject subject)
    {
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      var p = new DynamicParameters();
      var q = new DynamicParameters();
      p.Add("@Name", subject.Name);
      p.Add("@Code", subject.Code);
      p.Add("@IsExaminable", subject.IsExaminable);
      p.Add("@ColorBytes", subject.ColorBytes);
      p.Add("@Id", subject.Id);
      p.Add("@TimeOfDelete", DateTime.Now);
      q.Add("@SubjectId", subject.Id);
      await connection.ExecuteAsync("insertDeletedSubject", p, commandType: CommandType.StoredProcedure)
        .ConfigureAwait(false);
      await connection.ExecuteAsync("deleteSubject", q, commandType: CommandType.StoredProcedure)
        .ConfigureAwait(false);
    }
    /// <summary>
    /// creates backup of an edited subject
    /// </summary>
    /// <param name="subject">subject being backed up</param>
    /// <returns>true if back-up is succeeded</returns>
    /// 
    public static async Task<bool> BackupEditedSubject(Subject subject, List<string> remarks)
    {
      try
      {
        using IDbConnection connection = new SqlConnection
      (Connections.ConnectionString.GetString(CONNECTION));
        var p = new DynamicParameters();
        p.Add("@Name", subject.Name);
        p.Add("@Code", subject.Code);
        p.Add("@IsExaminable", subject.IsExaminable);
        p.Add("@ColorBytes", subject.ColorBytes);
        p.Add("@Id", subject.Id);
        p.Add("@TimeOfEdit", DateTime.Now);
        foreach (var remark in remarks)
        {
          p.Add("@Remarks", remark);
          await connection.ExecuteAsync("insertEditedSubject", p, commandType: CommandType.StoredProcedure)
            .ConfigureAwait(false);
        }
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }
    /// <summary>
    /// retrieves a single subject from the ERP system
    /// </summary>
    /// <param name="subjectId">unique identifier of the subject being retrieved</param>
    /// <returns>subject</returns>
    public static async Task<Subject> GetSubject(int subjectId)
    {
      using IDbConnection connection = new SqlConnection
        (Connections.ConnectionString.GetString(CONNECTION));
      var p = new DynamicParameters();
      p.Add("@SubjectId", subjectId);
      return await connection.QueryFirstOrDefaultAsync<Subject>("getSubject", p, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
    }
  }
}
