﻿using E_Library.Admin.Dashboard.Components;
using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Wisej.Web;

namespace E_Library.Admin.Dashboard
{
    public partial class StudentsControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        BindingList<object> usersList;

        public StudentsControl()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Students studentsForm = new Students(this);
            studentsForm.ShowDialog();
        }

        public void LoadUsers(List<User> param = null)
        {
            var usersList = param;
            if (usersList == null || usersList.Count < 1)
            {
                usersList = _context.Users.Where((u) => u.UserType == User.UserEnum.Student).ToList();
            }


            var users = usersList.Select((u) => new { u.Id, u.StudentNumber, u.Fullname, u.Gender, u.Level }).ToList<object>();

            dataGridView1.DataSource = users;
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["StudentNumber"].HeaderText = "Student Number";
            dataGridView1.Columns["StudentNumber"].Width = 150;
            dataGridView1.Columns["Fullname"].Width = 250;

        }

        private void StudentsControl_Appear(object sender, EventArgs e)
        {
            dataGridView1.ShowLoader = true;
            LoadUsers();
            dataGridView1.ShowLoader = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentUser = (User)dataGridView1.CurrentRow.DataBoundItem;
            if (currentUser != null)
            {
                DialogResult dialogResult;
                ActionDialog popup = new ActionDialog();
                dialogResult = popup.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    Students studentsForm = new Students(this, currentUser);
                    studentsForm.ShowDialog();
                }
                else if (dialogResult == DialogResult.Abort)
                {
                    var actionResult =
                       MessageBox.Show("Remove student's record", "Delete",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (actionResult == DialogResult.OK)
                    {
                        _context.Users.Remove(currentUser);
                        _context.SaveChanges();
                        MessageBox.Show("Student's record deleted");
                        LoadUsers();
                    }
                }

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var users = _context.Users.Where((u) =>
                u.StudentNumber.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                u.Fullname.StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            LoadUsers(users);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUsers();
        }
    }
}