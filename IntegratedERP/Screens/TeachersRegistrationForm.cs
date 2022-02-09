using ERP.Core;
using IntegratedERP.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using ERP.Core.Models;
using Repository.Repositories;
using Repository.Repositories.Args;
using Repository.Validators;
using System.Windows.Forms;
using FluentValidation.Results;
using Repository.Connections;

namespace IntegratedERP.Screens
{
#nullable enable
  public partial class TeachersRegistrationForm : BaseForm, ITeacherLoader
  {
    private const string REGISTRATIONNUMBER = @"Registration Number";
    private const string TSCNUMBER = @"TSC Number";
    private const string PFNUMBER = @"Registration Number";
    public event EventHandler<ValidationArgs>? OnTeacherValidation;
    public TeachersRegistrationForm()
    {
      InitializeComponent();
      List<Bank>? banksList = HomeForm.InitialData.Item2;
      foreach (var bank in banksList)
      {
        BanksComboBox.Items.Add(bank.Name);
      }
      BanksComboBox.SelectedIndex = 0;
    }
    private void TeachersTabControl_Enter(object sender, EventArgs e)
    {
      NewTeacherTabPage.BackColor = Curator.LabelHeadingColor();
    }
    private void LoadTitles()
    {
      TitleComboBox.DataSource = Enum.GetValues(typeof(Title));
    }
    private void LoadEmployers()
    {
      EmployerCombobox.DataSource = Enum.GetValues(typeof(Employer));
    }
    private void LoadEducationLevels()
    {
      EducationLevelComboBox.DataSource = Enum.GetValues(typeof(EducationLevel));
    }
    private void TeachersRegistrationForm_Load(object sender, EventArgs e)
    {
      LoadTitles();
      LoadEducationLevels();
      LoadEmployers();
    }

    private void EmployerCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
      var employer = EmployerCombobox.SelectedIndex;

      switch (employer)
      {
        case -1:
          EmployerNumberTextBox.Enabled = true;
          EmployerNumberLabel.Text = REGISTRATIONNUMBER;
          break;
        case 0:
          EmployerNumberTextBox.Enabled = true;
          EmployerNumberLabel.Text = TSCNUMBER;
          break;
        case 1:
          EmployerNumberTextBox.Enabled = true;
          EmployerNumberLabel.Text = PFNUMBER;
          break;
        case 2:
          EmployerNumberLabel.Text = REGISTRATIONNUMBER;
          EmployerNumberTextBox.Enabled = false;
          break;
      }
    }
    private async void RegisterButton_Click(object sender, EventArgs e)
    {
      var teacher = CreateTeacher();
      SaveTeacher(teacher);
      //var results = new TeacherValidator().Validate(CreateTeacher());
      //OnTeacherValidation?.Invoke(this, new ValidationArgs(results));
      //if (results.Errors.Any())
      //{
      //  OnTeacherValidation += TeachersRegistrationForm_OnTeacherValidationFailure;
      //}

      //await TeacherRepository.AddTeacher(teacher);
      TeacherRepository.TeacherAdded += TeacherRepository_TeacherAdded;
    }
    private void TeacherRepository_TeacherAdded(object sender, TeacherArgs e)
    {
      MessageBox.Show(e.SaveReport, @"Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private void TeachersRegistrationForm_OnTeacherValidationFailure(object sender, ValidationArgs e)
    {
      var errorMessage = e?.Results?.Errors[0].ToString();
      MessageBox.Show(errorMessage, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private async void SaveTeacher(Teacher teacher)
    {
      var results = ValidateTeacher(teacher);
      if (!Enumerable.Any(results.Errors))
      {
        //ClearForm();
        await TeacherRepository.AddTeacher(teacher).ConfigureAwait(false);
        HomeForm.InitialData.Item3.Clear();
        HomeForm.InitialData.Item3.AddRange(RefreshData.RefreshTeachers());
      }
      else
      {
        MessageBox.Show(results.Errors[0].ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private static ValidationResult ValidateTeacher(Teacher teacher)
      => new TeacherValidator().Validate(teacher);
    public Teacher CreateTeacher() => new()
    {
      AccountNumber = AccountNumberTextBox.Text.Trim(),
      BankName = BanksComboBox.SelectedItem.ToString(),
      Contact = new Contact()
      {
        PhoneNumbers = new List<string>
        {
          PhoneNumberTextBox.Text.Trim(),
          PhoneNumber2TextBox.Text.Trim()
        },
        EmailAddress = EmailAddressTextBox.Text.Trim(),
        PhysicalAddress = PhysicalAddressTextBox.Text.Trim(),
        Town = TownTextBox.Text.Trim()
      },
      EducationLevel = EducationLevelComboBox.SelectedItem.ToString(),
      EmployerName = EmployerCombobox.SelectedItem.ToString(),
      FirstName = FirstNameTextBox.Text.Trim(),
      HudumaNumber = HudumaNumberTextBox.Text.Trim(),
      IdNumber = NationalIdTextBox.Text.Trim(),
      LastName = LastNameTextBox.Text.Trim(),
      MiddleName = OtherNamesTextBox.Text.Trim(),
      PINNumber = KRAPinTextBox.Text.Trim(),
      RegistrationNumber = EmployerNumberTextBox.Text.Trim(),
      StaffNumber = StaffNumberTextBox.Text.Trim(),
      Title = TitleComboBox.SelectedItem.ToString()
    };

    private void CancelButton_Click(object sender, EventArgs e)
    {
      //if (CreateTeacher() is not null)
      //{
      //  if (MessageBox.Show(@"teacher details are not yet captured. are you sure you want to quit?", @"Exit",
      //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      //  {
      Close();
      //  }
      //}
    }
  }
}
