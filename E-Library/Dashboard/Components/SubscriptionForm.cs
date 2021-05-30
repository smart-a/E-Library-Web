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

            cbSubscription.DataSource = subList.Select((s) => s.SubscriptionName).ToList();
            cbSubscription.Text = "";
            txtAmount.Text = "0";
        }

        private void cbSubscription_SelectedItemChanged(object sender, EventArgs e)
        {
            var index = cbSubscription.SelectedIndex;
            if (index > -1)
            {
                txtAmount.Text = subList[index].Amount.ToString("###,##0.00");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbSubscription.Text == "" || txtAmount.Text == "0")
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
                var selectedSub = subList[cbSubscription.SelectedIndex].Id;
                if (IsExistSub(selectedSub))
                {
                    MessageBox.Show("You have an existing record of this subscription");
                    return;
                }
                
                var sub = _context.Subscriptions.SingleOrDefault((s) => s.Id == selectedSub);
                var user = _context.Users.SingleOrDefault((u) => u.Id == currentUser.Id);
                UserSubscription newSub = new UserSubscription
                {
                    User = user,
                    Subscription = sub
                };
                _context.UserSubscriptions.Add(newSub);
                _context.SaveChanges();

                user.Wallet -= sub.Amount;
                _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();

                MessageBox.Show("You have successfully opt-in a new subscription");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ ex.Message} - { ex.StackTrace}");
            }
        }

        private void OverrideExistSub(UserSubscription existSub)
        {
            _context = new ApplicationDbContext();
            existSub.SubStatus = 0;
            _context.Entry(existSub).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        private bool IsExistSub(Guid newSubId)
        {
            _context = new ApplicationDbContext();
            return _context.UserSubscriptions.Any((s) => s.User.Id == currentUser.Id &&
                    s.Subscription.Id == newSubId && s.SubStatus == 1);
        }

        private void SubscriptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
