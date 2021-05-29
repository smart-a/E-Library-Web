using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using E_Library.Dashboard.Components;
using E_Library.Data;
using E_Library.Models;

namespace E_Library.Dashboard
{
    public partial class LibrayControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        User currentUser;
        UserSubscription currentSub;
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
            if(currentUser.UserType == User.UserEnum.Student)
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
                _context = new ApplicationDbContext();
                subBookList = _context.Books.Where((b) => b.Subscription.Id == currentSub.Subscription.Id).ToList();
                if(currentUser.UserType == User.UserEnum.Student)
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
            _context = new ApplicationDbContext();
            var categoryList = _context.Categories.ToList();

            cbCategory.DataSource = categoryList.Select((c) => c.CategoryName);
            cbCategory.Items.Insert(0, "All");
        }

        public void LoadSub()
        {
            currentSub = _context.UserSubscriptions.SingleOrDefault((b) =>
                    b.User.Id == currentUser.Id && b.SubStatus == 1);


            if (currentSub == null)
            {
                tagTextSub.Text = "No active subscription";
                panelSubBook.Enabled = false;
                return;
            }

            CheckSub();
            LoadCategories();
            LoadBooks();
        }

        private void CheckSub()
        {
            var dateDiff = (DateTime.Now - currentSub.SubDate).Days;
            if (dateDiff > 0)
            {
                currentSub.SubStatus = 0;
                _context.Entry(currentSub).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }

            tagTextSub.Text = currentSub.Subscription.SubscriptionName;
            panelSubBook.Enabled = true;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cbCategory.SelectedIndex == 0)
            {
                LoadBooks();
                return;
            }
            var subBookList = _context.Books.Where((b) => b.Subscription.Id == currentSub.Subscription.Id &&
                b.Category.CategoryName == cbCategory.Text).ToList();
            if (currentUser.UserType == User.UserEnum.Student)
            {
                subBookList = _context.Books.Where((b) => b.Category.CategoryName == cbCategory.Text).ToList();
            }
            LoadBooks(subBookList);
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
            var subBookList = _context.Books.Where((b) => b.Subscription.Id == currentSub.Subscription.Id &&
               b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            if (cbCategory.SelectedIndex >1)
            {
                subBookList = _context.Books.Where((b) => b.Subscription.Id == currentSub.Subscription.Id &&
                b.Category.CategoryName == cbCategory.Text &&
                b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (currentUser.UserType == User.UserEnum.Student)
            {
                subBookList = _context.Books.Where((b) => b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                if (cbCategory.SelectedIndex > 1)
                {
                    subBookList = _context.Books.Where((b) => b.Category.CategoryName == cbCategory.Text &&
                    b.BookName.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }
            }
            LoadBooks(subBookList);
        }

        private void btnNewSub_Click(object sender, EventArgs e)
        {
            SubscriptionForm form = new SubscriptionForm(this, currentUser);
            form.ShowDialog();
        }
    }
}
