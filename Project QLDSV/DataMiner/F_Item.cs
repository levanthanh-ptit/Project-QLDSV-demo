using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.DataMiner
{
    public class F_Item : List<List<int>>
    {
        public string TID { get; set; }

        public string GetItemsString()
        {
            string itemsString = "";
            foreach (List<int> list in this)
            {
                itemsString += "{";
                foreach (int item in list)
                {
                    itemsString += item + ", ";
                }
                itemsString = itemsString.Trim(new Char[] { ',', ' ' });
                itemsString += "}, ";
            }
            itemsString = itemsString.Trim(new Char[] { ',', ' ' });
            return itemsString;
        }
    }
}
