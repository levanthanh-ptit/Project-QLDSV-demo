using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData
{
    class PrimaryKeyException : SQLDataException
    {
        public const int DUPLICATED = 1;
        public PrimaryKeyException(int Code) : base(Code)
        {
            switch (Code)
            {
                case DUPLICATED:
                    ErrorMessage = "Khóa chính đã tồn tại.";
                    break;
            }
        }
    }
}
