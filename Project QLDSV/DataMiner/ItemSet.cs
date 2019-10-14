using System.Collections.Generic;

namespace Project_QLDSV.DataMiner
{
    public class ItemSet : List<int>
    {
        public int Support;
        public ItemSet(int[] items, int Support)
        {
            this.Support = Support;
            AddRange(items);
        }
    }
}
