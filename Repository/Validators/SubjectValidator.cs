using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Core.Models;
using FluentValidation;

namespace Repository.Validators
{
  /// <summary>
  /// Handles all things Subject Model validation
  /// </summary>
  public class SubjectValidator : AbstractValidator<ERP.Core.Models.Subject>
  {
    public SubjectValidator()
    {
      RuleFor(x => x.Code)
        .Cascade(CascadeMode.Stop)
        .NotEmpty().WithMessage("Enter Subject {PropertyName}")
        .MaximumLength(7).WithMessage("Enter a short Subject {PropertyName}")
        .Must(BaAValidCode).WithMessage("Subject {PropertyName} entered is invalid"); 
      RuleFor(x => x.Name)
        .Cascade(CascadeMode.Stop)
        .NotEmpty().WithMessage("Enter Subject {PropertyName}")
        .MaximumLength(50).WithMessage("Subject {PropertyName} given is too long.");
    }
    /// <summary>
    /// ensures the value entered for Subject Code is valid for the model
    /// </summary>
    /// <param name="enteredValue">subject code supplied</param>
    /// <returns>true if the code is valid, otherwise false</returns>
    private static bool BaAValidCode(string enteredValue)
    {
      enteredValue = enteredValue.Replace(" ", "");
      enteredValue = enteredValue.Replace("-", "");
      return enteredValue.All(char.IsLetterOrDigit);
    }
  }
}
