
namespace E_Library.Register
{
    partial class RegisterPage
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
            this.defaultHeader1 = new E_Library.Shared.DefaultHeader();
            this.panel1 = new Wisej.Web.Panel();
            this.panel4 = new Wisej.Web.Panel();
            this.panelContiner = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.btnSignUp = new Wisej.Web.Button();
            this.txtConfirmPassword = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.panel3 = new Wisej.Web.Panel();
            this.radioFemale = new Wisej.Web.RadioButton();
            this.radioMale = new Wisej.Web.RadioButton();
            this.txtPhone = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.txtFullname = new Wisej.Web.TextBox();
            this.panel5 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelContiner.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultHeader1
            // 
            this.defaultHeader1.Dock = Wisej.Web.DockStyle.Top;
            this.defaultHeader1.Name = "defaultHeader1";
            this.defaultHeader1.Size = new System.Drawing.Size(800, 103);
            this.defaultHeader1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1054);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel4.Controls.Add(this.panelContiner);
            this.panel4.Controls.Add(this.label2);
            this.panel4.CssStyle = "margin: 0 auto;\r\nmargin-bottom: 20px;";
            this.panel4.Location = new System.Drawing.Point(177, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 905);
            this.panel4.TabIndex = 3;
            // 
            // panelContiner
            // 
            this.panelContiner.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panelContiner.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panelContiner.Controls.Add(this.panel2);
            this.panelContiner.Controls.Add(this.panel5);
            this.panelContiner.CssStyle = "box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;";
            this.panelContiner.Location = new System.Drawing.Point(16, 16);
            this.panelContiner.Margin = new Wisej.Web.Padding(3, 3, 3, 30);
            this.panelContiner.Name = "panelContiner";
            this.panelContiner.Size = new System.Drawing.Size(414, 759);
            this.panelContiner.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel2.Controls.Add(this.btnSignUp);
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtFullname);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(414, 636);
            this.panel2.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(53, 152, 220);
            this.btnSignUp.CssStyle = "border-radius: 3px";
            this.btnSignUp.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSignUp.Location = new System.Drawing.Point(20, 568);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(143, 40);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.CssStyle = "border-radius: 3px";
            this.txtConfirmPassword.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtConfirmPassword.LabelText = "Confirm Password";
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 472);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new Wisej.Web.Padding(12);
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(368, 68);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.Watermark = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.CssStyle = "border-radius: 3px";
            this.txtPassword.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.LabelText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(20, 386);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new Wisej.Web.Padding(12);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(368, 68);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Watermark = "Enter Password";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioFemale);
            this.panel3.Controls.Add(this.radioMale);
            this.panel3.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel3.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel3.Location = new System.Drawing.Point(11, 290);
            this.panel3.Name = "panel3";
            this.panel3.ShowCloseButton = false;
            this.panel3.ShowHeader = true;
            this.panel3.Size = new System.Drawing.Size(377, 76);
            this.panel3.TabIndex = 7;
            this.panel3.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.Location = new System.Drawing.Point(149, 11);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(85, 26);
            this.radioFemale.TabIndex = 7;
            this.radioFemale.Text = "Female";
            // 
            // radioMale
            // 
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(28, 11);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(66, 26);
            this.radioMale.TabIndex = 6;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            // 
            // txtPhone
            // 
            this.txtPhone.CssStyle = "border-radius: 3px";
            this.txtPhone.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txtPhone.LabelText = "Phone Number";
            this.txtPhone.Location = new System.Drawing.Point(20, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new Wisej.Web.Padding(12);
            this.txtPhone.Size = new System.Drawing.Size(368, 68);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Watermark = "Enter Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.CssStyle = "border-radius: 3px";
            this.txtEmail.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.InputType.Type = Wisej.Web.TextBoxType.Email;
            this.txtEmail.LabelText = "Email";
            this.txtEmail.Location = new System.Drawing.Point(20, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new Wisej.Web.Padding(12);
            this.txtEmail.Size = new System.Drawing.Size(368, 68);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Watermark = "Enter Email";
            // 
            // txtFullname
            // 
            this.txtFullname.CssStyle = "border-radius: 3px";
            this.txtFullname.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullname.LabelText = "Fullname";
            this.txtFullname.Location = new System.Drawing.Point(23, 21);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Padding = new Wisej.Web.Padding(12);
            this.txtFullname.Size = new System.Drawing.Size(368, 68);
            this.txtFullname.TabIndex = 3;
            this.txtFullname.Watermark = "Enter Fullname";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel5.Controls.Add(this.label1);
            this.panel5.CssStyle = "border-bottom: 1px solid #f4f4f4";
            this.panel5.Dock = Wisej.Web.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new Wisej.Web.Padding(20, 10, 20, 10);
            this.panel5.Size = new System.Drawing.Size(414, 109);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AllowHtml = true;
            this.label1.Dock = Wisej.Web.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "<h1>Sign Up</h1>\r\n<span>Please fill in this form to create an account!</span>";
            // 
            // label2
            // 
            this.label2.AllowHtml = true;
            this.label2.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.label2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
            this.label2.Location = new System.Drawing.Point(16, 812);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Already have an account? <a href=\"/Login\">Login here</a>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1157);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.defaultHeader1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "RegisterPage";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "RegisterPage";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelContiner.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Shared.DefaultHeader defaultHeader1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Panel panelContiner;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Button btnSignUp;
        private Wisej.Web.TextBox txtConfirmPassword;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.RadioButton radioFemale;
        private Wisej.Web.RadioButton radioMale;
        private Wisej.Web.TextBox txtPhone;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.TextBox txtFullname;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
    }
}