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
                foreach (var item in db.Books)
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

            // enrainement au link Query
            // selection de l'auteur qui a ecrit le livre "Et apres".
            using (var db = new Database.MyDbContext())
            {
                var QueryBookAuthor1 = db.Authors.Where(x => x.Books.Select(y => y.Name).Equals("Et après"));
                Console.WriteLine(QueryBookAuthor1);
            }
            Console.ReadKey();


        }
    }
}
