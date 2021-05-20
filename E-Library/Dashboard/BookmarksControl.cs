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

        public BookmarksControl(User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentUser = user;
        }

        private void BookmarksControl_Load(object sender, EventArgs e)
        {
            _context = new ApplicationDbContext();
            var categoryList = _context.Categories.ToList();

            cbCategory.DataSource = categoryList.Select((c) => c.CategoryName);
            cbCategory.Items.Insert(0, "All");
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
                 new
                 {
                     b.Id,
                     Category = b.Book.Category.CategoryName,
                     BookName = b.Book.BookName,
                     Course = b.Book.Course.CourseName,
                     Subscription = b.Book.Subscription.SubscriptionName,
                     Amount = b.Book.Subscription.Amount.ToString("###,##0.00")
                 }).ToList<object>();

            //usersList = new BindingList<object>(users);

            dataGridView1.DataSource = books;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["BookName"].HeaderText = "Book Name";
            dataGridView1.Columns["BookName"].Width = 150;

        }

        private void LoadCategories()
        {
            _context = new ApplicationDbContext();
            var categoryList = _context.Categories.ToList();

            cbCategory.DataSource = categoryList.Select((c) => c.CategoryName);
            cbCategory.Items.Insert(0, "All");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentBook = (Book)dataGridView1.CurrentRow.DataBoundItem;
            if (currentBook != null)
            {

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var bookmarkList = _context.Bookmarks.Where((b) => b.User.Id == currentUser.Id &&
               b.Book.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            LoadBooks(bookmarkList);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if(cbCategory.SelectedIndex == 0)
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
