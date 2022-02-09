using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Core.Models;
using IntegratedERP.Blueprints;
using Repository.Connections;

namespace IntegratedERP.Screens
{
  public partial class HomeForm : BaseForm
  {
    public static Tuple
    <
      List<Subject>,
      List<Bank>,
      List<Teacher>
    > InitialData { get; private set; }
    public HomeForm()
    {
      InitializeComponent();
      InitialData = InitializeData.Initialize();
    }

    private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
    private void HomeForm_Load(object sender, EventArgs e)
    {
      
    }

    private void addNewSubjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new SubjectsRegistrationForm(null).ShowDialog();
    }

    private void manageSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new SubjectsDetailsForm().ShowDialog();
    }

    private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new StudentsRegistrationForm().ShowDialog();
    }

    private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new TeachersRegistrationForm().ShowDialog();
    }

    private void streamsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new StreamsForm().ShowDialog();
    }
  }
}
