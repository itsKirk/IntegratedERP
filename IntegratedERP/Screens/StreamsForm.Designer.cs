
namespace IntegratedERP.Screens
{
  partial class StreamsForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.ClassesComboBox = new System.Windows.Forms.ComboBox();
      this.StreamTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.DeleteButton = new System.Windows.Forms.Button();
      this.SaveButton = new System.Windows.Forms.Button();
      this.StreamsDataGridView = new System.Windows.Forms.DataGridView();
      this.CapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.StreamsDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.CapacityNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(35, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 19);
      this.label1.TabIndex = 0;
      this.label1.Text = "Class";
      // 
      // ClassesComboBox
      // 
      this.ClassesComboBox.FormattingEnabled = true;
      this.ClassesComboBox.Location = new System.Drawing.Point(81, 46);
      this.ClassesComboBox.Name = "ClassesComboBox";
      this.ClassesComboBox.Size = new System.Drawing.Size(121, 25);
      this.ClassesComboBox.TabIndex = 1;
      // 
      // StreamTextBox
      // 
      this.StreamTextBox.Location = new System.Drawing.Point(99, 323);
      this.StreamTextBox.Name = "StreamTextBox";
      this.StreamTextBox.Size = new System.Drawing.Size(73, 24);
      this.StreamTextBox.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(35, 326);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 19);
      this.label2.TabIndex = 0;
      this.label2.Text = "Stream";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(241, 326);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 19);
      this.label3.TabIndex = 0;
      this.label3.Text = "Capacity";
      // 
      // DeleteButton
      // 
      this.DeleteButton.Location = new System.Drawing.Point(65, 353);
      this.DeleteButton.Name = "DeleteButton";
      this.DeleteButton.Size = new System.Drawing.Size(107, 30);
      this.DeleteButton.TabIndex = 3;
      this.DeleteButton.Text = "Delete";
      this.DeleteButton.UseVisualStyleBackColor = true;
      // 
      // SaveButton
      // 
      this.SaveButton.Location = new System.Drawing.Point(284, 353);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(107, 30);
      this.SaveButton.TabIndex = 4;
      this.SaveButton.Text = "Save";
      this.SaveButton.UseVisualStyleBackColor = true;
      // 
      // StreamsDataGridView
      // 
      this.StreamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.StreamsDataGridView.Location = new System.Drawing.Point(32, 77);
      this.StreamsDataGridView.Name = "StreamsDataGridView";
      this.StreamsDataGridView.Size = new System.Drawing.Size(392, 240);
      this.StreamsDataGridView.TabIndex = 5;
      // 
      // CapacityNumericUpDown
      // 
      this.CapacityNumericUpDown.Location = new System.Drawing.Point(318, 323);
      this.CapacityNumericUpDown.Name = "CapacityNumericUpDown";
      this.CapacityNumericUpDown.ReadOnly = true;
      this.CapacityNumericUpDown.Size = new System.Drawing.Size(73, 24);
      this.CapacityNumericUpDown.TabIndex = 6;
      this.CapacityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.CapacityNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
      // 
      // StreamsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(457, 395);
      this.Controls.Add(this.CapacityNumericUpDown);
      this.Controls.Add(this.StreamsDataGridView);
      this.Controls.Add(this.SaveButton);
      this.Controls.Add(this.DeleteButton);
      this.Controls.Add(this.StreamTextBox);
      this.Controls.Add(this.ClassesComboBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "StreamsForm";
      this.Text = "Registration | Streams";
      this.Load += new System.EventHandler(this.StreamsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.StreamsDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.CapacityNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox ClassesComboBox;
    private System.Windows.Forms.TextBox StreamTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.DataGridView StreamsDataGridView;
    private System.Windows.Forms.NumericUpDown CapacityNumericUpDown;
  }
}