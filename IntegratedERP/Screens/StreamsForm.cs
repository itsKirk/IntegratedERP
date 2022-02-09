using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegratedERP.Blueprints;

namespace IntegratedERP.Screens
{
  public partial class StreamsForm : BaseForm
  {
    public StreamsForm()
    {
      InitializeComponent();
      Curator.MakeGridView(StreamsDataGridView, true);
    }

    private void StreamsForm_Load(object sender, EventArgs e)
    {

    }
  }
}
