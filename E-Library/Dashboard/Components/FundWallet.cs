using System;
using Wisej.Web;

namespace E_Library.Dashboard.Components
{
    public partial class FundWallet : Form
    {
        public decimal PaidAmount { get { return amount; } }
        public bool IsSuccess { get { return success; } }

        private decimal amount;
        private bool success;

        public FundWallet()
        {
            InitializeComponent();
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            var amt = nudAmount.Value.ToString("###,##0");
            btnPay.Text = $"Pay NGN {amt}";
        }

        private void FundWallet_Load(object sender, EventArgs e)
        {
            nudMonth.Value = DateTime.Now.Month;
            nudYear.Minimum = DateTime.Now.Year;
            nudYear.Maximum = nudYear.Minimum + 5;
            amount = 0;
            success = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (nudAmount.Value < 1)
            {
                nudAmount.Focus();
                return;
            }
            if (txtCarcNumber.Text.Length < 16 || txtCarcNumber.Text.Length > 19)
            {
                txtCarcNumber.Focus();
                return;
            }
            if (txtCVV.TextLength < 3)
            {
                txtCVV.Focus();
                return;
            }
            if (nudMonth.Value < DateTime.Now.Month && nudYear.Value == DateTime.Now.Year)
            {
                MessageBox.Show("Your card has expired, please use a valid card");
                return;
            }
            success = true;
            amount = nudAmount.Value;
            MessageBox.Show("Payment successful");
            this.Dispose();
        }
    }
}
