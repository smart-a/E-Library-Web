using E_Library.Data;
using E_Library.Models;
using System;
using System.Linq;
using Wisej.Web;

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
            this.Text += $" - {_book.BookName}";
            lblBookName.Text = _book.BookName.ToUpper();
            lblCategory.Text = _book.Category.CategoryName;
            lblCourse.Text = _book.Course.CourseName;
            lblSub.Text = _book.Subscription.SubscriptionName;
            if (_bookmark != null)
            {
                cbBookmark.Checked = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (_user.UserType == User.UserEnum.Member)
            {
                var IsAccessible = _context.UserSubscriptions.Any(
                    (s) => s.User.Id == _user.Id && s.Subscription.Id == _book.Subscription.Id &&
                        s.SubStatus == 1);

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
                var user = _context.Users.SingleOrDefault((u) => u.Id == _user.Id);
                var book = _context.Books.SingleOrDefault((b) => b.Id == _book.Id);
                var bookmark = new Bookmark
                {
                    User = user,
                    Book = book
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
