using System;
using Wisej.Web;

namespace E_Library.Login
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            defaultHeader1.btnLogin.Text = "Register";
            defaultHeader1.btnLogin.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/add-user-button.svg";
            defaultHeader1.btnLogin.Tag = "register";
        }
    }
}
