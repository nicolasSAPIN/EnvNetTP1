using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvNetTp1.Entities;
using EnvNetTp1.Entities.Contracts;

namespace EnvNetTp1.Database
{
    class MyDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public MyDbContext()
        {
            if (this.Database.CreateIfNotExists())
            {

                Author author1 = new Author() { firstname = "Musso", lastname = "Guillaume" };
                Author author2 = new Author() { firstname = "Bussi", lastname = "Michel" };

                this.Authors.Add(author1);
                this.Authors.Add(author2);

                Book book1 = new Book();
                book1.Name = "Et après";
                book1.NbPage = 500;
                book1.Authors.Add(author1);

                Book book2 = new Book();
                book2.Name = "Gravé dans le sable ";
                book2.NbPage = 500;
                book2.Authors.Add(author2);

                this.Books.Add(book1);
                this.Books.Add(book2);

                this.SaveChanges();


            }
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasMany(x => x.Authors).WithMany(x => x.Books)
               .Map(x =>
               {
                   x.MapLeftKey(WriteContract.FK_COL_BOOK);
                   x.MapRightKey(WriteContract.FK_COL_AUTHOR);
                   x.ToTable(WriteContract.TABLE_NAME);
               });

        }
    }

}

       
