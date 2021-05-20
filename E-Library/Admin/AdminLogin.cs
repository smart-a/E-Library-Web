using System;
using Wisej.Web;
using E_Library.Data;
using E_Library.Models;
using E_Library.Helper;
using System.Linq;

namespace E_Library.Admin
{
    public partial class AdminLogin : Form
    {
        ApplicationDbContext _context;

        public AdminLogin()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            HandleLogin();
        }

        private void HandleLogin()
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                return;
            }

            try
            {
                var admin = _context.UsersAccounts.SingleOrDefault((u) =>
                          u.Username == txtUsername.Text && u.Password == txtPassword.Text);

                if (admin != null)
                {
                    DisplayMsg("Login successful, Redirecting to Dashboard...", false);
                    JwtToken.GenerateToken(admin, (token) =>
                     {
                         Application.Browser.LocalStorage.SetValue("e_library_admin", token);
                         Application.Navigate("/Admin/Dashboard");
                     });
                }
                else
                {
                    DisplayMsg("Account not found");
                }
            }
            catch
            {
                MessageBox.Show("Some error occur");
            }
        }

        private void DisplayMsg(string message, bool displayCloseButton = true)
        {
            panelMsg.Visible = true;
            lblMsg.Text = message;
            btnCloseMsg.Visible = displayCloseButton;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                HandleLogin();
            }
        }
    }
}
