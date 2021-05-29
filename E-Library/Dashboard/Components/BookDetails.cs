using E_Library.Data;
using E_Library.Models;
using System;
using Wisej.Web;
using System.Linq;

namespace E_Library.Dashboard.Components
{
    public partial class BookDetails : Form
    {
        ApplicationDbContext _context;
        User _user;
        Book _book;
        Bookmark _bookmark;
        object MyParent;

        public BookDetails(object Owner, User user, Book book)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _user = user;
            _book = book;
            MyParent = Owner;
        }

        private void CheckBookmarked()
        {
            _bookmark = _context.Bookmarks.SingleOrDefault(
                (b) => b.Book.Id == _book.Id && b.User.Id == _user.Id);
        }

        private void BookDetails_Appear(object sender, EventArgs e)
        {
            CheckBookmarked();
            this.Text += $" {_book.BookName}";
            lblBookName.Text = _book.BookName;
            lblCategory.Text = _book.Category.CategoryName;
            lblCourse.Text = _book.Course.CourseName;
            lblSub.Text = _book.Subscription.SubscriptionName;
            lblAmount.Text = _book.Subscription.Amount.ToString("###,##0.00");
            if (_bookmark != null)
            {
                cbBookmark.Checked = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (_user.UserType == User.UserEnum.Member)
            {
                //_context = new ApplicationDbContext();
                var IsAccessible = _context.UserSubscriptions.Any(
                    (b) => b.User.Id == _user.Id && b.Subscription.Id == _book.Subscription.Id);

                if (!IsAccessible)
                {
                    MessageBox.Show("This book is not accessible by your current subscription");
                    return;
                }
            }

            this.Dispose();
            var parent = (UserDashboard)MyParent;
            BookView bookView = new BookView(_book.BookPath);
            parent.NavigateMenu(bookView);
        }

        private void cbBookmark_Click(object sender, EventArgs e)
        {
            if (cbBookmark.Checked)
            {
                var bookmark = new Bookmark
                {
                    User = _user,
                    Book = _book
                };
                _context.Bookmarks.Add(bookmark);
                _context.SaveChanges();
                _bookmark = bookmark;

            }
            else
            {
                _context.Bookmarks.Remove(_bookmark);
                _context.SaveChanges();
            }
        }
    }
}
