using Project_QLDSV.DataMiner;
using Project_QLDSV.Mon_Hoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.FuncGenerateLaw
{
    class GenerateLaw
    {
        public void generateAllBinaryStrings(ref List<DataLaw> stringarr, List<ItemSet> itemSets, ItemSet itemSet,int minConf)
        {
            int n = itemSet.Count;

            for (int i = 1; i < Math.Pow(2, n) - 1; i++)
            {
                String ArrayLeft = "";
                String ArrayRight = "";
                List<int> ListLeft = new List<int>();
                List<int> ListRight = new List<int>();
                for (int j = 0; j < itemSet.Count; j++)
                {
                    int item = i & (int)Math.Pow(2,j);
                    if (item != 0)
                    {
                        foreach (MonHoc mh in Program.MonHocTable)
                        {
                            if (mh.MaMH.Trim().Equals(Program.GiaoTacTable.DynamicFeildLabels[itemSet[j] - 1].Trim()))
                            {
                                ArrayLeft += mh.TenMH + ", ";
                            }
                        }
                        ListLeft.Add(itemSet[j]);
                    }
                    else
                    {
                        foreach (MonHoc mh in Program.MonHocTable)
                        {
                            if (mh.MaMH.Trim().Equals(Program.GiaoTacTable.DynamicFeildLabels[itemSet[j] - 1].Trim()))
                            {
                                ArrayRight += mh.TenMH + ", ";
                            }
                        }
                        ListRight.Add(itemSet[j]);
                    }
                }
                if (ListLeft.Count != 0 && ListRight.Count != 0)
                {
                    for (int j = 0; j < itemSets.Count; j++)
                    {
                        if (ListLeft.SequenceEqual(itemSets.ElementAt(j)))
                        {
                            float MinConfList = ((float)itemSet.Support / itemSets.ElementAt(j).Support) * 100;
                            if (MinConfList >= minConf)
                            {
                                ArrayLeft = ArrayLeft.Trim(new Char[] { ',', ' ' });
                                ArrayRight = ArrayRight.Trim(new Char[] { ',', ' ' });
                                stringarr.Add(new DataLaw(ArrayLeft + " ────► " + ArrayRight, MinConfList));
                            }
                        }
                    }
                }

            }
        }
    }
}
