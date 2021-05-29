using System;
using System.Web;
using Wisej.Web;
using System.IO;
using E_Library.Models;
using E_Library.Data;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

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
        Guid bookId;
        string bookPath;
        bool IsBookSave;

        public Books(object owner, Book book = null)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            MyParent = owner;
            _book = book;
        }

        private void Books_Load(object sender, EventArgs e)
        {
            bookId = Guid.NewGuid();
            IsBookSave = false;
        }

        private void Books_Appear(object sender, EventArgs e)
        {
            LoadLists();
            if (_book != null)
            {
                _book = _context.Books.SingleOrDefault((b) => b.Id == _book.Id);

                cbCategory.Text = _book.Category.CategoryName;
                txtBookName.Text = _book.BookName;
                cbCourse.Text = _book.Course.CourseName;
                cbSub.Text = _book.Subscription.SubscriptionName;
                SetPDFIcon();
            }
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
                if (_book == null)
                {
                    Book book = new Book
                    {
                        Id = bookId,
                        Category = categoryList[cbCategory.SelectedIndex],
                        BookName = txtBookName.Text,
                        Course = courseList[cbCourse.SelectedIndex],
                        Subscription = subList[cbSub.SelectedIndex],
                        BookPath = bookPath
                    };

                    _context.Books.Add(book);
                    _context.SaveChanges();
                    IsBookSave = true;
                    MessageBox.Show("New book added");
                    ClearInput();
                }
                else
                {
                    _book.Category = categoryList[cbCategory.SelectedIndex];
                    _book.BookName = txtBookName.Text;
                    _book.Course = courseList[cbCourse.SelectedIndex];
                    _book.Subscription = subList[cbSub.SelectedIndex];

                    _book.BookPath = (bookPath == null) ? _book.BookPath : bookPath;
                    _context.Entry(_book).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    MessageBox.Show("Book record updated");
                    this.Dispose();
                }
                var parent = (BooksControl)MyParent;
                parent.LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Some error occur \n{ex.StackTrace}");
            }
        }

        private void panelFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panelFile_DragDrop(object sender, DragEventArgs e)
        {
            var fileType = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string type in fileType)
            {
                if (type.IndexOf("pdf") < 0)
                {
                    MessageBox.Show("Invalid file, please drop a pdf file");
                    return;
                }
            }

            files = (HttpFileCollection)e.Data.GetData(DataFormats.Files);
            UploadBook();
        }

        private void UploadBook()
        {
            try
            {
                var appPath = Application.MapPath("./");
                bookPath = (_book != null) ? _book.BookPath : "";
                if (files != null)
                {
                    bookPath = $"{appPath}/Books/{bookId}.pdf";
                    files[0].SaveAs(bookPath);
                    SetPDFIcon();
                    MessageBox.Show("Upload complete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadLists()
        {
            categoryList = _context.Categories.ToList();
            cbCategory.DataSource = categoryList.Select((c) => c.CategoryName).ToList();
            cbCategory.Text = "";

            courseList = _context.Courses.ToList();
            cbCourse.DataSource = courseList.Select((c) => c.CourseName).ToList();
            cbCourse.Text = "";

            subList = _context.Subscriptions.ToList();
            cbSub.DataSource = subList.Select((s) => s.SubscriptionName).ToList();
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
            if (_book == null && files == null)
            {
                MessageBox.Show("Please select book to Upload ");
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
            bookId = Guid.NewGuid();
            bookPath = "";
            IsBookSave = false;
            panelFile.BackgroundImageSource = "resource.wx/Wisej.Ext.FontAwesome/cloud-upload.svg";
        }

        private void DeleteUnsaveBook()
        {
            if (!IsBookSave)
            {
                try
                {
                    if (File.Exists(bookPath))
                    {
                        File.Delete(bookPath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteUnsaveBook();
        }

        private void panelFile_Click(object sender, EventArgs e)
        {
            upload1.UploadFiles();
        }

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {
            if (e.Files[0].ContentType.IndexOf("/pdf") < 0)
            {
                MessageBox.Show("Invalid file, please drop a pdf file");
                return;
            }
            files = e.Files;
            UploadBook();
        }

        private void SetPDFIcon()
        {
            panelFile.BackgroundImageSource = "resource.wx/Wisej.Ext.FontAwesome/file-pdf-o.svg";
        }
    }

}
