
namespace E_Library.Admin.Dashboard.Components
{
    partial class Books
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
            this.txtBookName = new Wisej.Web.TextBox();
            this.panel1 = new Wisej.Web.Panel();
            this.cbCategory = new Wisej.Web.ComboBox();
            this.panel2 = new Wisej.Web.Panel();
            this.cbCourse = new Wisej.Web.ComboBox();
            this.panel3 = new Wisej.Web.Panel();
            this.cbSub = new Wisej.Web.ComboBox();
            this.panelFile = new Wisej.Web.Panel();
            this.upload1 = new Wisej.Web.Upload();
            this.label1 = new Wisej.Web.Label();
            this.btnSave = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.CssStyle = "border-radius: 3px";
            this.txtBookName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBookName.LabelText = "Book\'s Name";
            this.txtBookName.Location = new System.Drawing.Point(45, 99);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Padding = new Wisej.Web.Padding(12);
            this.txtBookName.Size = new System.Drawing.Size(304, 68);
            this.txtBookName.TabIndex = 13;
            this.txtBookName.Watermark = "Enter book\'s name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel1.Location = new System.Drawing.Point(33, 16);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(315, 76);
            this.panel1.TabIndex = 16;
            this.panel1.TabStop = true;
            this.panel1.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend;
            this.cbCategory.AutoSize = false;
            this.cbCategory.CssStyle = "padding: 10px;\r\nborder-radius: 3px;";
            this.cbCategory.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbCategory.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbCategory.Location = new System.Drawing.Point(13, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(302, 42);
            this.cbCategory.TabIndex = 9;
            this.cbCategory.Watermark = "Select book\'s category";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbCourse);
            this.panel2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel2.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel2.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel2.Location = new System.Drawing.Point(33, 174);
            this.panel2.Name = "panel2";
            this.panel2.ShowCloseButton = false;
            this.panel2.ShowHeader = true;
            this.panel2.Size = new System.Drawing.Size(315, 76);
            this.panel2.TabIndex = 17;
            this.panel2.TabStop = true;
            this.panel2.Text = "Course";
            // 
            // cbCourse
            // 
            this.cbCourse.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend;
            this.cbCourse.AutoSize = false;
            this.cbCourse.CssStyle = "padding: 10px;\r\nborder-radius: 3px";
            this.cbCourse.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbCourse.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbCourse.Location = new System.Drawing.Point(13, 3);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(302, 42);
            this.cbCourse.TabIndex = 9;
            this.cbCourse.Watermark = "Select book\'s course";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSub);
            this.panel3.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel3.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel3.Location = new System.Drawing.Point(33, 256);
            this.panel3.Name = "panel3";
            this.panel3.ShowCloseButton = false;
            this.panel3.ShowHeader = true;
            this.panel3.Size = new System.Drawing.Size(315, 76);
            this.panel3.TabIndex = 18;
            this.panel3.TabStop = true;
            this.panel3.Text = "Subscription";
            // 
            // cbSub
            // 
            this.cbSub.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend;
            this.cbSub.AutoSize = false;
            this.cbSub.CssStyle = "padding: 10px;\r\nborder-radius: 3px";
            this.cbSub.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbSub.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbSub.Location = new System.Drawing.Point(13, 3);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(302, 42);
            this.cbSub.TabIndex = 9;
            this.cbSub.Watermark = "Select Subscription";
            // 
            // panelFile
            // 
            this.panelFile.AllowDrag = true;
            this.panelFile.AllowDrop = true;
            this.panelFile.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.panelFile.BackgroundImageSource = "resource.wx/Wisej.Ext.FontAwesome/cloud-upload.svg";
            this.panelFile.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panelFile.Controls.Add(this.upload1);
            this.panelFile.Controls.Add(this.label1);
            this.panelFile.CssStyle = "border-radius: 3px;";
            this.panelFile.ForeColor = System.Drawing.Color.FromArgb(214, 214, 214);
            this.panelFile.Location = new System.Drawing.Point(45, 349);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(303, 85);
            this.panelFile.TabIndex = 19;
            this.panelFile.TabStop = true;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/cloud-upload.svg";
            this.panelFile.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.panelFile.Click += new System.EventHandler(this.panelFile_Click);
            this.panelFile.DragDrop += new Wisej.Web.DragEventHandler(this.panelFile_DragDrop);
            this.panelFile.DragEnter += new Wisej.Web.DragEventHandler(this.panelFile_DragEnter);
            // 
            // upload1
            // 
            this.upload1.Location = new System.Drawing.Point(13, 3);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(73, 25);
            this.upload1.TabIndex = 2;
            this.upload1.Text = "upload1";
            this.upload1.Visible = false;
            this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label1.Location = new System.Drawing.Point(67, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag file over or click to upload";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnSave.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.Location = new System.Drawing.Point(46, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(304, 42);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 529);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelFile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBookName);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.HeaderBackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.IconSource = "resource.wx/Wisej.Ext.FontAwesome/book.svg";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Books";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.FormClosed += new Wisej.Web.FormClosedEventHandler(this.Books_FormClosed);
            this.Appear += new System.EventHandler(this.Books_Appear);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox txtBookName;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.ComboBox cbCategory;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.ComboBox cbCourse;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.ComboBox cbSub;
        private Wisej.Web.Panel panelFile;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button btnSave;
        private Wisej.Web.Upload upload1;
    }
}