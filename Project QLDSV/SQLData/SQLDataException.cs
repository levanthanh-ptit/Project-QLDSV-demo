using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData
{
    class SQLDataException : Exception
    {
        protected int Code { get; set; }
        public string ErrorMessage { get; set; }

        public SQLDataException(int code)
        {
            this.Code = code;
        }
    }
}
