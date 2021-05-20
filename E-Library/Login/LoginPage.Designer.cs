
namespace E_Library.Login
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1 = new Wisej.Web.Panel();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.panel2 = new Wisej.Web.Panel();
            this.panel7 = new Wisej.Web.Panel();
            this.label4 = new Wisej.Web.Label();
            this.panelMsg = new Wisej.Web.Panel();
            this.lblMsg = new Wisej.Web.Label();
            this.btnCloseMsg = new Wisej.Web.Button();
            this.btnProceed = new Wisej.Web.Button();
            this.txtPassword = new Wisej.Web.TextBox();
            this.txtUsername = new Wisej.Web.TextBox();
            this.defaultHeader1 = new E_Library.Shared.DefaultHeader();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(100, 40, 0, 0);
            this.flowLayoutPanel1.ShowCloseButton = false;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(803, 1150);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.CssStyle = "margin: 0 auto";
            this.panel1.Location = new System.Drawing.Point(103, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 488);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.pictureBox1.Image = global::E_Library.Properties.Resources.ebooks;
            this.pictureBox1.Location = new System.Drawing.Point(73, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 448);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.CssStyle = "margin: 0 auto";
            this.panel2.Location = new System.Drawing.Point(103, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 498);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.panelMsg);
            this.panel7.Controls.Add(this.btnProceed);
            this.panel7.Controls.Add(this.txtPassword);
            this.panel7.Controls.Add(this.txtUsername);
            this.panel7.Location = new System.Drawing.Point(3, 48);
            this.panel7.Name = "panel7";
            this.panel7.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel7.ResponsiveProfiles"))));
            this.panel7.Size = new System.Drawing.Size(597, 387);
            this.panel7.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AllowHtml = true;
            this.label4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(8, 56, 127);
            this.label4.Location = new System.Drawing.Point(72, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "You don\'t have an account? <a href=\"/Register\" style=\"color: rgb(8, 56, 127)\">Sig" +
    "n Up here</a>";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMsg
            // 
            this.panelMsg.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panelMsg.BackColor = System.Drawing.Color.FromArgb(248, 215, 218);
            this.panelMsg.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panelMsg.Controls.Add(this.lblMsg);
            this.panelMsg.Controls.Add(this.btnCloseMsg);
            this.panelMsg.CssStyle = "border-radius: 4px";
            this.panelMsg.Location = new System.Drawing.Point(72, 13);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelMsg.ResponsiveProfiles"))));
            this.panelMsg.ShowCloseButton = false;
            this.panelMsg.Size = new System.Drawing.Size(448, 60);
            this.panelMsg.TabIndex = 8;
            this.panelMsg.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.FromArgb(248, 215, 217);
            this.lblMsg.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(153, 45, 36);
            this.lblMsg.Location = new System.Drawing.Point(18, 19);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("lblMsg.ResponsiveProfiles"))));
            this.lblMsg.Size = new System.Drawing.Size(95, 21);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Some Error";
            // 
            // btnCloseMsg
            // 
            this.btnCloseMsg.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Right)));
            this.btnCloseMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseMsg.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnCloseMsg.Focusable = false;
            this.btnCloseMsg.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCloseMsg.ForeColor = System.Drawing.Color.FromArgb(153, 45, 36);
            this.btnCloseMsg.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/times.svg";
            this.btnCloseMsg.Location = new System.Drawing.Point(408, 10);
            this.btnCloseMsg.Name = "btnCloseMsg";
            this.btnCloseMsg.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnCloseMsg.ResponsiveProfiles"))));
            this.btnCloseMsg.Size = new System.Drawing.Size(30, 38);
            this.btnCloseMsg.TabIndex = 0;
            // 
            // btnProceed
            // 
            this.btnProceed.AllowHtml = true;
            this.btnProceed.Anchor = Wisej.Web.AnchorStyles.Top;
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnProceed.CssStyle = "border-radius: 4px";
            this.btnProceed.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnProceed.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/check-square-o.svg";
            this.btnProceed.Location = new System.Drawing.Point(72, 244);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnProceed.ResponsiveProfiles"))));
            this.btnProceed.Size = new System.Drawing.Size(447, 56);
            this.btnProceed.TabIndex = 7;
            this.btnProceed.Text = "Proceed    ";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceed.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = Wisej.Web.AnchorStyles.Top;
            this.txtPassword.CssStyle = "border-radius: 4px";
            this.txtPassword.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.LabelText = "";
            this.txtPassword.Location = new System.Drawing.Point(72, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new Wisej.Web.Padding(15);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtPassword.ResponsiveProfiles"))));
            this.txtPassword.Size = new System.Drawing.Size(447, 53);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Watermark = "Enter Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = Wisej.Web.AnchorStyles.Top;
            this.txtUsername.CssStyle = "border-radius: 4px";
            this.txtUsername.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.LabelText = "";
            this.txtUsername.Location = new System.Drawing.Point(72, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new Wisej.Web.Padding(15);
            this.txtUsername.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtUsername.ResponsiveProfiles"))));
            this.txtUsername.Size = new System.Drawing.Size(447, 53);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Watermark = "Enter Username";
            // 
            // defaultHeader1
            // 
            this.defaultHeader1.Dock = Wisej.Web.DockStyle.Top;
            this.defaultHeader1.Name = "defaultHeader1";
            this.defaultHeader1.Size = new System.Drawing.Size(803, 102);
            this.defaultHeader1.TabIndex = 1;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 1252);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.defaultHeader1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelMsg.ResumeLayout(false);
            this.panelMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Shared.DefaultHeader defaultHeader1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel7;
        private Wisej.Web.Label label4;
        private Wisej.Web.Panel panelMsg;
        private Wisej.Web.Label lblMsg;
        private Wisej.Web.Button btnCloseMsg;
        private Wisej.Web.Button btnProceed;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.TextBox txtUsername;
        private Wisej.Web.PictureBox pictureBox1;
    }
}