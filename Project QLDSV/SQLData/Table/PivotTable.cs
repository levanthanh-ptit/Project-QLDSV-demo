using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Table
{
    public abstract class PivotTable<T> : Table<T> where T : Row.Row
    {
        public string[] DynamicFeildLabels { get; set; } = new string[0];
        public PivotTable(string tableName) : base(tableName) { }
    }
}
