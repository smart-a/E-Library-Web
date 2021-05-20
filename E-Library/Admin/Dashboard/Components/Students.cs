using E_Library.Data;
using E_Library.Models;
using System;
using System.Linq;
using Wisej.Web;

namespace E_Library.Admin.Dashboard.Components
{
    public partial class Students : Form
    {
        ApplicationDbContext _context;
        object MyParent;
        User _user;

        public Students(object Owner, User user = null)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            MyParent = Owner;
            _user = user;
        }

        private void Students_Load(object sender, EventArgs e)
        {
            if (_user != null)
            {
                txtStudentNumber.Text = _user.Fullname;
                txtStudentNumber.ReadOnly = true;
                txtFullname.Text = _user.Fullname;
                var _ = _user.Gender == "Male" ? radioMale.Checked = true : radioFemale.Checked = true;
                cbLevel.Text = _user.Level.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidInput())
                {
                    MessageBox.Show("All fields are required");
                    return;
                }

                if (_user == null)
                {
                    User user = new User
                    {
                        StudentNumber = txtStudentNumber.Text,
                        Fullname = txtFullname.Text,
                        Gender = radioMale.Checked ? "Male" : "Female",
                        Level = int.Parse(cbLevel.Text),
                        UserType = User.UserEnum.Student
                    };

                    if (UserExists(user))
                    {
                        MessageBox.Show("User with this number already exist");
                        txtStudentNumber.Focus();
                        return;
                    }

                    _context.Users.Add(user);
                    _context.SaveChanges();
                    MessageBox.Show("New record saved");
                    ClearInput();
                }
                else
                {
                    _user.Fullname = txtFullname.Text;
                    _user.Gender = radioMale.Checked ? "Male" : "Female";
                    _user.Level = int.Parse(cbLevel.Text);
                    _user.UserType = User.UserEnum.Student;
                    _context.Entry(_user).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    MessageBox.Show("Student record updated");
                    this.Dispose();
                }

            }
            catch
            {
                MessageBox.Show("Some errors occur, please try again");
            }
        }

        private bool IsValidInput()
        {

            if (txtStudentNumber.Text == "")
            {
                txtStudentNumber.Focus();
                return false;
            }
            if (txtFullname.Text == "")
            {
                txtFullname.Focus();
                return false;
            }
            if (cbLevel.Text == "")
            {
                cbLevel.Focus();
                return false;
            }
            return true;
        }

        private void ClearInput()
        {
            txtStudentNumber.Clear();
            txtFullname.Clear();
            cbLevel.Text = "";
            radioMale.Checked = true;
            txtStudentNumber.Focus();
        }

        private bool UserExists(User user)
        {
            return _context.Users.Any((e) => e.StudentNumber == user.StudentNumber);
        }

        private void Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            var parent = (StudentsControl)MyParent;
            parent.LoadUsers();
        }
    }
}
