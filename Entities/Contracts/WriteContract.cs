using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvNetTp1.Entities.Contracts
{
    class WriteContract
    {
        public const string TABLE_NAME = "Write";

        public const string FK_COL_AUTHOR = AuthorContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + AuthorContract.COLUMN_ID;

        public const string FK_COL_BOOK = BookContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + BookContract.COL_ID;
    }
}
