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
    public partial class AutorisationPanel : Form
    {
        private readonly IAutoresationService _autorisationService;
        private readonly INewsPublishService _newsPublishService;
        private readonly AutorisationController _autorisationController;

        public AutorisationPanel(IAutoresationService autorisationService, INewsPublishService newsPublishService)
        {
            _autorisationService = autorisationService;
            _newsPublishService = newsPublishService;

            _autorisationController = new AutorisationController(_autorisationService);
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string username = textBox_userName.Text;
            string email = textBox_email.Text;
            string firstname = textBox_firstName.Text;
            string lastname = textBox_lastName.Text;
            string mobilenum = textBox_mobileNum.Text;

            int id = username.GetHashCode();
            string password = textBox_password.Text;
            string passwordRep = textBox_paswordRepeat.Text;
            

            if (!password.Equals(passwordRep))
            {
                MessageBox.Show("Password is not equals!", "Password error");
                return;
            }

            string passwordhash = password;

            AuthorViewModel newAuthor = new AuthorViewModel
            {
                Id = id,
                Username = username,
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                Mobile = mobilenum,
                Password = passwordhash
            };

           
            string result = _autorisationController.Register(newAuthor);
            MessageBox.Show(result, "Registration result");
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {

            string username = textBox_usernameLogIn.Text;
            string passhash = textBox_PasswordLogIn.Text;

            AuthorViewModel author = _autorisationController.LogIn(username, passhash);
            //MessageBox.Show(author.Status, "LogIn Status");
            if(author.Status.Equals("OK"))
            {
                button_LogIn.BackColor = Color.Green;
                NewsEditor newsEditor = new NewsEditor(_newsPublishService, author);
                newsEditor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(author.Status, "LogIn Status");
            }
        }
    }
}
