using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.SQLData.QueryBatch
{
    struct QueryStament
    {
        long Id { get; set; }
        string QueryString { get; set; }
    }
    class QueryBatch
    {
        List<QueryStament> QueryStaments = new List<QueryStament>();
        public void Clean()
        {
            QueryStaments.Clear();
        }
    }
}
