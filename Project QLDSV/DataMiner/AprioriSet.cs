using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLDSV.DataMiner
{
    class AprioriSet : List<Apriori>
    {
        public AprioriSet(GiaoTac_Table.GiaoTacTable giaoTacs)
        {
            Add(new Apriori(1));
            for (int i = 0; i < giaoTacs.ColumnCount; i++)
            {
                this[0].C_List.Add(new ItemSet() { i + 1 });
            }
            for (int i = 0; i < giaoTacs.Count; i++)
            {
                F_Item f_Item = new F_Item();
                f_Item.TID = giaoTacs[i].MaSV;
                for (int j = 0; j < giaoTacs[i].Count; j++)
                {
                    if (giaoTacs[i][j] == 1)
                    {
                        f_Item.Add(new List<int>() { j + 1 });
                        this[0].C_List[j].Support++;
                    }
                }
                this[0].F_List.Add(f_Item);
            }
            string test = "";
            foreach(ItemSet e in this[0].C_List)
            {
                test += e.Support + ", ";
            }
            MessageBox.Show(test);
        }
        public int GetIndex(int K)
        {
            if (this[K - 1] == null) return -1;
            else return K - 1;
        }
        public Apriori GetItem(int K)
        {
            if (this[K - 1] == null) return this[K -1];
            else return null;
        }
        private void AprioriGen(int K)
        {
            List<ItemSet> c_List = new List<ItemSet>(this[K-2].C_List);
        }
        public void NextStep()
        {

        }
    }
}
