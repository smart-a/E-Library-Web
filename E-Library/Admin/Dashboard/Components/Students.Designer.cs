
namespace E_Library.Admin.Dashboard.Components
{
    partial class Students
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.cbLevel = new Wisej.Web.ComboBox();
            this.panel3 = new Wisej.Web.Panel();
            this.radioFemale = new Wisej.Web.RadioButton();
            this.radioMale = new Wisej.Web.RadioButton();
            this.txtFullname = new Wisej.Web.TextBox();
            this.txtStudentNumber = new Wisej.Web.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnSave.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.Location = new System.Drawing.Point(46, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(304, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLevel);
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel1.Location = new System.Drawing.Point(35, 253);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(315, 76);
            this.panel1.TabIndex = 15;
            this.panel1.Text = "Level";
            // 
            // cbLevel
            // 
            this.cbLevel.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend;
            this.cbLevel.AutoSize = false;
            this.cbLevel.CssStyle = "padding: 10px;";
            this.cbLevel.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbLevel.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbLevel.LabelText = null;
            this.cbLevel.Location = new System.Drawing.Point(13, 3);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(302, 42);
            this.cbLevel.TabIndex = 9;
            this.cbLevel.Watermark = "Select Level";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioFemale);
            this.panel3.Controls.Add(this.radioMale);
            this.panel3.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel3.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel3.Location = new System.Drawing.Point(35, 180);
            this.panel3.Name = "panel3";
            this.panel3.ShowCloseButton = false;
            this.panel3.ShowHeader = true;
            this.panel3.Size = new System.Drawing.Size(315, 67);
            this.panel3.TabIndex = 14;
            this.panel3.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioFemale.Location = new System.Drawing.Point(149, 7);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(85, 26);
            this.radioFemale.TabIndex = 7;
            this.radioFemale.Text = "Female";
            // 
            // radioMale
            // 
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(28, 7);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(66, 26);
            this.radioMale.TabIndex = 6;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            // 
            // txtFullname
            // 
            this.txtFullname.CssStyle = "border-radius: 3px";
            this.txtFullname.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullname.LabelText = "Fullname";
            this.txtFullname.Location = new System.Drawing.Point(46, 102);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Padding = new Wisej.Web.Padding(12);
            this.txtFullname.Size = new System.Drawing.Size(304, 68);
            this.txtFullname.TabIndex = 13;
            this.txtFullname.Watermark = "Enter Fullname";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.CssStyle = "border-radius: 3px";
            this.txtStudentNumber.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStudentNumber.LabelText = "Student Number";
            this.txtStudentNumber.Location = new System.Drawing.Point(46, 16);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Padding = new Wisej.Web.Padding(12);
            this.txtStudentNumber.Size = new System.Drawing.Size(304, 68);
            this.txtStudentNumber.TabIndex = 12;
            this.txtStudentNumber.Watermark = "Enter Student Number";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 420);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtStudentNumber);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.HeaderBackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/user-account-box.svg";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Students";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.FormClosed += new Wisej.Web.FormClosedEventHandler(this.Students_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button btnSave;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.ComboBox cbLevel;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.RadioButton radioFemale;
        private Wisej.Web.RadioButton radioMale;
        private Wisej.Web.TextBox txtFullname;
        private Wisej.Web.TextBox txtStudentNumber;
    }
}