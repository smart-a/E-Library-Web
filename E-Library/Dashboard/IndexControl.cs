using E_Library.Dashboard.Components;
using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace E_Library.Dashboard
{
    public partial class IndexControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        User currentUser;
        object MyParent;

        public IndexControl(object Owner, User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentUser = user;
            MyParent = Owner;
        }

        private void IndexControl_Load(object sender, EventArgs e)
        {
            lblWallet.Text = currentUser.Wallet.ToString("N###,##0.00");

            var bookmarks = _context.Bookmarks.Where((b) => b.User.Id == currentUser.Id).Count();
            lblBookmark.Text = bookmarks.ToString();
        }

        private void IndexControl_Appear(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categoryList = _context.Categories.Select((c) => c.CategoryName).ToList();
            categoryList.Insert(0, "All");
            cbCategory.DataSource = categoryList;
        }

        public void LoadBooks(List<Book> param = null)
        {
            var bookList = param;
            if (bookList == null || bookList.Count < 1)
            {
                bookList = _context.Books.ToList();
            }

            var books = bookList.Select((b) =>
                 new BookDisplay
                 {
                     Id = b.Id,
                     Category = b.Category.CategoryName,
                     BookName = b.BookName,
                     Course = b.Course.CourseName,
                     Subscription = b.Subscription.SubscriptionName,
                     Amount = b.Subscription.Amount.ToString("###,##0.00")
                 }).ToList();

            dataGridView1.DataSource = books;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["BookName"].HeaderText = "Book Name";
            dataGridView1.Columns["BookName"].Width = 150;

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var Id = Guid.Parse(dataGridView1.CurrentRow[0].Value.ToString());
            var currentBook = _context.Books.SingleOrDefault((b) => b.Id == Id);
            if (currentBook != null)
            {
                BookDetails bookDetails = new BookDetails(MyParent, currentUser, currentBook);
                bookDetails.ShowDialog();
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
            var bookList = _context.Books.ToList();
            bookList = bookList.Where((b) =>
                b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            LoadBooks(bookList);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cbCategory.SelectedIndex == 0)
            {
                LoadBooks();
                return;
            }
            var bookList = _context.Books.Where((b) => b.Category.CategoryName == cbCategory.Text).ToList();
            LoadBooks(bookList);
        }
    }
}
