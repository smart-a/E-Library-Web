
namespace E_Library.Dashboard
{
    partial class LibrayControl
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
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            this.panel1 = new Wisej.Web.Panel();
            this.panelSubBook = new Wisej.Web.Panel();
            this.cbCategory = new Wisej.Web.ComboBox();
            this.btnRefresh = new Wisej.Web.Button();
            this.txtSearch = new Wisej.Web.TextBox();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.pictureBox4 = new Wisej.Web.PictureBox();
            this.label5 = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.tagTextSub = new Wisej.Web.TagTextBox();
            this.btnNewSub = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.panel1.SuspendLayout();
            this.panelSubBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSubBook);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 993);
            this.panel1.TabIndex = 0;
            // 
            // panelSubBook
            // 
            this.panelSubBook.Controls.Add(this.cbCategory);
            this.panelSubBook.Controls.Add(this.btnRefresh);
            this.panelSubBook.Controls.Add(this.txtSearch);
            this.panelSubBook.Controls.Add(this.dataGridView1);
            this.panelSubBook.Controls.Add(this.pictureBox4);
            this.panelSubBook.Controls.Add(this.label5);
            this.panelSubBook.Location = new System.Drawing.Point(52, 137);
            this.panelSubBook.Name = "panelSubBook";
            this.panelSubBook.Size = new System.Drawing.Size(697, 582);
            this.panelSubBook.TabIndex = 8;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.cbCategory.AutoSize = false;
            this.cbCategory.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbCategory.LabelText = "";
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
            this.txtSearch.LabelText = "";
            this.txtSearch.Location = new System.Drawing.Point(20, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new Wisej.Web.Padding(5);
            this.txtSearch.Size = new System.Drawing.Size(235, 29);
            this.txtSearch.TabIndex = 7;
            componentTool2.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/search.svg";
            this.txtSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            this.txtSearch.Watermark = "Search book";
            this.txtSearch.KeyPress += new Wisej.Web.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(20, 120);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(655, 459);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox4.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox4.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/briefcase-download-button-with-downwards-arr" +
    "ow.svg";
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
            this.label5.Text = "Subscribed Books";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tagTextSub);
            this.panel2.Controls.Add(this.btnNewSub);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(52, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 73);
            this.panel2.TabIndex = 0;
            // 
            // tagTextSub
            // 
            this.tagTextSub.AutoSize = false;
            this.tagTextSub.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tagTextSub.LabelText = "";
            this.tagTextSub.Location = new System.Drawing.Point(239, 22);
            this.tagTextSub.MaxTagWidth = 200;
            this.tagTextSub.Name = "tagTextSub";
            this.tagTextSub.ReadOnly = true;
            this.tagTextSub.Size = new System.Drawing.Size(223, 27);
            this.tagTextSub.TabIndex = 4;
            this.tagTextSub.Tag = "";
            this.tagTextSub.Text = "No active subscription";
            this.tagTextSub.Watermark = "Subscription List";
            // 
            // btnNewSub
            // 
            this.btnNewSub.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnNewSub.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnNewSub.Focusable = false;
            this.btnNewSub.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/pencil-square-o.svg";
            this.btnNewSub.Location = new System.Drawing.Point(481, 22);
            this.btnNewSub.Name = "btnNewSub";
            this.btnNewSub.Size = new System.Drawing.Size(26, 27);
            this.btnNewSub.TabIndex = 2;
            this.btnNewSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSub.Click += new System.EventHandler(this.btnNewSub_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Subscription";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/been-here-marker.svg";
            this.pictureBox1.Location = new System.Drawing.Point(22, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 33);
            // 
            // LibrayControl
            // 
            this.Controls.Add(this.panel1);
            this.Name = "LibrayControl";
            this.Size = new System.Drawing.Size(800, 993);
            this.Load += new System.EventHandler(this.LibrayControl_Load);
            this.Appear += new System.EventHandler(this.LibrayControl_Appear);
            this.panel1.ResumeLayout(false);
            this.panelSubBook.ResumeLayout(false);
            this.panelSubBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button btnNewSub;
        private Wisej.Web.Panel panelSubBook;
        private Wisej.Web.ComboBox cbCategory;
        private Wisej.Web.Button btnRefresh;
        private Wisej.Web.TextBox txtSearch;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.PictureBox pictureBox4;
        private Wisej.Web.Label label5;
        private Wisej.Web.TagTextBox tagTextSub;
    }
}
