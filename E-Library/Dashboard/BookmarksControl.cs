using E_Library.Dashboard.Components;
using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace E_Library.Dashboard
{
    public partial class BookmarksControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        User currentUser;
        object MyParent;

        public BookmarksControl(object Owner, User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentUser = user;
            MyParent = Owner;
        }

        private void BookmarksControl_Load(object sender, EventArgs e)
        {

        }

        private void BookmarksControl_Appear(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategories();
        }

        public void LoadBooks(List<Bookmark> param = null)
        {
            var bookmarkList = param;
            if (bookmarkList == null || bookmarkList.Count < 1)
            {
                bookmarkList = _context.Bookmarks.Where((b) => b.User.Id == currentUser.Id).ToList();
            }

            var books = bookmarkList.Select((b) =>
                 new BookDisplay
                 {
                     Id = b.Book.Id,
                     Category = b.Book.Category.CategoryName,
                     BookName = b.Book.BookName,
                     Course = b.Book.Course.CourseName,
                     Subscription = b.Book.Subscription.SubscriptionName,
                     Amount = b.Book.Subscription.Amount.ToString("###,##0.00")
                 }).ToList();

            //usersList = new BindingList<object>(users);

            dataGridView1.DataSource = books;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["BookName"].HeaderText = "Book Name";
            dataGridView1.Columns["BookName"].Width = 150;

        }

        private void LoadCategories()
        {
            _context = new ApplicationDbContext();
            _context = new ApplicationDbContext();
            var categoryList = _context.Categories.Select((c) => c.CategoryName).ToList();
            categoryList.Insert(0, "All");
            cbCategory.DataSource = categoryList;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var Id = Guid.Parse(dataGridView1.CurrentRow[0].Value.ToString());
            var currentBook = _context.Books.SingleOrDefault((b) => b.Id == Id);
            if (currentBook != null)
            {
                BookDetails bookDetails = new BookDetails(MyParent, currentUser, currentBook);
                bookDetails.ShowDialog();
                LoadBooks();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text == "")
            {
                LoadBooks();
                return;
            }
            var bookmarkList = _context.Bookmarks.ToList();
            bookmarkList = bookmarkList.Where((b) => b.User.Id == currentUser.Id &&
           b.Book.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            LoadBooks(bookmarkList);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cbCategory.SelectedIndex == 0)
            {
                LoadBooks();
                return;
            }
            var bookmarkList = _context.Bookmarks.Where((b) => b.User.Id == currentUser.Id &&
                b.Book.Category.CategoryName == cbCategory.Text).ToList();
            LoadBooks(bookmarkList);
        }
    }
}
