
namespace E_Library.Dashboard
{
    partial class ProfileControl
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.panel1 = new Wisej.Web.Panel();
            this.panel5 = new Wisej.Web.Panel();
            this.btnRefresh = new Wisej.Web.Button();
            this.dtpTo = new Wisej.Web.DateTimePicker();
            this.dtpFrom = new Wisej.Web.DateTimePicker();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label3 = new Wisej.Web.Label();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.panel2 = new Wisej.Web.Panel();
            this.lblWallet = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.btnFundWallet = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 846);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.dtpTo);
            this.panel5.Controls.Add(this.dtpFrom);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(50, 139);
            this.panel5.Name = "panel5";
            this.panel5.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel5.ResponsiveProfiles"))));
            this.panel5.Size = new System.Drawing.Size(701, 639);
            this.panel5.TabIndex = 14;
            this.panel5.TabStop = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnRefresh.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/refresh.svg";
            this.btnRefresh.Location = new System.Drawing.Point(234, 109);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 28);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = false;
            this.dtpTo.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTo.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpTo.LabelText = "To";
            this.dtpTo.Location = new System.Drawing.Point(126, 94);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(98, 44);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.Value = new System.DateTime(2021, 5, 16, 16, 40, 56, 708);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFrom.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFrom.LabelText = "From";
            this.dtpFrom.Location = new System.Drawing.Point(22, 94);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(98, 44);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.Value = new System.DateTime(2021, 5, 16, 16, 40, 56, 708);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox1.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/history.svg";
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label3.Location = new System.Drawing.Point(76, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment\'s History";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // panel2
            // 
            this.panel2.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel2.Controls.Add(this.lblWallet);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnFundWallet);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(52, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 73);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWallet.ForeColor = System.Drawing.Color.Green;
            this.lblWallet.Location = new System.Drawing.Point(206, 22);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(80, 23);
            this.lblWallet.TabIndex = 7;
            this.lblWallet.Text = "N12,500";
            this.lblWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AllowHtml = true;
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnFundWallet
            // 
            this.btnFundWallet.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnFundWallet.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnFundWallet.Focusable = false;
            this.btnFundWallet.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/plus-circle.svg";
            this.btnFundWallet.Location = new System.Drawing.Point(552, 12);
            this.btnFundWallet.Name = "btnFundWallet";
            this.btnFundWallet.Size = new System.Drawing.Size(123, 40);
            this.btnFundWallet.TabIndex = 2;
            this.btnFundWallet.Text = "Fund Wallet";
            this.btnFundWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFundWallet.Click += new System.EventHandler(this.btnFundWallet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wallet Balance:";
            // 
            // ProfileControl
            // 
            this.Controls.Add(this.panel1);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(800, 846);
            this.Load += new System.EventHandler(this.ProfileControl_Load);
            this.Appear += new System.EventHandler(this.ProfileControl_Appear);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Button btnFundWallet;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label lblWallet;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Button btnRefresh;
        private Wisej.Web.DateTimePicker dtpTo;
        private Wisej.Web.DateTimePicker dtpFrom;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label label3;
        private Wisej.Web.DataGridView dataGridView1;
    }
}
