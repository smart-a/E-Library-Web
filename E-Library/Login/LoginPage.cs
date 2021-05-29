using E_Library.Data;
using E_Library.Helper;
using System;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace E_Library.Login
{
    public partial class LoginPage : Form
    {
        ApplicationDbContext _context;

        public LoginPage()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            defaultHeader1.btnLogin.Text = "Register";
            defaultHeader1.btnLogin.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/add-user-button.svg";
            defaultHeader1.btnLogin.Tag = "register";
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleProceed();
        }

        private void HandleProceed()
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
                var pass = EncryptPass(txtPassword.Text);
                var user = _context.Users.SingleOrDefault(
                    (u) => u.StudentNumber == txtUsername.Text && u.Level.ToString() == txtPassword.Text ||
                     txtUsername.Text == u.Email && pass == u.Password);

                if (user == null)
                {
                    DisplayMsg("Account not found");

                    return;
                }

                DisplayMsg("Login successful, redirecting to dashboard", false);
                JwtToken.GenerateToken(user, (token) =>
                {
                    Application.Browser.LocalStorage.SetValue("e_library", token);
                    Application.Navigate("/Dashboard");
                });


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HandleProceed();
        }

        private void DisplayMsg(string message, bool displayCloseButton = true)
        {
            panelMsg.Visible = true;
            lblMsg.Text = message;
            btnCloseMsg.Visible = displayCloseButton;
        }

        private string EncryptPass(string Password)
        {
            byte[] encode = new byte[Password.Length];
            encode = Encoding.UTF8.GetBytes(Password);
            return Convert.ToBase64String(encode);
        }
    }
}

