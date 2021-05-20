using E_Library.Admin.Dashboard.Components;
using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace E_Library.Admin.Dashboard
{
    public partial class BooksControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;

        public BooksControl()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        public void LoadBooks(List<Book> param = null)
        {
            var bookList = param;
            if (bookList == null || bookList.Count < 1)
            {
                bookList = _context.Books.ToList();
            }

           var books = bookList.Select((b) =>
                new
                {
                    b.Id,
                    Category = b.Category.CategoryName,
                    b.BookName,
                    Course = b.Course.CourseName,
                    Subscription = b.Subscription.SubscriptionName,
                    Amount = b.Subscription.Amount.ToString("###,##0.00")
                }).ToList<object>();

            //usersList = new BindingList<object>(users);

            dataGridView1.DataSource = books;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["BookName"].HeaderText = "Book Name";
            dataGridView1.Columns["BookName"].Width = 150;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Books book = new Books(this);
            book.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentBook = (Book)dataGridView1.CurrentRow.DataBoundItem;
            if (currentBook != null)
            {
                DialogResult dialogResult;
                ActionDialog popup = new ActionDialog();
                dialogResult = popup.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    Books bookForm = new Books(this, currentBook);
                    bookForm.ShowDialog();
                }
                else if (dialogResult == DialogResult.Abort)
                {
                    var actionResult =
                       MessageBox.Show("Remove book's record", "Delete",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (actionResult == DialogResult.OK)
                    {
                        _context.Books.Remove(currentBook);
                        _context.SaveChanges();
                        MessageBox.Show("Book's record deleted");
                        LoadBooks();
                    }
                }

            }
        }

        private void BooksControl_Appear(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var bookList = _context.Books.Where((b) =>
                b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                b.Category.CategoryName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            LoadBooks(bookList);
        }
    }
}
