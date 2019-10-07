using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.QueryBatch
{
    public class QueryColumn 
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public QueryColumn(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
