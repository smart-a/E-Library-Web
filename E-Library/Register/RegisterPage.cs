using E_Library.Data;
using E_Library.Models;
using System;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace E_Library.Register
{
    public partial class RegisterPage : Form
    {
        ApplicationDbContext _context;

        public RegisterPage()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidInput())
                {
                    MessageBox.Show("All fields are required");
                    return;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password not matched");
                    txtConfirmPassword.Focus();
                    return;
                }

                User user = new User
                {
                    Fullname = txtFullname.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Gender = radioMale.Checked ? "Male" : "Female",
                    UserType = User.UserEnum.Member,
                    Password = EncryptPass(txtPassword.Text)
                };

                if (UserExists(user))
                {
                    MessageBox.Show("User with this email already exist");
                    txtEmail.Focus();
                    return;
                }

                _context.Users.Add(user);
                _context.SaveChanges();
                MessageBox.Show("WOW! Your registration is successful, Login to continue");
                Application.Navigate("/Login");
            }
            catch
            {
                MessageBox.Show("Some errors occur, please try again");
            }
        }

        private bool IsValidInput()
        {
            if (txtFullname.Text == "")
            {
                txtFullname.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                return false;
            }
            if (txtPhone.Text == "")
            {
                txtPhone.Focus();
                return false;
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private bool UserExists(User user)
        {
            return _context.Users.Any((e) => e.Email == user.Email);
        }

        private string EncryptPass(string Password)
        {
            byte[] encode = new byte[Password.Length];
            encode = Encoding.UTF8.GetBytes(Password);
            return Convert.ToBase64String(encode);
        }
    }
}
