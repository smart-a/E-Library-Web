using E_Library.Data;
using E_Library.Models;
using System;
using System.Linq;
using Wisej.Web;

namespace E_Library.Dashboard
{
    public partial class UserDashboard : Form
    {
        ApplicationDbContext _context;
        User currentUser;

        public UserDashboard(User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentUser = user;
        }

        private void btnNavShow_Click(object sender, EventArgs e)
        {
            if (btnNavShow.Tag.ToString() == "show")
            {
                btnNavShow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/times.svg";
                //navigationBar1.Width = 350;
                navigationBar1.CompactView = false;
                btnNavShow.Tag = "hide";
            }
            else if (btnNavShow.Tag.ToString() == "hide")
            {
                btnNavShow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/bars.svg";
                //navigationBar1.Width = 0;
                navigationBar1.CompactView = true;
                btnNavShow.Tag = "show";
            }
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            btnUser.MenuItems.Add(0, new MenuItem
            {
                Text = currentUser.Fullname,
                Enabled = false,
                IconSource = "resource.wx/Wisej.Ext.FontAwesome/user.svg"
            });

            if(currentUser.UserType == User.UserEnum.Student)
            {
                btnUser.MenuItems["menuProfile"].Visible = false;
            }

            LoadStatus();
        }

        public void LoadStatus()
        {
            var bookmarks = _context.Bookmarks.Where((b) => b.User.Id == currentUser.Id).Count();
            navBookmark.InfoText = bookmarks.ToString();

            _context = new ApplicationDbContext();
            var userSub = _context.UserSubscriptions.SingleOrDefault((s) => s.User.Id == currentUser.Id &&
                    s.SubStatus == 1);

            _context = new ApplicationDbContext();
            var subBooks = _context.Books.Where((b) => b.Subscription.Id == userSub.Id).Count();
            navLibrary.InfoText = subBooks.ToString();
        }
    }
}
