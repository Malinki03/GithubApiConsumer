using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GithuApiConsumer.Model
{

    public class commit
    {
        public string Sha { get; set;  }
        public Commit Commit { get; set; }
    }

    public class Commit
    {
        public Author Author;
    }

    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

}
