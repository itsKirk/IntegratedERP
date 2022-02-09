using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Core.Models;
using FluentValidation;
using FluentValidation.Results;
using Repository.Repositories.Args;

namespace Repository.Validators
{
  /// <summary>
  /// Handles all things Teacher Model validation
  /// </summary>
  public class TeacherValidator : AbstractValidator<Teacher>
  {
    public TeacherValidator()
    {
      RuleFor(x => x.FirstName)
        .Cascade(CascadeMode.Stop)
        .NotEmpty().WithMessage("{PropertyName} cannot be empty")
        .Length(2, 50).WithMessage("{PropertyName} is invalid.")
        .Must(BeAValidName).WithMessage("some characters entered for {PropertyName} are invalid");
      RuleFor(x => x.LastName)
        .Cascade(CascadeMode.Stop)
        .NotEmpty().WithMessage("{PropertyName} cannot be empty")
        .Length(2, 50).WithMessage("{PropertyName} is invalid.")
        .Must(BeAValidName).WithMessage("some characters entered for {PropertyName} are invalid");
      RuleFor(x => x.MiddleName)
        .Cascade(CascadeMode.Stop)
        .Must(BeAValidName).WithMessage("some characters entered for {PropertyName} are invalid");
      RuleFor(x => x.PINNumber)
        .Cascade(CascadeMode.Stop)
        .MaximumLength(11).WithMessage("{PropertyName} is invalid.")
        .Must(BeAValidPIN).WithMessage("some characters entered for {PropertyName} are invalid");
      RuleFor(x => x.AccountNumber)
        .Cascade(CascadeMode.Stop)
        .MaximumLength(20).WithMessage("{PropertyName} is invalid.")
        .Must(BeAValidNumber).WithMessage("some characters entered for {PropertyName} are invalid");
      RuleFor(x => x.IdNumber)
        .Cascade(CascadeMode.Stop)
        .NotEmpty().WithMessage("{PropertyName} cannot be empty")
        .MaximumLength(8).WithMessage("{PropertyName} is invalid.")
        .Must(BeAValidNumber).WithMessage("some characters entered for {PropertyName} are invalid");
      RuleFor(x => x.HudumaNumber)
        .Cascade(CascadeMode.Stop)
        .MaximumLength(10).WithMessage("{PropertyName} is invalid.")
        .Must(BeAValidHudumaNumber).WithMessage("some characters entered for {PropertyName} are invalid");
      RuleFor(x => x.Contact).SetValidator(new ContactValidator());
      
      //OnTeacherValidation?.Invoke(this, new ValidationArgs(new ValidationResult()));
    }
    /// <summary>
    /// ensures the name given is valid for the model
    /// </summary>
    /// <param name="enteredValue">given name</param>
    /// <returns>true if the name is valid, otherwise false</returns>
    private static bool BeAValidName(string enteredValue)
    {
      enteredValue = enteredValue.Replace(" ", "");
      enteredValue = enteredValue.Replace("-", "");
      return enteredValue.All(char.IsLetter);
    }
    /// <summary>
    /// ensures the value entered for Huduma Number is valid for the model
    /// </summary>
    /// <param name="enteredValue">huduma number supplied</param>
    /// <returns>true if the number is valid, otherwise false</returns>
    private static bool BeAValidHudumaNumber(string enteredValue)
    {
      enteredValue = enteredValue.Replace(" ", "");
      enteredValue = enteredValue.Replace("-", "");
      return enteredValue.All(char.IsLetterOrDigit);
    }
    /// <summary>
    /// ensures the value entered for PIN NUmber is valid for the model
    /// </summary>
    /// <param name="enteredValue">PIN Number supplied</param>
    /// <returns>true if the PIN is valid, otherwise false</returns>
    private static bool BeAValidPIN(string enteredValue) => enteredValue.All(char.IsLetterOrDigit);
    /// <summary>
    /// ensures the value entered is numeric
    /// </summary>
    /// <param name="enteredValue">value entered by user</param>
    /// <returns>true if the number is valid, otherwise false</returns>
    private static bool BeAValidNumber(string enteredValue) => enteredValue.All(char.IsNumber);

  }
}
