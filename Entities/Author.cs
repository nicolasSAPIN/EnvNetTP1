
using EnvNetTp1.Entities.Contracts;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvNetTp1.Entities
{
    [Table(AuthorContract.TABLE_NAME)]
    public class Author : EntityBase
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(AuthorContract.COLUMN_ID)]
        private long id;
       
        [Column(AuthorContract.COLUMN_FIRSTNAME)]
        public string firstname { get; set; }

        [Column(AuthorContract.COLUMN_LASTNAME)]
        public string lastname { get; set; }
        
        public virtual List<Book> Books { get; set } = new List<Book>();
    }
}
