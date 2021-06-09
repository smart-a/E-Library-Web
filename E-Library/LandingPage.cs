
using System;
using Wisej.Web;
using System.IO;

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

            var bookPath = $"{Application.MapPath("./")}/Books";
            if (!Directory.Exists(bookPath))
            {
                Directory.CreateDirectory(bookPath);
            }
        }
    }
}
