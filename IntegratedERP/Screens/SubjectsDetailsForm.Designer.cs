
namespace IntegratedERP.Screens
{
  partial class SubjectsDetailsForm
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
      this.HeadingLabel = new System.Windows.Forms.Label();
      this.SubjectDetailsGroupBox = new System.Windows.Forms.GroupBox();
      this.certifiedSubjectsDatagridView = new System.Windows.Forms.DataGridView();
      this.ManageSubjectsGroupBox = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.ColorPanel = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.CodeTextBox = new System.Windows.Forms.TextBox();
      this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
      this.ExaminableCheckBox = new System.Windows.Forms.CheckBox();
      this.DeleteButton = new System.Windows.Forms.Button();
      this.EditButton = new System.Windows.Forms.Button();
      this.SubjectDetailsGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.certifiedSubjectsDatagridView)).BeginInit();
      this.ManageSubjectsGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // HeadingLabel
      // 
      this.HeadingLabel.AutoSize = true;
      this.HeadingLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HeadingLabel.Location = new System.Drawing.Point(292, 16);
      this.HeadingLabel.Name = "HeadingLabel";
      this.HeadingLabel.Size = new System.Drawing.Size(171, 23);
      this.HeadingLabel.TabIndex = 0;
      this.HeadingLabel.Text = "Subjects Offered";
      // 
      // SubjectDetailsGroupBox
      // 
      this.SubjectDetailsGroupBox.Controls.Add(this.certifiedSubjectsDatagridView);
      this.SubjectDetailsGroupBox.Location = new System.Drawing.Point(7, 55);
      this.SubjectDetailsGroupBox.Name = "SubjectDetailsGroupBox";
      this.SubjectDetailsGroupBox.Size = new System.Drawing.Size(411, 375);
      this.SubjectDetailsGroupBox.TabIndex = 1;
      this.SubjectDetailsGroupBox.TabStop = false;
      this.SubjectDetailsGroupBox.Text = "Certified Subjects";
      // 
      // certifiedSubjectsDatagridView
      // 
      this.certifiedSubjectsDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.certifiedSubjectsDatagridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.certifiedSubjectsDatagridView.Location = new System.Drawing.Point(3, 20);
      this.certifiedSubjectsDatagridView.Name = "certifiedSubjectsDatagridView";
      this.certifiedSubjectsDatagridView.Size = new System.Drawing.Size(405, 352);
      this.certifiedSubjectsDatagridView.TabIndex = 0;
      this.certifiedSubjectsDatagridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.certifiedSubjectDatagridView_CellContentClick);
      this.certifiedSubjectsDatagridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.certifiedSubjectsDatagridView_RowEnter);
      this.certifiedSubjectsDatagridView.SelectionChanged += new System.EventHandler(this.certifiedSubjectDatagridView_SelectionChanged);
      this.certifiedSubjectsDatagridView.Click += new System.EventHandler(this.certifiedSubjectsDatagridView_Click);
      // 
      // ManageSubjectsGroupBox
      // 
      this.ManageSubjectsGroupBox.Controls.Add(this.label4);
      this.ManageSubjectsGroupBox.Controls.Add(this.ColorPanel);
      this.ManageSubjectsGroupBox.Controls.Add(this.label3);
      this.ManageSubjectsGroupBox.Controls.Add(this.label2);
      this.ManageSubjectsGroupBox.Controls.Add(this.CodeTextBox);
      this.ManageSubjectsGroupBox.Controls.Add(this.SubjectNameTextBox);
      this.ManageSubjectsGroupBox.Controls.Add(this.ExaminableCheckBox);
      this.ManageSubjectsGroupBox.Controls.Add(this.DeleteButton);
      this.ManageSubjectsGroupBox.Controls.Add(this.EditButton);
      this.ManageSubjectsGroupBox.Location = new System.Drawing.Point(424, 55);
      this.ManageSubjectsGroupBox.Name = "ManageSubjectsGroupBox";
      this.ManageSubjectsGroupBox.Size = new System.Drawing.Size(324, 375);
      this.ManageSubjectsGroupBox.TabIndex = 2;
      this.ManageSubjectsGroupBox.TabStop = false;
      this.ManageSubjectsGroupBox.Text = "Add New";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 197);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 19);
      this.label4.TabIndex = 8;
      this.label4.Text = "Color";
      // 
      // ColorPanel
      // 
      this.ColorPanel.Location = new System.Drawing.Point(22, 222);
      this.ColorPanel.Name = "ColorPanel";
      this.ColorPanel.Size = new System.Drawing.Size(175, 38);
      this.ColorPanel.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 121);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(113, 19);
      this.label3.TabIndex = 5;
      this.label3.Text = "Subject Name*";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 19);
      this.label2.TabIndex = 4;
      this.label2.Text = "Code*";
      // 
      // CodeTextBox
      // 
      this.CodeTextBox.Location = new System.Drawing.Point(22, 71);
      this.CodeTextBox.Name = "CodeTextBox";
      this.CodeTextBox.Size = new System.Drawing.Size(140, 24);
      this.CodeTextBox.TabIndex = 3;
      // 
      // SubjectNameTextBox
      // 
      this.SubjectNameTextBox.Location = new System.Drawing.Point(22, 143);
      this.SubjectNameTextBox.Name = "SubjectNameTextBox";
      this.SubjectNameTextBox.Size = new System.Drawing.Size(175, 24);
      this.SubjectNameTextBox.TabIndex = 2;
      // 
      // ExaminableCheckBox
      // 
      this.ExaminableCheckBox.AutoSize = true;
      this.ExaminableCheckBox.Checked = true;
      this.ExaminableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ExaminableCheckBox.Location = new System.Drawing.Point(178, 72);
      this.ExaminableCheckBox.Name = "ExaminableCheckBox";
      this.ExaminableCheckBox.Size = new System.Drawing.Size(110, 23);
      this.ExaminableCheckBox.TabIndex = 1;
      this.ExaminableCheckBox.Text = "Examinable";
      this.ExaminableCheckBox.UseVisualStyleBackColor = true;
      // 
      // DeleteButton
      // 
      this.DeleteButton.Location = new System.Drawing.Point(22, 294);
      this.DeleteButton.Name = "DeleteButton";
      this.DeleteButton.Size = new System.Drawing.Size(109, 38);
      this.DeleteButton.TabIndex = 0;
      this.DeleteButton.Text = "Delete";
      this.DeleteButton.UseVisualStyleBackColor = true;
      this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
      // 
      // EditButton
      // 
      this.EditButton.Location = new System.Drawing.Point(197, 294);
      this.EditButton.Name = "EditButton";
      this.EditButton.Size = new System.Drawing.Size(109, 38);
      this.EditButton.TabIndex = 9;
      this.EditButton.Text = "Edit";
      this.EditButton.UseVisualStyleBackColor = true;
      this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
      // 
      // SubjectsDetailsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(754, 437);
      this.Controls.Add(this.ManageSubjectsGroupBox);
      this.Controls.Add(this.SubjectDetailsGroupBox);
      this.Controls.Add(this.HeadingLabel);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "SubjectsDetailsForm";
      this.Text = "Details | Subjects";
      this.Load += new System.EventHandler(this.SubjectsRegistrationForm_Load);
      this.SubjectDetailsGroupBox.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.certifiedSubjectsDatagridView)).EndInit();
      this.ManageSubjectsGroupBox.ResumeLayout(false);
      this.ManageSubjectsGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label HeadingLabel;
    private System.Windows.Forms.GroupBox SubjectDetailsGroupBox;
    private System.Windows.Forms.GroupBox ManageSubjectsGroupBox;
    private System.Windows.Forms.DataGridView certifiedSubjectsDatagridView;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox CodeTextBox;
    private System.Windows.Forms.TextBox SubjectNameTextBox;
    private System.Windows.Forms.CheckBox ExaminableCheckBox;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel ColorPanel;
    private System.Windows.Forms.Button EditButton;
  }
}