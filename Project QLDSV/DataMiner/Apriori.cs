using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLDSV.DataMiner
{
    class Apriori
    {
        public List<F_Item> F_List = new List<F_Item>();
        public List<ItemSet> C_List = new List<ItemSet>();

        public Apriori(GiaoTac_Table.GiaoTacTable giaoTacs)
        {
            for (int i = 0; i < giaoTacs.ColumnCount; i++)
            {
                C_List.Add(new ItemSet() { i + 1 });
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
                        C_List[j].Support++;
                    }
                }
                F_List.Add(f_Item);
            }
            MessageBox.Show(C_List[4].Support+"");
            
        }
    }
}
