using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using E_Library.Dashboard.Components;
using E_Library.Data;
using E_Library.Models;

namespace E_Library.Dashboard
{
    public partial class ProfileControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        User currentUser;

        public ProfileControl(User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentUser = user;
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            lblWallet.Text = currentUser.Wallet.ToString("N###,##0.00");
        }

        private void ProfileControl_Appear(object sender, EventArgs e)
        {
            LoadHistory();
        }

        public void LoadHistory(List<PaymentHistory> param = null)
        {
            var hList = param;
            if (hList == null || hList.Count < 1)
            {
                hList = _context.PaymentHistories.Where((h) => h.User.Id == currentUser.Id).ToList();
            }

            var histories = hList.Select((h) =>
                   new
                   {
                       h.User.Fullname,
                       h.User.Gender,
                       Amount = h.Amount.ToString("###,##).00"),
                       Date = h.PaidAt.ToString("dd MMM, yyyy")
                   }).ToList<object>();

            //historiesList = new BindingList<object>(histories);

            dataGridView1.DataSource = histories;
            //dataGridView1.Columns["Id"].Visible = false;

            //dataGridView1.Columns["StudentNumber"].HeaderText = "Student Number";
            //dataGridView1.Columns["StudentNumber"].Width = 150;
            dataGridView1.Columns["Fullname"].Width = 250;
        }

        private void Filter()
        {
            var start = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day);
            var end = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day);

            var hList = _context.PaymentHistories.Where((h) => h.User.Id == currentUser.Id).ToList();
            var histories = hList.Where((h) =>
                start >= new DateTime(h.PaidAt.Year, h.PaidAt.Month, h.PaidAt.Day) &&
                end <= new DateTime(h.PaidAt.Year, h.PaidAt.Month, h.PaidAt.Day)).ToList();

            LoadHistory(histories);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
