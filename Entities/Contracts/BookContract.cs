using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvNetTp1.Entities.Contracts
{
    class BookContract
    {
        public const string TABLE_NAME = "Book";

        public const string COL_ID = GeneralContract.DEFAULT_ID;

        public const string COL_NAME = "name";
        public const string COL_NBPAGE = "nb" + GeneralContract.WORD_DELIMITER + "page";

    }
}
