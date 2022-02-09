using ERP.Core.Models;
using FluentValidation.Results;
using IntegratedERP.Blueprints;
using Repository.Connections;
using Repository.Repositories;
using Repository.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Repository.Repositories.Args;

namespace IntegratedERP.Screens
{
  public partial class SubjectsRegistrationForm : BaseForm
  {
    private Subject _subject;
    private ISubjectLoader caller;
    public SubjectsRegistrationForm(ISubjectLoader callingForm)
    {
      InitializeComponent();
      caller = callingForm;
      HeadingLabel.ForeColor = Curator.LabelHeadingColor();
      _subject = caller?.LoadSubject();
      ExamineIncomingModel();
    }
    private void ExamineIncomingModel()
    {
      SubjectNameTextBox.Text = _subject?.Name;
      CodeTextBox.Text = _subject?.Code;
      ExaminableCheckBox.Checked = _subject?.IsExaminable != false;
    }
    private void SubjectsRegistrationForm_Load(object sender, EventArgs e)
    {

    }

    private static ValidationResult ValidateSubject(Subject subject)
      => new SubjectValidator().Validate(subject);
    private async void SaveSubject(Subject subject)
    {
      var results = ValidateSubject(subject);
      if (!Enumerable.Any(results.Errors))
      {
        //ClearForm();
        await SubjectRepository.AddSubject(subject).ConfigureAwait(false);
        HomeForm.InitialData.Item1.Clear();
        HomeForm.InitialData.Item1.AddRange(RefreshData.RefreshSubjects());
      }
      else
      {
        MessageBox.Show(results.Errors[0].ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private async void EditSubject(Subject subject, List<string> remarks)
    {
      var results = ValidateSubject(subject);
      if (!Enumerable.Any(results.Errors))
      {
        //ClearForm();
        if (!await SubjectRepository.BackupEditedSubject(subject, remarks)) return;
        await SubjectRepository.EditSubject(subject).ConfigureAwait(false);
        HomeForm.InitialData.Item1.Clear();
        HomeForm.InitialData.Item1.AddRange(RefreshData.RefreshSubjects());
      }
      else
      {
        MessageBox.Show(results.Errors[0].ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void ClearForm()
    {
      SubjectNameTextBox.Clear();
      CodeTextBox.Clear();
      ExaminableCheckBox.Checked = true;
    }
    private void SaveButton_Click(object sender, EventArgs e)
    {
      if (_subject != null && !ValidateSubject(_subject).Errors.Any())
      {
        Subject editedSubject = new()
        {
          Code = CodeTextBox.Text.Trim(),
          IsExaminable = ExaminableCheckBox.Checked,
          Name = SubjectNameTextBox.Text.Trim(),
          ColorBytes = _subject.ColorBytes,
          Id = _subject.Id
        };
        var remarks = new List<string>();
        if (editedSubject.Code != _subject.Code)
        {
          remarks.Add($"subject code changed from {_subject.Code} to {editedSubject.Code}");
        }
        if (editedSubject.Name != _subject.Name)
        {
          remarks.Add($"subject name changed from {_subject.Name} to {editedSubject.Name}");
        }
        if (editedSubject.IsExaminable != _subject.IsExaminable)
        {
          var editedStatus = editedSubject.IsExaminable;
          switch (editedStatus)
          {
            case true:
              remarks.Add($"subject type changed from non-examinable to examinable");
              break;
            case false:
              remarks.Add($"subject type changed from examinable to non-examinable");
              break;
          }
        }
        EditSubject(editedSubject, remarks);
        _ = MessageBox.Show($@"Subject updated successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        caller.UpdateBindings(); //TODO when called twice, this method throws error
        Close();
      }
      else
      {
        var random = new Random();
        var colorBytes = new byte[3];
        random.NextBytes(colorBytes);
        _subject = new Subject
        {
          Name = SubjectNameTextBox.Text.Trim(),
          Code = CodeTextBox.Text.Trim(),
          IsExaminable = ExaminableCheckBox.Checked,
          ColorBytes = $"{colorBytes[0]},{colorBytes[1]},{colorBytes[2]}",
        };
        SaveSubject(_subject);
        SubjectRepository.SubjectAdded += SubjectRepository_SubjectAdded;
      }
      SubjectRepository.SubjectAdded -= SubjectRepository_SubjectAdded;
    }

    private void SubjectRepository_SubjectAdded(object sender, SubjectArgs e)
    {
      MessageBox.Show(e.SaveReport, @"save", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
