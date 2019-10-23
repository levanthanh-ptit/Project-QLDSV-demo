using System.Collections.Generic;

namespace Project_QLDSV.DataMiner
{
    public class ItemSet : List<int>
    {
        public int Support { get; set; } = 0;
        public ItemSet()
        {
        }
        public ItemSet(IEnumerable<int> collection) : base(collection)
        {
        }
        public ItemSet(int capacity) : base(capacity)
        {
        }
        public override string ToString()
        {
            string itemsString = "{";
            foreach (int e in this)
            {
                itemsString += e + ", ";
            }
            itemsString = itemsString.Trim(new System.Char[] { ',', ' ' });
            return itemsString + "}";
        }
    }
}
