using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace E_Library.Admin.Dashboard
{
    public partial class PaymentsControl : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;

        public PaymentsControl()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void PaymentsControl_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        private void PaymentsControl_Appear(object sender, EventArgs e)
        {
            LoadHistory();
        }

        public void LoadHistory(List<PaymentHistory> param = null)
        {
            var hList = param;
            if (hList == null || hList.Count < 1)
            {
                hList = _context.PaymentHistories.ToList();
            }

            var histories = hList.Select((h) =>
                   new PaymentHistoryDisplay
                   {
                       Id = h.Id,
                       Fullname = h.User.Fullname,
                       Amount = h.Amount.ToString("###,##0.00"),
                       Date = h.PaidAt.ToString("dd MMM, yyyy")
                   }).ToList();

            dataGridView1.DataSource = histories;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Fullname"].Width = 250;

            var total = hList.Sum((h) => h.Amount);
            lblPaymentReceived.Text = total.ToString("N###,##0.00");
        }

        private void Filter()
        {
            var start = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day);
            var end = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day);

            var hList = _context.PaymentHistories.ToList();
            var histories = hList.Where((h)=> 
                start >= new DateTime(h.PaidAt.Year, h.PaidAt.Month, h.PaidAt.Day) &&
                end  <= new DateTime(h.PaidAt.Year, h.PaidAt.Month, h.PaidAt.Day)).ToList();

            LoadHistory(histories);
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
