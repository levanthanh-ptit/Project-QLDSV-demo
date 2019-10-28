using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.DataMiner
{
    class Apriori
    {
        public List<F_Item> F_List = new List<F_Item>();
        public List<ItemSet> C_List = new List<ItemSet>();
        public int K { get; }
        public Apriori(int K) { this.K = K; }
    }
}
