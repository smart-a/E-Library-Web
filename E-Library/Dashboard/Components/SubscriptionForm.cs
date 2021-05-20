using E_Library.Data;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace E_Library.Dashboard.Components
{
    public partial class SubscriptionForm : Form
    {
        ApplicationDbContext _context;
        List<Subscription> subList;
        User currentUser;
        object MyParent;

        public SubscriptionForm(object owner, User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentUser = user;
            MyParent = owner;
        }

        private void Subscription_Appear(object sender, EventArgs e)
        {
            LoadSub();
        }

        private void LoadSub()
        {
            subList = _context.Subscriptions.ToList();

            cbSubscription.DataSource = subList.Select((s) => s.SubscriptionName);
            cbSubscription.Text = "";
        }

        private void cbSubscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbSubscription.SelectedIndex;
            txtAmount.Text = subList[index].Amount.ToString("###,##0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbSubscription.Text == "")
            {
                cbSubscription.Focus();
                return;
            }

            try
            {
                if (currentUser.Wallet < subList[cbSubscription.SelectedIndex].Amount)
                {
                    MessageBox.Show("Sorry, you don't have enough balance to opt-in for this subscription");
                    return;
                }

                var existSub = ExistSub();
                if (existSub != null)
                {
                    if (existSub.SubStatus == 1)
                    {
                        var result = MessageBox.Show("You have an existing subscription, clickong OK will override the current subscription",
                        "Subscription", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    existSub.Subscription = subList[cbSubscription.SelectedIndex];
                    existSub.SubStatus = 1;
                    existSub.SubDate = DateTime.Now;
                    OverrideExistSub(existSub);
                }
                else
                {
                    _context = new ApplicationDbContext();
                    UserSubscription newSub = new UserSubscription
                    {
                        User = currentUser,
                        Subscription = subList[cbSubscription.SelectedIndex]
                    };
                    _context.UserSubscriptions.Add(newSub);
                    _context.SaveChanges();
                }
                MessageBox.Show("You have successfully opt-in a new subscription");
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Some errors occur");
            }
        }

        private void OverrideExistSub(UserSubscription existSub)
        {
            _context = new ApplicationDbContext();
            existSub.SubStatus = 0;
            _context.Entry(existSub).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        private UserSubscription ExistSub()
        {
            _context = new ApplicationDbContext();
            return _context.UserSubscriptions.SingleOrDefault((s) => s.User.Id == currentUser.Id);
        }

        private void SubscriptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var parent = (LibrayControl)MyParent;
            parent.LoadSub();
        }
    }
}
