using FluentValidation.Results;
using System;

namespace Repository.Repositories.Args
{
#nullable enable
  public class ValidationArgs : EventArgs
  {
    public ValidationResult? Results { get; private set; }

    public ValidationArgs(ValidationResult results)
    {
      Results = results;
    }
  }
}
