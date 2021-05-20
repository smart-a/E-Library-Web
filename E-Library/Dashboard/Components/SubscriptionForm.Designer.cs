
namespace E_Library.Dashboard.Components
{
    partial class SubscriptionForm
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
            this.btnSave = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.cbSubscription = new Wisej.Web.ComboBox();
            this.txtAmount = new Wisej.Web.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnSave.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.Location = new System.Drawing.Point(50, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Subscribe";
            this.btnSave.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSubscription);
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel1.Location = new System.Drawing.Point(39, 24);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(315, 76);
            this.panel1.TabIndex = 17;
            this.panel1.Text = "Subscription";
            // 
            // cbSubscription
            // 
            this.cbSubscription.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend;
            this.cbSubscription.AutoSize = false;
            this.cbSubscription.CssStyle = "padding: 10px;";
            this.cbSubscription.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbSubscription.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbSubscription.LabelText = null;
            this.cbSubscription.Location = new System.Drawing.Point(13, 3);
            this.cbSubscription.Name = "cbSubscription";
            this.cbSubscription.Size = new System.Drawing.Size(298, 42);
            this.cbSubscription.TabIndex = 9;
            this.cbSubscription.Watermark = "Select Subscription";
            this.cbSubscription.SelectedIndexChanged += new System.EventHandler(this.cbSubscription_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.CssStyle = "border-radius: 3px";
            this.txtAmount.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.LabelText = "Amount";
            this.txtAmount.Location = new System.Drawing.Point(52, 120);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new Wisej.Web.Padding(12);
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(298, 68);
            this.txtAmount.TabIndex = 19;
            this.txtAmount.Text = "0";
            this.txtAmount.Watermark = "Enter Fullname";
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 284);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.HeaderBackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/been-here-marker.svg";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubscriptionForm";
            this.Text = "Subscription";
            this.FormClosed += new Wisej.Web.FormClosedEventHandler(this.SubscriptionForm_FormClosed);
            this.Appear += new System.EventHandler(this.Subscription_Appear);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button btnSave;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.ComboBox cbSubscription;
        private Wisej.Web.TextBox txtAmount;
    }
}