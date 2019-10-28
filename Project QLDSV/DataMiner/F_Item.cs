using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.DataMiner
{
    public class F_Item : List<List<ushort>>
    {
        public string TID { get; set; }

        public override string ToString()
        {
            string itemsString = "";
            foreach (List<ushort> list in this)
            {
                itemsString += "{";
                foreach (ushort item in list)
                {
                    itemsString += item + ", ";
                }
                itemsString = itemsString.Trim(new char[] { ',', ' ' });
                itemsString += "}, ";
            }
            itemsString = itemsString.Trim(new char[] { ',', ' ' });
            return itemsString +="\n";
        }
    }
}
