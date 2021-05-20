using System;
using Wisej.Web;

namespace E_Library.Shared
{
    public partial class DefaultHeader : Wisej.Web.UserControl
    {
        public DefaultHeader()
        {
            InitializeComponent();
        }

        private void DefaultHeader_Load(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Application.Navigate("/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Tag.ToString() == "register")
                Application.Navigate("/Register");
            else
                Application.Navigate("/Login");
        }
    }
}
