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
            this.uwindow.submButton.Click += SubmButton_Click;
            this.uwindow.reposDGV.CellDoubleClick += ReposDGV_CellDoubleClick;
        }

        private void ReposDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new RepositoriesWindowController(this.uwindow.reposDGV.SelectedRows[0].DataBoundItem as Repo, this.uwindow.userTB.Text);
        }

        private void SubmButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
