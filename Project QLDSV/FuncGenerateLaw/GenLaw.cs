﻿using Project_QLDSV.DataMiner;
using Project_QLDSV.Mon_Hoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.FuncGenerateLaw
{
    class GenLaw
    {

        public void printTheArray(int[] arr, int n, ref List<DataLaw> stringarr, List<ItemSet> itemSets, ItemSet itemSet, int minConf)
        {
            String ArrayLeft = "";
            String ArrayRight = "";
            List<int> ListLeft = new List<int>();
            List<int> ListRight = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 1)
                {
                    foreach (MonHoc mh in Program.MonHocTable)
                    {
                        if (mh.MaMH.Trim().Equals(Program.GiaoTacTable.DynamicFeildLabels[itemSet[i] - 1].Trim()))
                        {
                            ArrayLeft += mh.TenMH + ", ";
                        }
                    }
                    ListLeft.Add(itemSet[i]);
                }
                else
                {
                    foreach (MonHoc mh in Program.MonHocTable)
                    {
                        if (mh.MaMH.Trim().Equals(Program.GiaoTacTable.DynamicFeildLabels[itemSet[i] - 1].Trim()))
                        {
                            ArrayRight += mh.TenMH + ", ";
                        }
                    }
                    ListRight.Add(itemSet[i]);
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
                            return;
                        }
                    }
                }
            }
        }
        public void generateAllBinaryStrings(int n,
                            int[] arr, int i, ref List<DataLaw> stringarr, List<ItemSet> itemSets, ItemSet itemSet,
                           int minConf)
        {
            if (i == n)
            {
                printTheArray(arr, n, ref stringarr, itemSets, itemSet, minConf);
                return;
            }


            arr[i] = 0;
            generateAllBinaryStrings(n, arr, i + 1, ref stringarr, itemSets, itemSet, minConf);


            arr[i] = 1;
            generateAllBinaryStrings(n, arr, i + 1, ref stringarr, itemSets, itemSet, minConf);
        }
    }

}
