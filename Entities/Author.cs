using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvNetTp1.Entities
{
    public class Author
    {
        private long id;
        private string firstname;
        private string lastname;

        private List<Book> books = new List<Book>();
    }
}
