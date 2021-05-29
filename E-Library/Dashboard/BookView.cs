﻿using System;
using Wisej.Web;

namespace E_Library.Dashboard
{
    public partial class BookView : Wisej.Web.UserControl
    {
        string _bookPath;
        public BookView(string bookPath)
        {
            InitializeComponent();
            _bookPath = bookPath;
        }

        private void BookView_Appear(object sender, EventArgs e)
        {
            pdfViewer1.PdfSource = $"{_bookPath}";
        }
    }
}
