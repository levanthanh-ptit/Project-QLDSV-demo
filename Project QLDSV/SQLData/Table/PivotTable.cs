using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Table
{
    public abstract class PivotTable<T> : Table<T> where T : Row.Row
    {
        public List<string> DynamicFeildLabels = new List<string>();
        public int ColumnCount 
        { get
            {
                return DynamicFeildLabels.Count;
            } 
        }
        public PivotTable(string tableName) : base(tableName) { }
        public new void Clear()
        {
            DynamicFeildLabels.Clear();
            base.Clear();
        }
    }
}
