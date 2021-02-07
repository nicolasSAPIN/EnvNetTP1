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
        [Column(BookContract.USER_COLUMN_ID)]
        public long Id { get => this.id; set => this.id = value; }

        [Column(BookContract.USER_COLUMN_FIRSTNAME)]
        [Required]
        public string name { get => this.name; set => this.name = value; }

        [Column(UserContract.USER_COLUMN_LASTNAME)]
        [Required]
        public string Lastname { get => this.lastname; set => this.lastname = value; }

    }
}
