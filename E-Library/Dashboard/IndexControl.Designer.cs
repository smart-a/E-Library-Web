
namespace E_Library.Dashboard
{
    partial class IndexControl
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
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexControl));
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.cbCategory = new Wisej.Web.ComboBox();
            this.btnRefresh = new Wisej.Web.Button();
            this.txtSearch = new Wisej.Web.TextBox();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.pictureBox4 = new Wisej.Web.PictureBox();
            this.label5 = new Wisej.Web.Label();
            this.panel5 = new Wisej.Web.Panel();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.label3 = new Wisej.Web.Label();
            this.lblBookmark = new Wisej.Web.Label();
            this.panel4 = new Wisej.Web.Panel();
            this.pictureBox3 = new Wisej.Web.PictureBox();
            this.label2 = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.lblWallet = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 905);
            this.panel1.TabIndex = 7;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(52, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 632);
            this.panel2.TabIndex = 7;
            this.panel2.TabStop = true;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.cbCategory.AutoSize = false;
            this.cbCategory.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbCategory.Location = new System.Drawing.Point(481, 85);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(194, 28);
            this.cbCategory.TabIndex = 9;
            this.cbCategory.Watermark = "Select book category";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnRefresh.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/refresh.svg";
            this.btnRefresh.Location = new System.Drawing.Point(261, 85);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 29);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(20, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new Wisej.Web.Padding(5);
            this.txtSearch.Size = new System.Drawing.Size(235, 30);
            this.txtSearch.TabIndex = 7;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/search.svg";
            this.txtSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.txtSearch.Watermark = "Search book";
            this.txtSearch.KeyPress += new Wisej.Web.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(20, 120);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(655, 459);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox4.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox4.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/buysellads.svg";
            this.pictureBox4.Location = new System.Drawing.Point(14, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label5.Location = new System.Drawing.Point(66, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Available Books";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblBookmark);
            this.panel5.CssStyle = "box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;\r\nborder-radius: 4px";
            this.panel5.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel5.Location = new System.Drawing.Point(425, 48);
            this.panel5.Margin = new Wisej.Web.Padding(3, 3, 20, 15);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new Wisej.Web.Padding(5);
            this.panel5.Size = new System.Drawing.Size(325, 107);
            this.panel5.TabIndex = 6;
            this.panel5.TabStop = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/favorite-heart-button.svg";
            this.pictureBox1.Location = new System.Drawing.Point(25, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox2.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/bookmark-button-1.svg";
            this.pictureBox2.Location = new System.Drawing.Point(235, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 54);
            // 
            // label3
            // 
            this.label3.AllowHtml = true;
            this.label3.Font = new System.Drawing.Font("default", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(25, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 53);
            this.label3.TabIndex = 1;
            this.label3.Text = "Favourite Books";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookmark
            // 
            this.lblBookmark.AutoSize = true;
            this.lblBookmark.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBookmark.ForeColor = System.Drawing.Color.Green;
            this.lblBookmark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBookmark.Location = new System.Drawing.Point(64, 64);
            this.lblBookmark.Name = "lblBookmark";
            this.lblBookmark.Size = new System.Drawing.Size(26, 23);
            this.lblBookmark.TabIndex = 0;
            this.lblBookmark.Text = "50";
            this.lblBookmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblWallet);
            this.panel4.CssStyle = "box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;\r\nborder-radius: 4px";
            this.panel4.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel4.Location = new System.Drawing.Point(50, 48);
            this.panel4.Margin = new Wisej.Web.Padding(3, 3, 20, 15);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Wisej.Web.Padding(5);
            this.panel4.Size = new System.Drawing.Size(326, 107);
            this.panel4.TabIndex = 4;
            this.panel4.TabStop = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/briefcase-with-tick-inside.svg";
            this.pictureBox3.Location = new System.Drawing.Point(22, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            // 
            // label2
            // 
            this.label2.AllowHtml = true;
            this.label2.Font = new System.Drawing.Font("default", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wallet Balance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AllowHtml = true;
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWallet.ForeColor = System.Drawing.Color.Green;
            this.lblWallet.Location = new System.Drawing.Point(60, 64);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(80, 23);
            this.lblWallet.TabIndex = 0;
            this.lblWallet.Text = "N12,500";
            this.lblWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IndexControl
            // 
            this.Controls.Add(this.panel1);
            this.Name = "IndexControl";
            this.Size = new System.Drawing.Size(800, 905);
            this.Load += new System.EventHandler(this.IndexControl_Load);
            this.Appear += new System.EventHandler(this.IndexControl_Appear);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.PictureBox pictureBox2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label lblBookmark;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.PictureBox pictureBox3;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label lblWallet;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label label5;
        private Wisej.Web.ComboBox cbCategory;
        private Wisej.Web.Button btnRefresh;
        private Wisej.Web.TextBox txtSearch;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.PictureBox pictureBox4;
    }
}
