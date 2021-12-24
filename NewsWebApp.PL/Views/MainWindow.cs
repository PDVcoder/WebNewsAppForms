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
    public partial class MainWindow : Form
    {
        private readonly IAutoresationService _autoresationService;
        private readonly INewsPublishService _newsPublishService;
        private readonly INewsManagerService _newsManagerService;

        private readonly NewsManagerController _newsManagerController;
        private readonly PublishNewController _publishNewController;

        private List<NewsViewModel> _news;

        private AutorisationPanel autorisationPanel;
        public MainWindow(IAutoresationService autoresationService, INewsPublishService newsPublishService, INewsManagerService newsManagerService)
        {
            _autoresationService = autoresationService;
            _newsPublishService = newsPublishService;
            _newsManagerService = newsManagerService;

            _newsManagerController = new NewsManagerController(_newsManagerService);
            _publishNewController = new PublishNewController(_newsPublishService);
            _news = _newsManagerController.GetNews();
            _news.Reverse();

            InitializeComponent();

            UpdateNews();
            LoadHeadings();
            SetDefaultDate();
        }

        private void SetDefaultDate()
        {
            dateTimePicker_to.Value = DateTime.Now;
            dateTimePicker_from.Value = new DateTime(2021, 11, 17);
        }

        private void LoadAllNews()
        {
            _news = _newsManagerController.GetNews();
            _news.Reverse();
            UpdateNews();
        }

        private void UpdateNews()
        {
            listBox_news.Items.Clear();
            foreach (var item in _news)
            {
                listBox_news.Items.Add($"{item.Id}. {item.NewsName} ---- Date: {item.PublishDate.ToString()}");
            }
        }

        private void LoadHeadings()
        {
            var headingsList = _publishNewController.GetHeadings();
            string[] combo = new string[headingsList.Count+1];
            combo[0] = "Filter off";
                 
            foreach (var item in headingsList)
            {
                combo[item.Id] = $"{item.Id}. {item.Name}";
            }
            comboBox_Headings.Items.AddRange(combo);
        }

        private void button_RegisterView_Click(object sender, EventArgs e)
        {
            if (autorisationPanel != null)
            {
                autorisationPanel.Dispose();
            }
            autorisationPanel = new AutorisationPanel(_autoresationService, _newsPublishService);
            autorisationPanel.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadAllNews();
            //textBox_topyc.Text = "";
            //comboBox_Headings.SelectedIndex = 0;
            //SetDefaultDate();
        }

        private void LoadNewsByDate(DateTime date1, DateTime date2)
        {
            _news = _newsManagerController.GetByDate(date1, date2);
            //textBox_topyc.Text = "";
            //comboBox_Headings.SelectedIndex = 0;
            UpdateNews();
        }


        private void listBox_news_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox_news.IndexFromPoint(e.Location);
            NewsViewModel news = _news[index];
            AuthorViewModel author = _newsManagerController.GetAuthorView(news.AuthorId);
            HeadingViewModel heading = _newsManagerController.GetHeadingView(news.HeadingId);
            NewsViewer newsViewer = new NewsViewer(news, author, heading);
            newsViewer.Show();
        }

        private void textBox_topyc_TextChanged(object sender, EventArgs e)
        {
            _news = _newsManagerController.GetByTopic(textBox_topyc.Text);
            UpdateNews();
            //comboBox_Headings.SelectedIndex = 0;
            //SetDefaultDate();
        }

        private void comboBox_Headings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int headingId = comboBox_Headings.SelectedIndex;
            if(headingId != 0)
            {
                _news = _newsManagerController.GetByHeading(comboBox_Headings.SelectedIndex);
                UpdateNews();
            }
            else
            {
                LoadAllNews();
                UpdateNews();
            }
            ////textBox_topyc.Text = "";
            //SetDefaultDate();
        }

        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            LoadNewsByDate(dateTimePicker_from.Value, dateTimePicker_to.Value);
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            LoadNewsByDate(dateTimePicker_from.Value, dateTimePicker_to.Value);
        }

        private void textBox_newsName_TextChanged(object sender, EventArgs e)
        {
            _news = _newsManagerController.GetByName(textBox_newsName.Text);
            UpdateNews();
        }
    }
}
