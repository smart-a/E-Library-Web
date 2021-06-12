
namespace E_Library.Dashboard.Components
{
    partial class BookDetails
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
            this.lblBookName = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            this.lblCategory = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.lblCourse = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.panel3 = new Wisej.Web.Panel();
            this.lblSub = new Wisej.Web.Label();
            this.label7 = new Wisej.Web.Label();
            this.btnView = new Wisej.Web.Button();
            this.cbBookmark = new Wisej.Web.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.AutoEllipsis = true;
            this.lblBookName.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBookName.Location = new System.Drawing.Point(34, 3);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(382, 71);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "BOOK NAME";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 44);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategory.Location = new System.Drawing.Point(144, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(228, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Category:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel2.Controls.Add(this.lblCourse);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(34, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 44);
            this.panel2.TabIndex = 2;
            this.panel2.TabStop = true;
            // 
            // lblCourse
            // 
            this.lblCourse.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse.Location = new System.Drawing.Point(144, 11);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(228, 23);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Category Name";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Course:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel3.Controls.Add(this.lblSub);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(34, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 44);
            this.panel3.TabIndex = 3;
            this.panel3.TabStop = true;
            // 
            // lblSub
            // 
            this.lblSub.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSub.Location = new System.Drawing.Point(144, 11);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(228, 23);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Sub Name";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Group Sub:";
            // 
            // btnView
            // 
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/eye.svg";
            this.btnView.Location = new System.Drawing.Point(37, 239);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(44, 28);
            this.btnView.TabIndex = 5;
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cbBookmark
            // 
            this.cbBookmark.Appearance = Wisej.Web.Appearance.Switch;
            this.cbBookmark.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBookmark.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbBookmark.Location = new System.Drawing.Point(283, 239);
            this.cbBookmark.Name = "cbBookmark";
            this.cbBookmark.Size = new System.Drawing.Size(133, 24);
            this.cbBookmark.TabIndex = 6;
            this.cbBookmark.Text = "Bookmark";
            this.cbBookmark.Click += new System.EventHandler(this.cbBookmark_Click);
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 287);
            this.Controls.Add(this.cbBookmark);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBookName);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.HeaderBackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.IconSource = "resource.wx/Wisej.Ext.FontAwesome/book.svg";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookDetails";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Book Details";
            this.Appear += new System.EventHandler(this.BookDetails_Appear);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label lblBookName;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label lblCategory;
        private Wisej.Web.Label label2;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label lblCourse;
        private Wisej.Web.Label label5;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Label lblSub;
        private Wisej.Web.Label label7;
        private Wisej.Web.Button btnView;
        private Wisej.Web.CheckBox cbBookmark;
    }
}