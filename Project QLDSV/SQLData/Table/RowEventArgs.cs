using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SQLData.Table
{
    public class RowEventArgs<T> : EventArgs where T : class
    {
        public T Row { get; }
        public RowEventArgs(T t)
        {
            Row = t;
        }
    }
}
