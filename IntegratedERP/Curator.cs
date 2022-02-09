using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedERP
{
  public static class Curator
  {
    public static void HideDataGridViewColumns(DataGridView dataGridView, IEnumerable<byte> invisibleColumns)
    {
      foreach (var index in invisibleColumns)
      {
        dataGridView.Columns[index].Visible = false;
      }
    }
    /// <summary>
    /// checks if a row has been selected in a datagridview
    /// </summary>
    /// <param name="dataGridView">datagridview name</param>
    /// <returns>true if there is a selection, otherwise false</returns>
    public static Tuple<bool, int> SelectionHappened(DataGridView dataGridView)
    {
      if (dataGridView.RowCount <= 0) return new Tuple<bool, int>(false, 0);
      var selectedRow = dataGridView.CurrentRow;
      return new Tuple<bool, int>(true, selectedRow.Index);
    }
    public static void MakeGridView(DataGridView dataGridView, bool readOnly = false)
    {
      dataGridView.BorderStyle = BorderStyle.None;
      dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
      dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
      dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
      dataGridView.BackgroundColor = Color.White;
      dataGridView.EnableHeadersVisualStyles = false;
      dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
      dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
      dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dataGridView.RowHeadersVisible = false;
      dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dataGridView.AllowUserToResizeRows = false;
      dataGridView.AllowUserToAddRows = false;
      dataGridView.AllowUserToOrderColumns = false;
      dataGridView.ReadOnly = readOnly;
    }

    public static Color LabelHeadingColor() => Color.FromArgb(73, 160, 174);
  }
}
