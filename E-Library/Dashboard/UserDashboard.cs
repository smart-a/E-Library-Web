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

        public void LoadStatus()
        {
            var bookmarks = _context.Bookmarks.Where((b) => b.User.Id == currentUser.Id).Count();
            navBookmark.InfoText = $" {bookmarks.ToString()} ";

            _context = new ApplicationDbContext();
            var userSub = _context.UserSubscriptions.SingleOrDefault((s) => s.User.Id == currentUser.Id &&
                    s.SubStatus == 1);

            var subBooks = 0;
            if (userSub != null)
            {
                subBooks = _context.Books.Where((b) => b.Subscription.Id == userSub.Id).Count();
            }
            navLibrary.InfoText = $" {subBooks.ToString()} ";
        }

        private void UserDashboard_Appear(object sender, EventArgs e)
        {
            IndexControl control = new IndexControl(this, currentUser);
            NavigateMenu(control);

            if (currentUser.UserType == User.UserEnum.Student)
            {
                btnUser.MenuItems["menuProfile"].Visible = false;
            }

            LoadStatus();

        }

        public void NavigateMenu(Control control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);

            btnNavShow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/bars.svg";
            navigationBar1.CompactView = true;
            btnNavShow.Tag = "show";
        }

        private void navDashboard_Click(object sender, EventArgs e)
        {
            IndexControl control = new IndexControl(this, currentUser);
            NavigateMenu(control);
        }

        private void navBookmark_Click(object sender, EventArgs e)
        {
            BookmarksControl control = new BookmarksControl(this, currentUser);
            NavigateMenu(control);
        }

        private void navLibrary_Click(object sender, EventArgs e)
        {
            LibrayControl control = new LibrayControl(this, currentUser);
            NavigateMenu(control);
        }

        private void btnUser_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
        {
            if(e.Item.Name == "menuProfile")
            {
                ProfileControl control = new ProfileControl(currentUser);
                NavigateMenu(control);
            }

            if(e.Item.Name == "menuLogout")
            {
                Application.Browser.LocalStorage.RemoveValue("e_library");
                Application.Navigate("/");
            }
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            btnUser.MenuItems[0].Text = currentUser.Fullname;
            btnUser.MenuItems[0].IconSource = "resource.wx/Wisej.Ext.FontAwesome/user.svg";
        }
    }
}
