using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GithuApiConsumer.Controller;

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
            Application.Run(this.uwindow);
        }
    }
}
