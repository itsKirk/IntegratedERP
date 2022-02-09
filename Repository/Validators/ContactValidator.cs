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
  /// Handles all things Contact Model validation
  /// </summary>
  public class ContactValidator : AbstractValidator<Contact>
  {
    public ContactValidator()
    {
      RuleFor(x => x.EmailAddress)
        .Cascade(CascadeMode.Stop)
        .EmailAddress().WithMessage("Please enter a valid {PropertyName}");
      RuleFor(x => x.PhoneNumbers)
        .Cascade(CascadeMode.Stop)
        .ForEach(y => y.Must(IsValidPhoneNumber)
        .WithMessage("one or both {PropertyName} given has invalid characters"))
        .ForEach(y => y.MaximumLength(13)
        .WithMessage("one or both {PropertyName} is incorrect"));

    }
    /// <summary>
    /// ensures the value entered is a valid phone number
    /// </summary>
    /// <param name="enteredValue">phone number entered by user</param>
    /// <returns>true if the number is valid, otherwise false</returns>
    private static bool IsValidPhoneNumber(string enteredValue)
    {
      enteredValue = enteredValue.Trim();
      enteredValue = enteredValue.Replace(" ", "");
      enteredValue = enteredValue.Replace("+", "");
      return enteredValue.All(char.IsNumber);
    }
  }
}
