
namespace E_Library.Admin.Dashboard
{
    partial class PaymentsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsControl));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.panel5 = new Wisej.Web.Panel();
            this.btnRefresh = new Wisej.Web.Button();
            this.dtpTo = new Wisej.Web.DateTimePicker();
            this.dtpFrom = new Wisej.Web.DateTimePicker();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label1 = new Wisej.Web.Label();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.panel1 = new Wisej.Web.Panel();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.lblPaymentReceived = new Wisej.Web.Label();
            this.lblPaymentCaption = new Wisej.Web.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.dtpTo);
            this.panel5.Controls.Add(this.dtpFrom);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(51, 136);
            this.panel5.Name = "panel5";
            this.panel5.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel5.ResponsiveProfiles"))));
            this.panel5.Size = new System.Drawing.Size(701, 639);
            this.panel5.TabIndex = 13;
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
            this.dtpTo.Size = new System.Drawing.Size(98, 43);
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
            this.dtpFrom.Size = new System.Drawing.Size(98, 43);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment\'s History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblPaymentReceived);
            this.panel1.Controls.Add(this.lblPaymentCaption);
            this.panel1.Location = new System.Drawing.Point(53, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 68);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox2.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox2.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/money.svg";
            this.pictureBox2.Location = new System.Drawing.Point(20, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            // 
            // lblPaymentReceived
            // 
            this.lblPaymentReceived.AutoSize = true;
            this.lblPaymentReceived.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaymentReceived.ForeColor = System.Drawing.Color.Green;
            this.lblPaymentReceived.Location = new System.Drawing.Point(307, 23);
            this.lblPaymentReceived.Name = "lblPaymentReceived";
            this.lblPaymentReceived.Size = new System.Drawing.Size(82, 23);
            this.lblPaymentReceived.TabIndex = 10;
            this.lblPaymentReceived.Text = "N12,500";
            this.lblPaymentReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentCaption
            // 
            this.lblPaymentCaption.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaymentCaption.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.lblPaymentCaption.Location = new System.Drawing.Point(71, 23);
            this.lblPaymentCaption.Name = "lblPaymentCaption";
            this.lblPaymentCaption.Size = new System.Drawing.Size(230, 23);
            this.lblPaymentCaption.TabIndex = 8;
            this.lblPaymentCaption.Text = "Total Payments Received:";
            // 
            // PaymentsControl
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "PaymentsControl";
            this.Size = new System.Drawing.Size(800, 870);
            this.Load += new System.EventHandler(this.PaymentsControl_Load);
            this.Appear += new System.EventHandler(this.PaymentsControl_Appear);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel5;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.DateTimePicker dtpTo;
        private Wisej.Web.DateTimePicker dtpFrom;
        private Wisej.Web.PictureBox pictureBox2;
        private Wisej.Web.Label lblPaymentReceived;
        private Wisej.Web.Label lblPaymentCaption;
        private Wisej.Web.Button btnRefresh;
    }
}
