using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace E_Library.Admin.Dashboard
{
    public partial class ClassificationControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        Category category;
        Course course;
        Subscription subscription;

        public ClassificationControl()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        public void LoadCategory()
        {
            var categories = _context.Categories.ToList();
            dataGridView1.DataSource = categories;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CategoryName"].HeaderText = "Category Name";
            dataGridView1.Columns["CategoryName"].Width = 150;
        }

        public void LoadCourse()
        {
            var courses = _context.Courses.ToList();
            dataGridView2.DataSource = courses;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["CourseName"].HeaderText = "Course Name";
            dataGridView2.Columns["CourseName"].Width = 150;
        }

        public void LoadSubscription()
        {
            var sub = _context.Subscriptions.ToList();
            dataGridView3.DataSource = sub;
            dataGridView3.Columns["Id"].Visible = false;
            dataGridView3.Columns["SubscriptionName"].HeaderText = "Subscription Name";
            dataGridView3.Columns["SubscriptionName"].Width = 150;
            //dataGridView3.Columns["Amount"]
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                txtCategory.Focus();
                MessageBox.Show("Name required");
                return;
            }
            try
            {
                _context = new ApplicationDbContext();
                if (category == null)
                {
                    Category newCategory = new Category { CategoryName = txtCategory.Text };
                    _context.Categories.Add(newCategory);
                    _context.SaveChanges();
                    MessageBox.Show("New category added");
                }
                else
                {
                    category.CategoryName = txtCategory.Text;
                    _context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    MessageBox.Show("Category updated");
                }

                ResetControls("category");
            }
            catch
            {
                MessageBox.Show("Some error occur");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (category != null)
            {
                var result = MessageBox.Show("Delete category", "Delete Category",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _context = new ApplicationDbContext();
                    _context.Categories.Remove(category);
                    _context.SaveChanges();
                    MessageBox.Show("Category removed");
                    ResetControls("category");
                }
            }
        }

        private void btnRefreshCategory_Click(object sender, EventArgs e)
        {
            ResetControls("category");
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (txtCourse.Text == "")
            {
                txtCourse.Focus();
                MessageBox.Show("Name required");
                return;
            }
            try
            {
                _context = new ApplicationDbContext();
                if (category == null)
                {
                    Course newCourse = new Course { CourseName = txtCourse.Text };
                    _context.Courses.Add(newCourse);
                    _context.SaveChanges();
                    MessageBox.Show("New category added");
                }
                else
                {
                    course.CourseName = txtCourse.Text;
                    _context.Entry(course).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    MessageBox.Show("Course updated");
                }

                ResetControls("course");
            }
            catch
            {
                MessageBox.Show("Some error occur");
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (course != null)
            {
                var result = MessageBox.Show("Delete course", "Delete Course",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _context = new ApplicationDbContext();
                    _context.Courses.Remove(course);
                    _context.SaveChanges();
                    MessageBox.Show("Course removed");
                    ResetControls("course");
                }
            }
        }

        private void btnRefreshCourse_Click(object sender, EventArgs e)
        {
            ResetControls("course");
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            if (txtSub.Text == "")
            {
                txtSub.Focus();
                MessageBox.Show("Name required");
                return;
            }
            if (txtSubCost.Text == "")
            {
                txtSubCost.Focus();
                MessageBox.Show("Amount required");
                return;
            }
            try
            {
                _context = new ApplicationDbContext();
                if (subscription == null)
                {
                    Subscription newSub = new Subscription
                    {
                        SubscriptionName = txtSub.Text,
                        Amount = double.Parse(txtSubCost.Text)
                    };
                    _context.Subscriptions.Add(newSub);
                    _context.SaveChanges();
                    MessageBox.Show("New subscription added");
                }
                else
                {
                    subscription.SubscriptionName = txtSub.Text;
                    subscription.Amount = double.Parse(txtSubCost.Text);
                    _context.Entry(subscription).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    MessageBox.Show("Subscription updated");
                }

                ResetControls("sub");
            }
            catch
            {
                MessageBox.Show("Some error occur");
            }
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            if (subscription != null)
            {
                var result = MessageBox.Show("Delete subscription", "Delete Subscription",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _context = new ApplicationDbContext();
                    _context.Subscriptions.Remove(subscription);
                    _context.SaveChanges();
                    MessageBox.Show("Subscription removed");
                    ResetControls("sub");
                }
            }
        }

        private void btnRefreshSub_Click(object sender, EventArgs e)
        {
            ResetControls("sub");
        }

        private void ResetControls(string section)
        {
            if (section == "category")
            {
                LoadCategory();
                txtCategory.Clear();
                panelCategory.Visible = false;
                btnAddCategory.Text = "Save";
                category = null;
            }
            else if (section == "course")
            {
                LoadCourse();
                txtCourse.Clear();
                panelCourse.Visible = false;
                btnAddCourse.Text = "Save";
                course = null;
            }
            else
            {
                LoadSubscription();
                txtSub.Clear();
                txtSubCost.Clear();
                panelSub.Visible = false;
                btnAddSub.Text = "Save";
                subscription = null;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            category = (Category)dataGridView1.CurrentRow.DataBoundItem;
            if (category != null)
            {
                txtCategory.Text = category.CategoryName;
                btnAddCategory.Text = "Update";
                panelCategory.Visible = true;
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            course = (Course)dataGridView1.CurrentRow.DataBoundItem;
            if (course != null)
            {
                txtCourse.Text = course.CourseName;
                btnAddCourse.Text = "Update";
                panelCourse.Visible = true;
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            subscription = (Subscription)dataGridView1.CurrentRow.DataBoundItem;
            if (subscription != null)
            {
                txtSub.Text = subscription.SubscriptionName;
                txtSubCost.Text = subscription.Amount.ToString();
                btnAddSub.Text = "Update";
                panelSub.Visible = true;
            }
        }

        private void ClassificationControl_Appear(object sender, EventArgs e)
        {
            LoadCategory();
            LoadCourse();
            LoadSubscription();
        }
    }
}
