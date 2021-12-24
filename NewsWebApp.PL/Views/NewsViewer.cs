using NewsWebApp.PL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsWebApp.PL.Views
{
    public partial class NewsViewer : Form
    {
        private readonly NewsViewModel _newsViewModel;
        private readonly AuthorViewModel _authorViewModel;
        private readonly HeadingViewModel _headingViewModel;
        public NewsViewer(NewsViewModel news, AuthorViewModel author, HeadingViewModel heading)
        {
            _newsViewModel = news;
            _authorViewModel = author;
            _headingViewModel = heading;
            InitializeComponent();
        }

        private void NewsViewer_Load(object sender, EventArgs e)
        {
            label_newsname.Text = _newsViewModel.NewsName;
            label_publishdate.Text = $"Date: {_newsViewModel.PublishDate.ToString()} ";
            label_author.Text = $"Author: {_authorViewModel.Lastname}";
            label_heading.Text = $"Heading: {_headingViewModel.Name}";
            richTextBox1.Text = _newsViewModel.NewsText;
        }
    }
}
