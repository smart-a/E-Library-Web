
namespace E_Library.Shared
{
    partial class DefaultHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultHeader));
            this.panel2 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.btnHome = new Wisej.Web.Button();
            this.btnLogin = new Wisej.Web.Button();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 106);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.CssStyle = "box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;";
            this.panel3.Dock = Wisej.Web.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 97);
            this.panel3.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnHome.CssStyle = "border-right: 1px solid #2c544d;\r\nborder-left: 1px solid #2c544d;\r\nborder-radius:" +
    " 0px;";
            this.btnHome.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnHome.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/home.svg";
            this.btnHome.Location = new System.Drawing.Point(519, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new Wisej.Web.Padding(8);
            this.btnHome.Size = new System.Drawing.Size(107, 42);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnLogin.CssStyle = "border-right: 1px solid #2c544d;\r\nborder-left: 1px solid #2c544d;\r\nborder-radius:" +
    " 0px;";
            this.btnLogin.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnLogin.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/user.svg";
            this.btnLogin.Location = new System.Drawing.Point(625, 29);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new Wisej.Web.Padding(8);
            this.btnLogin.Size = new System.Drawing.Size(106, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Tag = "";
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = Wisej.Web.AnchorStyles.Left;
            this.pictureBox1.Image = global::E_Library.Properties.Resources.nda_logo;
            this.pictureBox1.Location = new System.Drawing.Point(38, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pictureBox1.ResponsiveProfiles"))));
            this.pictureBox1.Size = new System.Drawing.Size(74, 72);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // DefaultHeader
            // 
            this.Controls.Add(this.panel2);
            this.Name = "DefaultHeader";
            this.Size = new System.Drawing.Size(768, 106);
            this.Load += new System.EventHandler(this.DefaultHeader_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel3;
        public Wisej.Web.Button btnHome;
        public Wisej.Web.Button btnLogin;
        private Wisej.Web.PictureBox pictureBox1;
    }
}
