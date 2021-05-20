
namespace E_Library.Admin.Dashboard
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel2 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.btnUser = new Wisej.Web.Button();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuLogout = new Wisej.Web.MenuItem();
            this.btnNavShow = new Wisej.Web.Button();
            this.navigationBar1 = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.navStudents = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navClassification = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navBooks = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navPayments = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem1 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem2 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem3 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
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
            this.panel2.Location = new System.Drawing.Point(70, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 86);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Controls.Add(this.btnNavShow);
            this.panel3.CssStyle = "box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;";
            this.panel3.Dock = Wisej.Web.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 79);
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
            this.btnUser.Location = new System.Drawing.Point(657, 21);
            this.btnUser.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuLogout});
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Wisej.Web.Padding(8);
            this.btnUser.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnUser.ResponsiveProfiles"))));
            this.btnUser.Size = new System.Drawing.Size(45, 39);
            this.btnUser.TabIndex = 9;
            this.btnUser.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnUser.ItemClicked += new Wisej.Web.MenuButtonItemClickedEventHandler(this.btnUser_ItemClicked);
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = false;
            this.menuItem1.IconSource = "resource.wx/Wisej.Ext.FontAwesome/user-secret.svg";
            this.menuItem1.Index = 0;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "Administrator";
            // 
            // menuLogout
            // 
            this.menuLogout.AllowHtml = true;
            this.menuLogout.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuLogout.ForeColor = System.Drawing.Color.FromName("@buttonFace");
            this.menuLogout.IconSource = "resource.wx/Wisej.Ext.FontAwesome/reply.svg";
            this.menuLogout.Index = 1;
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
            this.navigationBar1.CompactView = true;
            this.navigationBar1.Dock = Wisej.Web.DockStyle.Left;
            this.navigationBar1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navigationBar1.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navStudents,
            this.navClassification,
            this.navBooks,
            this.navPayments});
            this.navigationBar1.Logo = "resource.wx/Wisej.Ext.MaterialDesign/city-buildings-silhouette.svg";
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.ShowUser = false;
            this.navigationBar1.Size = new System.Drawing.Size(70, 516);
            this.navigationBar1.Text = "E-Library";
            // 
            // navStudents
            // 
            this.navStudents.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navStudents.Icon = "resource.wx/Wisej.Ext.MaterialDesign/user-inside-bubble-speech.svg";
            this.navStudents.Name = "navStudents";
            this.navStudents.Text = "Students";
            this.navStudents.Click += new System.EventHandler(this.navStudents_Click);
            // 
            // navClassification
            // 
            this.navClassification.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navClassification.Icon = "resource.wx/Wisej.Ext.FontAwesome/cogs.svg";
            this.navClassification.Name = "navClassification";
            this.navClassification.Text = "Classification";
            this.navClassification.Click += new System.EventHandler(this.navClassification_Click);
            // 
            // navBooks
            // 
            this.navBooks.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navBooks.Icon = "resource.wx/Wisej.Ext.FontAwesome/book.svg";
            this.navBooks.Name = "navBooks";
            this.navBooks.Text = "Books";
            this.navBooks.Click += new System.EventHandler(this.navBooks_Click);
            // 
            // navPayments
            // 
            this.navPayments.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navPayments.Icon = "resource.wx/Wisej.Ext.FontAwesome/money.svg";
            this.navPayments.Name = "navPayments";
            this.navPayments.Text = "Payments";
            this.navPayments.Click += new System.EventHandler(this.navPayments_Click);
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navigationBarItem1.Icon = "resource.wx/Wisej.Ext.FontAwesome/tachometer.svg";
            this.navigationBarItem1.Name = "navigationBarItem1";
            this.navigationBarItem1.Text = "Dashboard";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navigationBarItem2.Icon = "resource.wx/Wisej.Ext.MaterialDesign/bookmark-ribbon.svg";
            this.navigationBarItem2.InfoText = " 0 ";
            this.navigationBarItem2.InfoTextBackColor = System.Drawing.Color.FromName("@buttonFace");
            this.navigationBarItem2.InfoTextForeColor = System.Drawing.Color.FromName("@buttonText");
            this.navigationBarItem2.Name = "navigationBarItem2";
            this.navigationBarItem2.Text = "My Books";
            // 
            // navigationBarItem3
            // 
            this.navigationBarItem3.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navigationBarItem3.Icon = "resource.wx/Wisej.Ext.FontAwesome/book.svg";
            this.navigationBarItem3.InfoText = " 0 ";
            this.navigationBarItem3.InfoTextBackColor = System.Drawing.Color.FromName("@buttonFace");
            this.navigationBarItem3.InfoTextForeColor = System.Drawing.Color.FromName("@buttonText");
            this.navigationBarItem3.Name = "navigationBarItem3";
            this.navigationBarItem3.Text = "My Library";
            // 
            // panelMain
            // 
            this.panelMain.Dock = Wisej.Web.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(70, 86);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(730, 430);
            this.panelMain.TabIndex = 12;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.navigationBarItem1);
            this.Controls.Add(this.navigationBarItem2);
            this.Controls.Add(this.navigationBarItem3);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Button btnUser;
        private Wisej.Web.MenuItem menuItem1;
        private Wisej.Web.MenuItem menuLogout;
        private Wisej.Web.Button btnNavShow;
        private Wisej.Web.Ext.NavigationBar.NavigationBar navigationBar1;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarItem1;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarItem2;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarItem3;
        private Wisej.Web.Panel panelMain;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navStudents;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navPayments;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navBooks;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navClassification;
    }
}