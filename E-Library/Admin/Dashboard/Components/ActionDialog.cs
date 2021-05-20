using System;
using Wisej.Web;

namespace E_Library.Admin.Dashboard.Components
{
    public partial class ActionDialog : Form
    {
        public ActionDialog()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = btnUpdate.DialogResult;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = btnDelete.DialogResult;
        }
    }
}
