
namespace E_Library.Dashboard
{
    partial class BookView
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
            Wisej.Web.JavaScript.ClientEvent clientEvent1 = new Wisej.Web.JavaScript.ClientEvent();
            this.pdfViewer1 = new Wisej.Web.PdfViewer();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            clientEvent1.Event = "copy";
            clientEvent1.JavaScript = "return false;";
            this.pdfViewer1.ClientEvents.Add(clientEvent1);
            this.pdfViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.pdfViewer1.Enabled = false;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(800, 516);
            this.pdfViewer1.TabIndex = 0;
            // 
            // BookView
            // 
            this.Controls.Add(this.pdfViewer1);
            this.Name = "BookView";
            this.Size = new System.Drawing.Size(800, 516);
            this.Appear += new System.EventHandler(this.BookView_Appear);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.PdfViewer pdfViewer1;
    }
}
