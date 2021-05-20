
namespace E_Library.Dashboard
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.panel2 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.btnUser = new Wisej.Web.Button();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuProfile = new Wisej.Web.MenuItem();
            this.menuLogout = new Wisej.Web.MenuItem();
            this.btnNavShow = new Wisej.Web.Button();
            this.navigationBar1 = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.navDashboard = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navBookmark = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navLibrary = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.panelMain = new Wisej.Web.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 86);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Controls.Add(this.btnNavShow);
            this.panel3.CssStyle = "box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;";
            this.panel3.Dock = Wisej.Web.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 79);
            this.panel3.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.Color.FromName("@buttonText");
            this.btnUser.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnUser.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/round-account-button-with-user-inside.svg";
            this.btnUser.Location = new System.Drawing.Point(518, 21);
            this.btnUser.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuProfile,
            this.menuLogout});
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Wisej.Web.Padding(8);
            this.btnUser.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnUser.ResponsiveProfiles"))));
            this.btnUser.Size = new System.Drawing.Size(45, 39);
            this.btnUser.TabIndex = 9;
            this.btnUser.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = false;
            this.menuItem1.IconSource = "resource.wx/Wisej.Ext.FontAwesome/user-secret.svg";
            this.menuItem1.Index = 0;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "Administrator";
            // 
            // menuProfile
            // 
            this.menuProfile.IconSource = "resource.wx/Wisej.Ext.FontAwesome/user.svg";
            this.menuProfile.Index = 1;
            this.menuProfile.Name = "menuProfile";
            this.menuProfile.Text = "Profile";
            // 
            // menuLogout
            // 
            this.menuLogout.AllowHtml = true;
            this.menuLogout.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuLogout.ForeColor = System.Drawing.Color.FromName("@buttonFace");
            this.menuLogout.IconSource = "resource.wx/Wisej.Ext.FontAwesome/reply.svg";
            this.menuLogout.Index = 2;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Text = "<div style=\"padding: 8px\">Logout</div>";
            // 
            // btnNavShow
            // 
            this.btnNavShow.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.btnNavShow.BackColor = System.Drawing.Color.Transparent;
            this.btnNavShow.Focusable = false;
            this.btnNavShow.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnNavShow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/bars.svg";
            this.btnNavShow.Location = new System.Drawing.Point(29, 23);
            this.btnNavShow.Name = "btnNavShow";
            this.btnNavShow.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnNavShow.ResponsiveProfiles"))));
            this.btnNavShow.Size = new System.Drawing.Size(49, 37);
            this.btnNavShow.TabIndex = 8;
            this.btnNavShow.Tag = "show";
            this.btnNavShow.Visible = false;
            this.btnNavShow.Click += new System.EventHandler(this.btnNavShow_Click);
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = Wisej.Web.DockStyle.Left;
            this.navigationBar1.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navigationBar1.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navDashboard,
            this.navBookmark,
            this.navLibrary});
            this.navigationBar1.Logo = "resource.wx/Wisej.Ext.MaterialDesign/city-buildings-silhouette.svg";
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.ShowUser = false;
            this.navigationBar1.Size = new System.Drawing.Size(210, 528);
            this.navigationBar1.Text = "E-Library";
            // 
            // navDashboard
            // 
            this.navDashboard.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navDashboard.Icon = "resource.wx/Wisej.Ext.FontAwesome/tachometer.svg";
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Text = "Dashboard";
            // 
            // navBookmark
            // 
            this.navBookmark.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navBookmark.Icon = "resource.wx/Wisej.Ext.MaterialDesign/bookmark-ribbon.svg";
            this.navBookmark.InfoText = " 0 ";
            this.navBookmark.InfoTextBackColor = System.Drawing.Color.FromName("@buttonFace");
            this.navBookmark.InfoTextForeColor = System.Drawing.Color.FromName("@buttonText");
            this.navBookmark.Name = "navBookmark";
            this.navBookmark.Text = "Bookmarks";
            // 
            // navLibrary
            // 
            this.navLibrary.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navLibrary.Icon = "resource.wx/Wisej.Ext.FontAwesome/book.svg";
            this.navLibrary.InfoText = " 0 ";
            this.navLibrary.InfoTextBackColor = System.Drawing.Color.FromName("@buttonFace");
            this.navLibrary.InfoTextForeColor = System.Drawing.Color.FromName("@buttonText");
            this.navLibrary.Name = "navLibrary";
            this.navLibrary.Text = "My Library";
            // 
            // panelMain
            // 
            this.panelMain.Dock = Wisej.Web.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(210, 86);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(591, 442);
            this.panelMain.TabIndex = 6;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 528);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navigationBar1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Ext.NavigationBar.NavigationBar navigationBar1;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navDashboard;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navBookmark;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navLibrary;
        private Wisej.Web.Button btnUser;
        private Wisej.Web.MenuItem menuItem1;
        private Wisej.Web.MenuItem menuLogout;
        private Wisej.Web.Button btnNavShow;
        private Wisej.Web.MenuItem menuProfile;
        private Wisej.Web.Panel panelMain;
    }
}