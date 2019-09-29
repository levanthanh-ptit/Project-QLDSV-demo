using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData
{
    class ForeignKeyException : SQLDataException
    {
        public const int NOT_FOUND = 1;
        public ForeignKeyException(int Code) : base(Code)
        {
            switch (Code)
            {
                case NOT_FOUND:
                    ErrorMessage = "Khóa ngoại chưa tồn tại.";
                    break;
            }
        }
    }
}
