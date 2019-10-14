using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.DataMiner
{
    public class D_List : List<int[]>
    {
        private Dictionary<int, string> NameMap = new Dictionary<int, string>();
        private Dictionary<int, string> TIDMap = new Dictionary<int, string>();
        public string GetName(int index)
        {
            return NameMap[index];
        }
        public string GetTID(int index)
        {
            return TIDMap[index];
        }
        public D_List(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                NameMap.Add(i, names[i]);
            }
        }
        private new void Add(int[] values) => base.Add(values);
        public void Add(string TID, int[] values)
        {
            TIDMap.Add(Count, TID);
            Add(values);
        }
    }
}
