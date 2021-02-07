using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvNetTp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Database.MyDbContext())
            {
                foreach (var item in db.Books.)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();

            using (var db = new Database.MyDbContext())
            {
                foreach (var item in db.Authors)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();


        }
    }
}
