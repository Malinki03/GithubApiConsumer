using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GithuApiConsumer.Controller;
using GithuApiConsumer.Model;

namespace GithuApiConsumer.Controller
{
    internal class UserWindowController
    {
        UserWindow uwindow;
        Repository repo;

        public UserWindowController()
        {
            this.uwindow = new UserWindow();
            this.repo = new Repository();
            InitListeners();
            Application.Run(this.uwindow);
        }

        public void LoadData()
        {
            uwindow.reposDGV.DataSource = this.repo.GetUserRepos(uwindow.userTB.Text);
            uwindow.seguitsDGV.DataSource = this.repo.GetUserFollowed(uwindow.userTB.Text);
            uwindow.seguidorsDGV.DataSource = this.repo.GetUserFollowers(uwindow.userTB.Text);
        }

        public void InitListeners()
        {
            uwindow.userTB.TextChanged += UserTB_TextChanged;
        }

        private void UserTB_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
