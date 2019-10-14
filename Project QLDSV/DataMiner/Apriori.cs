using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.DataMiner
{
    class Apriori
    {
        public int MinSupport = 0;
        D_List D_List;
        public Apriori(D_List D_List)
        {
            this.D_List = D_List;
        }
    }
}
