using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData
{
    class RowEventArgs<T> : EventArgs
    {
        public T row { get; }
        public RowEventArgs(T t)
        {
            row = t;
        }
    }
}
