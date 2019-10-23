using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLDSV.DataMiner
{
    public class AprioriSet : List<Apriori>
    {
        public AprioriSet(GiaoTac_Table.GiaoTacTable giaoTacs)
        {
            Add(new Apriori(1));
            for (int i = 0; i < giaoTacs.ColumnCount; i++)
            {
                this[0].L_List.Add(new ItemSet() { i + 1 });
            }
            for (int i = 0; i < giaoTacs.Count; i++)
            {
                F_Item f_Item = new F_Item();
                f_Item.TID = giaoTacs[i].MaSV;
                bool isZero = true;
                for (int j = 0; j < giaoTacs[i].Count; j++)
                {
                    if (giaoTacs[i][j] == 1)
                    {
                        isZero = false;
                        f_Item.Add(new List<int>() { j + 1 });
                        this[0].L_List[j].Support++;
                    }
                }
                if (isZero) continue;
                this[0].F_List.Add(f_Item);
            }
            string test = "";
            foreach (ItemSet e in this[0].L_List)
            {
                test += e.Support + ", ";
            }
            MessageBox.Show(test, "Item sets of C[0]");
            MessageBox.Show(this[0].ToString());
        }
        public int GetIndex(int K)
        {
            if (this[K - 1] == null) return -1;
            else return K - 1;
        }
        public Apriori GetItem(int K)
        {
            if (this[K - 1] == null) return this[K - 1];
            else return null;
        }
        private bool PrefixEqual(ItemSet list1, ItemSet list2)
        {
            if (list1.Count != list2.Count) return false;
            for (int i = 0; i < list1.Count - 1; i++)
            {
                if (list1[i] != list2[i]) return false;
            }
            return true;
        }
        private List<ItemSet> AprioriGen(int K)
        {
            int position = GetIndex(K);
            List<ItemSet> l_Current = this[position].L_List;
            List<ItemSet> c_List = new List<ItemSet>();
            
            for (int i = 0; i < l_Current.Count - 1; i++) // O((n^2)/2)
            { 
                for (int j = i + 1; j < l_Current.Count; j++)
                {
                    if (PrefixEqual(l_Current[i],l_Current[j]))
                    {
                        ItemSet c_item = new ItemSet(l_Current[i]); //O(n)
                        c_item.Add(l_Current[j][l_Current[j].Count - 1]);
                        c_List.Add(c_item);
                    }
                }
            }
            return c_List;
        }
        public void NextStep()
        {
            Apriori apriori = new Apriori(Count);
            List<ItemSet> c_List = AprioriGen(Count);
            string str = "";
            foreach (List<int> l in c_List)
            {
                foreach (int v in l)
                {
                    str += v + " ";
                }
                str += "\n";
            }
            MessageBox.Show(str);
        }
    }
}
