using System.Collections.Generic;

namespace Project_QLDSV.DataMiner
{
    public class ItemSet : List<ushort>
    {
        public int Support { get; set; } = 0;
        public ItemSet()
        {
        }
        public ItemSet(IEnumerable<ushort> collection) : base(collection)
        {
        }
        public ItemSet(int capacity) : base(capacity)
        {
        }
        public override string ToString()
        {
            string itemsString = "{";
            foreach (ushort e in this)
            {
                itemsString += e + ", ";
            }
            itemsString = itemsString.Trim(new char[] { ',', ' ' });
            return itemsString + "}";
        }
    }
}
