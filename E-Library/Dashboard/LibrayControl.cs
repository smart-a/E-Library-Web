using E_Library.Dashboard.Components;
using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace E_Library.Dashboard
{
    public partial class LibrayControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        User currentUser;
        List<UserSubscription> currentSub;
        object MyParent;

        public LibrayControl(object Owner, User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentUser = user;
            MyParent = Owner;
        }

        private void LibrayControl_Load(object sender, EventArgs e)
        {
            if (currentUser.UserType == User.UserEnum.Student)
            {
                panelSub.Enabled = false;
            }
        }

        private void LibrayControl_Appear(object sender, EventArgs e)
        {
            LoadSub();
        }

        public void LoadBooks(List<Book> param = null)
        {
            var subBookList = param;
            if (subBookList == null || subBookList.Count < 1)
            {
                subBookList = new List<Book>();
                currentSub.ForEach((s) =>
                {
                    var book = _context.Books.Where((b) => b.Subscription.Id == s.Subscription.Id);
                    subBookList.AddRange(book);
                });

                if (currentUser.UserType == User.UserEnum.Student)
                {
                    subBookList = _context.Books.ToList();
                }
            }

            var books = subBookList.Select((b) =>
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

        private void LoadCategories()
        {
            var categoryList = _context.Categories.Select((c) => c.CategoryName).ToList();
            categoryList.Insert(0, "All");
            cbCategory.DataSource = categoryList;
        }

        public void LoadSub()
        {
            currentSub = _context.UserSubscriptions.Where((s) =>
                    s.User.Id == currentUser.Id && s.SubStatus == 1).ToList();

            if (currentSub.Count < 1)
            {
                tagTextSub.Text = "No active subscription";
                panelSubBook.Enabled = false;
                return;
            }

            var subArray = currentSub.Select((s) => s.Subscription.SubscriptionName).ToArray();
            tagTextSub.Text = string.Join(",", subArray);
            panelSubBook.Enabled = true;

            LoadCategories();
            LoadBooks();
        }

        private void cbCategory_SelectedItemChanged(object sender, EventArgs e)
        {
            if (cbCategory.Items.Count > 0)
            {
                txtSearch.Clear();
                if (cbCategory.SelectedIndex == 0)
                {
                    LoadBooks();
                    return;
                }

                var subBookList = new List<Book>();
                currentSub.ForEach((s) =>
                {
                    var book = _context.Books.Where((b) => b.Subscription.Id == s.Subscription.Id &&
                        b.Category.CategoryName == cbCategory.Text);
                    subBookList.AddRange(book);
                });

                if (currentUser.UserType == User.UserEnum.Student)
                {
                    subBookList = _context.Books.Where((b) => b.Category.CategoryName == cbCategory.Text).ToList();
                }
                LoadBooks(subBookList);
            }
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
            var subBookList = new List<Book>();
            currentSub.ForEach((s) =>
            {
                var book = _context.Books.ToList();
                book = book.Where((b) => b.Subscription.Id == s.Subscription.Id &&
                    b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                subBookList.AddRange(book);
            });

            if (cbCategory.SelectedIndex > 1)
            {
                subBookList = new List<Book>();
                currentSub.ForEach((s) =>
                {
                    var book = _context.Books.ToList();
                    book = book.Where((b) => b.Subscription.Id == s.Subscription.Id &&
                        b.Category.CategoryName == cbCategory.Text &&
                        b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                    subBookList.AddRange(book);
                });
            }

            if (currentUser.UserType == User.UserEnum.Student)
            {
                subBookList = _context.Books.ToList();
                subBookList = subBookList.Where((b) => b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                if (cbCategory.SelectedIndex > 1)
                {
                    subBookList = _context.Books.ToList();
                    subBookList = subBookList.Where((b) => b.Category.CategoryName == cbCategory.Text &&
                    b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }
            }
            LoadBooks(subBookList);
        }

        private void btnNewSub_Click(object sender, EventArgs e)
        {
            SubscriptionForm form = new SubscriptionForm(this, currentUser);
            form.ShowDialog();
            LoadSub();
            var parent = (UserDashboard)MyParent;
            parent.LoadStatus();
        }

    }
}
