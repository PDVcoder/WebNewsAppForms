using NewsWebApp.BLL.Interfaces;
using NewsWebApp.PL.Controllers;
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
    public partial class NewsEditor : Form
    {
        private AuthorViewModel _authorViewModel;
        private readonly INewsPublishService _newsPublishService;
        private readonly PublishNewController _publishNewController;
        public NewsEditor(INewsPublishService newsPublishService, AuthorViewModel author)
        {
            _newsPublishService = newsPublishService;
            _publishNewController = new PublishNewController(_newsPublishService);
            _authorViewModel = author;


            InitializeComponent();

            SetAuthorInfo();
        }

        private void SetAuthorInfo()
        {
            label_email.Text = "Email - " + _authorViewModel.Email;
            label_firstname.Text = "Firstname - " + _authorViewModel.Firstname;
            label_lastname.Text = "Lastname - " + _authorViewModel.Lastname;
            label_username.Text = "User - " + _authorViewModel.Username;

            var headingsList = _publishNewController.GetHeadings();
            string[] combo = new string[headingsList.Count];

            foreach (var item in headingsList)
            {
                combo[item.Id - 1] =  $"{item.Id}. {item.Name}";
            }
            comboBox_Headings.Items.AddRange(combo);
        }

        private void button_publish_Click(object sender, EventArgs e)
        {
            string newsName = textBox_newsName.Text;
            string text = richTextBox_newsText.Text;
            string topics = textBox_topics.Text;
            string topicsList = topics;
            int headingId = comboBox_Headings.SelectedIndex + 1;
            int authorId = _authorViewModel.Id;

            NewsViewModel newsViewModel = new NewsViewModel
            {
                NewsName = newsName,
                NewsText = text,
                Topyc = topicsList,
                HeadingId = headingId,
                AuthorId = authorId
            };

            string result = _publishNewController.Publish(newsViewModel);
            MessageBox.Show(result, "Publishing result");
        }
    }
}
