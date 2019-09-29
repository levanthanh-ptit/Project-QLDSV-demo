using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData
{
    class Row<T> where T : class
    {
        public T Data { get; set; }
        public long RowId { get; }
        public Row(long id)
        {
            this.RowId = id;
        }
    }
}
