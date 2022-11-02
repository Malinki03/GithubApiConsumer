using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GithuApiConsumer.View;
using System.Windows.Forms;
using GithuApiConsumer.Model;

namespace GithuApiConsumer.Controller
{
    internal class RepositoriesWindowController
    {
        RepoWindow rwindow;
        Repository repo;
        string u;
        Repo r;

        public RepositoriesWindowController(Repo r, string u)
        {
            this.rwindow = new RepoWindow();
            this.repo = new Repository();
            this.r = r;
            this.u = u;
            initListeners();
            LoadData();
            this.rwindow.Show();
        }

        public void initListeners()
        {

        }

        public void LoadData()
        {
            this.rwindow.followersDGV.DataSource = this.repo.GetRepoFollowers(this.u, this.r.Name);
            this.rwindow.descriptionText.Text = this.r.Description;
            this.rwindow.commitsDGV.DataSource = this.repo.GetRepoCommits(this.u, this.r.Name);
        } 
    }
}
