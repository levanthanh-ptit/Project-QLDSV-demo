using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.DataMiner
{
    public class Apriori
    {
        public List<F_Item> F_List = new List<F_Item>();
        public List<ItemSet> L_List = new List<ItemSet>();
        public int K { get; }
        public Apriori(int K) { this.K = K; }
        public override string ToString()
        {
            string str = "----F_List:::\n";
            foreach(F_Item f_Item in F_List)
            {
                str += f_Item.ToString();
            }
            str += "----L_List:::\n";
            foreach (ItemSet l_Item in L_List)
            {
                str += l_Item.ToString();
            }
            return str;
        }
    }
}
