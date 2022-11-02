using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GithuApiConsumer.Model
{
    internal class commit
    {
        public Commit Commit { get; set; }
        public string Sha { get; set; }
    }

    public class Commit
    {
        public Author Author { get; set; }
        public string Message { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }
}
