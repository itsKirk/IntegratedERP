using ERP.Core.Models;
using IntegratedERP.Blueprints;
using Repository.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Repository.Connections;
using Repository.Repositories;

namespace IntegratedERP.Screens
{
  public partial class SubjectsDetailsForm : BaseForm, ISubjectLoader
  {
    private readonly List<Subject> subjects;
    private BindingSource source;
    public SubjectsDetailsForm()
    {
      InitializeComponent();
      HeadingLabel.ForeColor = Curator.LabelHeadingColor();
      subjects = HomeForm.InitialData.Item1;
      source = new BindingSource { DataSource = subjects};
      certifiedSubjectsDatagridView.DataSource = source;
    }
    private void RefreshDataGridView()
    {
      certifiedSubjectsDatagridView.DataSource = null;
      PopulateSubjectsGridView();
    }
    private void SubjectsRegistrationForm_Load(object sender, EventArgs e)
    {
      PopulateSubjectsGridView();
      //ActivateLinkLabel();
      LoadReadOnlyView();
    }
    private void PopulateSubjectsGridView()
    {
      Curator.MakeGridView(certifiedSubjectsDatagridView, true);
      certifiedSubjectsDatagridView.DataSource = source;
      var mutedColumns = new byte[] { 0, 4 };
      Curator.HideDataGridViewColumns(certifiedSubjectsDatagridView, mutedColumns);
      certifiedSubjectsDatagridView.Columns[1].DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleLeft;
      certifiedSubjectsDatagridView.Columns[2].HeaderCell.Style.Alignment =
        DataGridViewContentAlignment.MiddleLeft;
      certifiedSubjectsDatagridView.Columns[3].HeaderCell.Style.Alignment =
        DataGridViewContentAlignment.MiddleCenter;
      certifiedSubjectsDatagridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      certifiedSubjectsDatagridView.Columns[1].HeaderText = @"Code";
      certifiedSubjectsDatagridView.Columns[2].HeaderText = @"Subject Name";
      certifiedSubjectsDatagridView.Columns[3].HeaderText = @"Examinable";
    }


    private async void EditSubject(Subject subject)
    {
      var validator = new SubjectValidator();
      var results = await validator.ValidateAsync(subject).ConfigureAwait(false);
      if (!Enumerable.Any(results.Errors))
      {
        if (MessageBox.Show($@"Are you sure you want to edit?",
          @"Edit Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        await SubjectRepository.EditSubject(subject).ConfigureAwait(false);
        HomeForm.InitialData.Item1.Clear();
        HomeForm.InitialData.Item1.AddRange(RefreshData.RefreshSubjects());
        RefreshDataGridView();
        ClearForm();
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
      ColorPanel.BackColor = BackColor;
    }
    private async void DeleteButton_Click(object sender, EventArgs e)
    {
      var subjectToDelete = subjects.Find(x => x.Code == CodeTextBox.Text);
      if (MessageBox.Show($@"are you sure you want to delete {subjectToDelete.Name}?",
        @"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
      await SubjectRepository.DeleteSubject(subjectToDelete).ConfigureAwait(false);
      HomeForm.InitialData.Item1.Clear();
      HomeForm.InitialData.Item1.AddRange(RefreshData.RefreshSubjects());
      //RefreshDataGridView();
      //todo refresh datagridview in a thread-safe manner after deletion
    }
    private void LoadReadOnlyView()
    {
      SubjectNameTextBox.Enabled = false;
      CodeTextBox.Enabled = false;
      ExaminableCheckBox.Enabled = false;
      //SaveButton.Visible = false;
      EditButton.Visible = true;
    }
    private void LoadReadAndWriteView()
    {
      SubjectNameTextBox.Enabled = true;
      CodeTextBox.Enabled = true;
      ExaminableCheckBox.Enabled = true;
      //SaveButton.Visible = true;
      EditButton.Visible = false;
      //SaveButton.BringToFront();
      ClearForm();
    }
    private void FillFormWithModel(Subject subject)
    {
      SubjectNameTextBox.Text = subject.Name;
      CodeTextBox.Text = subject.Code;
      ExaminableCheckBox.Checked = bool.Parse(subject.IsExaminable.ToString());
      var colorBytes = subject.ColorBytes.Split(',');
      ColorPanel.BackColor = Color.FromArgb(int.Parse(colorBytes[0]),
                                            int.Parse(colorBytes[1]),
                                            int.Parse(colorBytes[2]));
    }
    private void certifiedSubjectDatagridView_SelectionChanged(object sender, EventArgs e)
    {
      //if (!certifiedSubjectsDatagridView.Focused) return;
      var (status, index) = Curator.SelectionHappened(certifiedSubjectsDatagridView);
      if (!status) return;
      var code = certifiedSubjectsDatagridView.Rows[index].Cells[1].Value.ToString();
      var subject = subjects.Find(x => x.Code == code);
      //ClearForm(); 
      FillFormWithModel(subject);
    }
    private void certifiedSubjectDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
    private void certifiedSubjectsDatagridView_Click(object sender, EventArgs e)
    {
      LoadReadOnlyView();
    }
    private void certifiedSubjectsDatagridView_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      //var (status, index) = Curator.SelectionHappened(certifiedSubjectsDatagridView);
      //if (!status) return;
      //var code = certifiedSubjectsDatagridView.Rows[index].Cells[1].Value.ToString();
      //var subject = subjects.Find(x => x.Code == code);
      ////ClearForm(); 
      //FillFormWithModel(subject);
    }
    private void ActivateEditMode()
    {
      SubjectNameTextBox.Enabled = true;
      CodeTextBox.Enabled = true;
      ExaminableCheckBox.Enabled = true;
      //SaveButton.Visible = true;
      EditButton.Visible = false;
      //SaveButton.BringToFront();
    }
    private void EditButton_Click(object sender, EventArgs e)
    {
      new SubjectsRegistrationForm(this).ShowDialog();
    }
    public void UpdateBindings()
    {
      RefreshDataGridView();
    }
    public Subject LoadSubject() => subjects.Find
      (x => x.Code == CodeTextBox.Text);
  }
}
