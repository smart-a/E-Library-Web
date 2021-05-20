
using System;
using Wisej.Web;

namespace E_Library
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            defaultHeader1.btnHome.Visible = false;
        }
    }
}
