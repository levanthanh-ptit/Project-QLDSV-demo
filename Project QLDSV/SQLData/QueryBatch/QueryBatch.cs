using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.QueryBatch
{
    partial class QueryBatch : Dictionary<string, QueryStament>
    {
        public string TableName { get; set; }
        public void AddQuery(string rowId, QueryStament queryStatement)
        {
            Add(rowId, queryStatement);
        }
    }
}
