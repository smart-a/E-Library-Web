using E_Library.Admin.Dashboard.Components;
using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace E_Library.Admin.Dashboard
{
    public partial class BooksControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        Object MyParent;

        public BooksControl(object Owner)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            MyParent = Owner;
        }

        public void LoadBooks(List<Book> param = null)
        {
            var bookList = param;
            if (bookList == null || bookList.Count < 1)
            {
                _context = new ApplicationDbContext();
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

            var buttonCol = new DataGridViewImageColumn(); //DataGridViewButtonColumn
            buttonCol.Name = "ViewBook";
            buttonCol.HeaderText = "View";
            buttonCol.CellImageSource = "resource.wx/Wisej.Ext.FontAwesome/eye.svg";
            dataGridView1.Columns.Add(buttonCol);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Books book = new Books(this);
            book.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = Guid.Parse(dataGridView1.CurrentRow[0].Value.ToString());
            var currentBook = _context.Books.SingleOrDefault((b) => b.Id == index);
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
                        DeleteSavedBook(currentBook.BookPath);
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
            var search = txtSearch.Text;
            if (search == "")
            {
                LoadBooks();
                return;
            }
            var bookList = _context.Books.ToList();
            bookList = bookList.Where((b) =>
               b.BookName.StartsWith(search, StringComparison.OrdinalIgnoreCase) ||
               b.Category.CategoryName.StartsWith(search, StringComparison.OrdinalIgnoreCase)).ToList();

            LoadBooks(bookList);
        }

        private void DeleteSavedBook(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ViewBook"].Index)
            {
                var Id = Guid.Parse(dataGridView1.CurrentRow[0].Value.ToString());
                var currentBook = _context.Books.SingleOrDefault((b) => b.Id == Id);

                var parent = (AdminDashboard)MyParent;
                BookView bookView = new BookView(currentBook.BookPath);
                parent.NavigateMenu(bookView);
            }
        }
    }
}
