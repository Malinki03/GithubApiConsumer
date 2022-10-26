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
            this.uwindow.reposDGV.DataSource = this.repo.GetUserRepos("Malinki03");
            Application.Run(this.uwindow);
        }
    }
}
