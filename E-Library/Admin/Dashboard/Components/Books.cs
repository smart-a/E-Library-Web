using System;
using System.Web;
using Wisej.Web;
using System.IO;
using E_Library.Models;
using E_Library.Data;
using System.Collections.Generic;
using System.Linq;

namespace E_Library.Admin.Dashboard.Components
{
    public partial class Books : Form
    {
        ApplicationDbContext _context;
        HttpFileCollection files = null;
        List<Category> categoryList;
        List<Course> courseList;
        List<Subscription> subList;
        object MyParent;
        Book _book;

        public Books(object owner, Book book = null)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            MyParent = owner;
            _book = book;
        }

        private void Books_Load(object sender, EventArgs e)
        {
            if (_book != null)
            {
                _book = _context.Books.SingleOrDefault((b) => b.Id == _book.Id);

                cbCategory.Text = _book.Category.CategoryName;
                txtBookName.Text = _book.BookName;
                cbCourse.Text = _book.Course.CourseName;
                cbSub.Text = _book.Subscription.SubscriptionName;
            }
        }

        private void Books_Appear(object sender, EventArgs e)
        {
            LoadLists();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                MessageBox.Show("All fields are required");
                return;
            }
            try
            {
                _context = new ApplicationDbContext();
                if (_book == null)
                {
                    Book book = new Book
                    {
                        Category = categoryList[cbCategory.SelectedIndex],
                        BookName = txtBookName.Text,
                        Course = courseList[cbCourse.SelectedIndex],
                        Subscription = subList[cbSub.SelectedIndex]
                    };
                    string ext = Path.GetExtension(files.ToString());
                    book.BookPath = $"~/Books/{book.Id}.{ext}";
                    UploadBook(files, book.BookPath);

                    _context.Books.Add(book);
                    _context.SaveChanges();
                    MessageBox.Show("New book added");
                    ClearInput();
                }
                else
                {
                    _book.Category = categoryList[cbCategory.SelectedIndex];
                    _book.BookName = txtBookName.Text;
                    _book.Course = courseList[cbCourse.SelectedIndex];
                    _book.Subscription = subList[cbSub.SelectedIndex];

                    string ext = Path.GetExtension(files.ToString());
                    _book.BookPath = $"~/Books/{_book.Id}.{ext}";
                    UploadBook(files, _book.BookPath);

                    _context.Entry(_book).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    MessageBox.Show("Book record updated");
                    this.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Some error occur");
            }
        }

        private void panelFile_DragEnter(object sender, DragEventArgs e)
        {
            string file = (string)e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show(file);
            if (file.IndexOf("/pdf") > -1)
            {
                e.Effect = DragDropEffects.Copy;
                return;
            }
            e.Effect = DragDropEffects.None;
        }

        private void panelFile_DragDrop(object sender, DragEventArgs e)
        {
            files = (HttpFileCollection)e.Data.GetData(DataFormats.Files);
        }

        private void UploadBook(HttpFileCollection files, string path)
        {
            if (files == null)
                return;

            if (files.Count == 0)
            {
                //this.pictureBox.Image = null;
            }
            else
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                //this.pictureBox.Image = GetImageFromStream(files[0].InputStream);
                string dragedFile = files.ToString();
                File.Copy(dragedFile, path);

            }
        }

        private void LoadLists()
        {
            _context = new ApplicationDbContext();
            categoryList = _context.Categories.ToList();
            cbCategory.DataSource = categoryList.Select((c) => c.CategoryName);
            cbCategory.Text = "";

            _context = new ApplicationDbContext();
            courseList = _context.Courses.ToList();
            cbCourse.DataSource = courseList.Select((c) => c.CourseName);
            cbCourse.Text = "";

            _context = new ApplicationDbContext();
            subList = _context.Subscriptions.ToList();
            cbSub.DataSource = subList.Select((s) => s.SubscriptionName);
            cbSub.Text = "";
        }

        private bool IsValidInput()
        {
            if (cbCategory.Text == "")
            {
                cbCategory.Focus();
                return false;
            }
            if (txtBookName.Text == "")
            {
                txtBookName.Focus();
                return false;
            }
            if (cbCourse.Text == "")
            {
                cbCourse.Focus();
                return false;
            }
            if (cbSub.Text == "")
            {
                cbSub.Focus();
                return false;
            }
            if (files == null)
            {
                MessageBox.Show("Upload book");
                panelFile.Focus();
                return false;
            }
            return true;
        }

        private void ClearInput()
        {
            cbCategory.Text = "";
            txtBookName.Clear();
            cbCourse.Text = "";
            cbSub.Text = "";
            cbCategory.Focus();
        }

        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            var parent = (BooksControl)MyParent;
            parent.LoadBooks();
        }
    }
}
