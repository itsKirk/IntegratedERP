
namespace IntegratedERP.Screens
{
  partial class SubjectsRegistrationForm
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
      this.ManageSubjectsGroupBox = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.CodeTextBox = new System.Windows.Forms.TextBox();
      this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
      this.ExaminableCheckBox = new System.Windows.Forms.CheckBox();
      this.SaveButton = new System.Windows.Forms.Button();
      this.ManageSubjectsGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // HeadingLabel
      // 
      this.HeadingLabel.AutoSize = true;
      this.HeadingLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HeadingLabel.Location = new System.Drawing.Point(89, 13);
      this.HeadingLabel.Name = "HeadingLabel";
      this.HeadingLabel.Size = new System.Drawing.Size(235, 23);
      this.HeadingLabel.TabIndex = 3;
      this.HeadingLabel.Text = "Registration of Subjects";
      // 
      // ManageSubjectsGroupBox
      // 
      this.ManageSubjectsGroupBox.Controls.Add(this.SaveButton);
      this.ManageSubjectsGroupBox.Controls.Add(this.label3);
      this.ManageSubjectsGroupBox.Controls.Add(this.label2);
      this.ManageSubjectsGroupBox.Controls.Add(this.CodeTextBox);
      this.ManageSubjectsGroupBox.Controls.Add(this.SubjectNameTextBox);
      this.ManageSubjectsGroupBox.Controls.Add(this.ExaminableCheckBox);
      this.ManageSubjectsGroupBox.Location = new System.Drawing.Point(32, 50);
      this.ManageSubjectsGroupBox.Name = "ManageSubjectsGroupBox";
      this.ManageSubjectsGroupBox.Size = new System.Drawing.Size(332, 290);
      this.ManageSubjectsGroupBox.TabIndex = 5;
      this.ManageSubjectsGroupBox.TabStop = false;
      this.ManageSubjectsGroupBox.Text = "Add New";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(31, 126);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(113, 19);
      this.label3.TabIndex = 5;
      this.label3.Text = "Subject Name*";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(31, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 19);
      this.label2.TabIndex = 4;
      this.label2.Text = "Code*";
      // 
      // CodeTextBox
      // 
      this.CodeTextBox.Location = new System.Drawing.Point(35, 76);
      this.CodeTextBox.Name = "CodeTextBox";
      this.CodeTextBox.Size = new System.Drawing.Size(140, 24);
      this.CodeTextBox.TabIndex = 3;
      // 
      // SubjectNameTextBox
      // 
      this.SubjectNameTextBox.Location = new System.Drawing.Point(35, 148);
      this.SubjectNameTextBox.Name = "SubjectNameTextBox";
      this.SubjectNameTextBox.Size = new System.Drawing.Size(175, 24);
      this.SubjectNameTextBox.TabIndex = 2;
      // 
      // ExaminableCheckBox
      // 
      this.ExaminableCheckBox.AutoSize = true;
      this.ExaminableCheckBox.Checked = true;
      this.ExaminableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ExaminableCheckBox.Location = new System.Drawing.Point(191, 77);
      this.ExaminableCheckBox.Name = "ExaminableCheckBox";
      this.ExaminableCheckBox.Size = new System.Drawing.Size(110, 23);
      this.ExaminableCheckBox.TabIndex = 1;
      this.ExaminableCheckBox.Text = "Examinable";
      this.ExaminableCheckBox.UseVisualStyleBackColor = true;
      // 
      // SaveButton
      // 
      this.SaveButton.Location = new System.Drawing.Point(191, 199);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(109, 38);
      this.SaveButton.TabIndex = 12;
      this.SaveButton.Text = "Save";
      this.SaveButton.UseVisualStyleBackColor = true;
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // SubjectsRegistrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(396, 363);
      this.Controls.Add(this.HeadingLabel);
      this.Controls.Add(this.ManageSubjectsGroupBox);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "SubjectsRegistrationForm";
      this.Text = "Registration | Subjects";
      this.Load += new System.EventHandler(this.SubjectsRegistrationForm_Load);
      this.ManageSubjectsGroupBox.ResumeLayout(false);
      this.ManageSubjectsGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label HeadingLabel;
    private System.Windows.Forms.GroupBox ManageSubjectsGroupBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox CodeTextBox;
    private System.Windows.Forms.TextBox SubjectNameTextBox;
    private System.Windows.Forms.CheckBox ExaminableCheckBox;
    private System.Windows.Forms.Button SaveButton;
  }
}