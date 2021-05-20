
namespace E_Library.Admin.Dashboard
{
    partial class BooksControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksControl));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.panel5 = new Wisej.Web.Panel();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label1 = new Wisej.Web.Label();
            this.txtSearch = new Wisej.Web.TextBox();
            this.btnAddNew = new Wisej.Web.Button();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.btnRefresh = new Wisej.Web.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.btnAddNew);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(49, 58);
            this.panel5.Name = "panel5";
            this.panel5.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel5.ResponsiveProfiles"))));
            this.panel5.Size = new System.Drawing.Size(701, 639);
            this.panel5.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox1.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/book.svg";
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.LabelText = "";
            this.txtSearch.Location = new System.Drawing.Point(22, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new Wisej.Web.Padding(5);
            this.txtSearch.Size = new System.Drawing.Size(235, 29);
            this.txtSearch.TabIndex = 3;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/search.svg";
            this.txtSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.txtSearch.Watermark = "Book name or category";
            this.txtSearch.KeyPress += new Wisej.Web.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.Green;
            this.btnAddNew.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddNew.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/add-button-inside-black-circle.svg";
            this.btnAddNew.Location = new System.Drawing.Point(563, 102);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnAddNew.ResponsiveProfiles"))));
            this.btnAddNew.Size = new System.Drawing.Size(110, 35);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataGridView1.ResponsiveProfiles"))));
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(651, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnRefresh.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/refresh.svg";
            this.btnRefresh.Location = new System.Drawing.Point(270, 109);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 28);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BooksControl
            // 
            this.Controls.Add(this.panel5);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(800, 529);
            this.Appear += new System.EventHandler(this.BooksControl_Appear);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel panel5;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.TextBox txtSearch;
        private Wisej.Web.Button btnAddNew;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Button btnRefresh;
    }
}
