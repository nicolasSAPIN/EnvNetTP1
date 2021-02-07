using EnvNetTp1.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvNetTp1.Entities
{
    public class Book
    {
        private long id;
        private string name;
        private int nb_page;



        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(BookContract.COL_ID)]
        public int Id { get; set; }
        [Column(BookContract.COL_NAME)]
        public string Name { get; set; }
        [Column(BookContract.COL_NBPAGE)]
        public int NbPage { get; set; }
        public virtual List<Author> Authors { get; set; } = new List<Author>();
       

    }
}
