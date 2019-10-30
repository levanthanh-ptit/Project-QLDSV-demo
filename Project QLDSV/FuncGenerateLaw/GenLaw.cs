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
       
        public void printTheArray(int[] arr, int n, ref List<string> stringarr, List<ItemSet> itemSets, ItemSet itemSet, int minConf)
        {
            String ArrayLeft = "";
            String ArrayRight = "";
            List<int> ListLeft = new List<int>();
            List<int> ListRight = new List<int>();
            for (int i = 0; i < n; i++)
            {
                
                foreach(MonHoc mh in Program.MonHocTable)
                {
                    if(mh.MaMH.Equals(Program.GiaoTacTable.DynamicFeildLabels[itemSet[i] - 1]))
                    {

                    }
                }
                if(arr[i]== 1)
                {
                    ArrayLeft += Program.GiaoTacTable.DynamicFeildLabels[itemSet[i]-1] + ", ";
                    ListLeft.Add(itemSet[i]);
                }
                else
                {
                    ArrayRight += Program.GiaoTacTable.DynamicFeildLabels[itemSet[i] - 1] + ", ";
                    ListRight.Add(itemSet[i]);
                }
                
            }
            if(ListLeft.Count != 0 && ListRight.Count != 0)
            {
                for (int j = 0; j < itemSets.Count; j++)
                {
                    if (ListLeft.SequenceEqual(itemSets.ElementAt(j)))
                    {
                        float MinConfList = ((float)itemSet.Support / itemSets.ElementAt(j).Support) * 100;
                        if (MinConfList >= minConf)
                        {
                            ArrayLeft = ArrayLeft.Trim(new Char[] { ',' });
                            ArrayRight = ArrayRight.Trim(new Char[] { ',' });
                            stringarr.Add(ArrayLeft + " ==>> " + ArrayRight);
                            return;
                        }
                    }
                }
            }
        }
        public void generateAllBinaryStrings(int n,
                            int[] arr, int i, ref List<string> stringarr, List<ItemSet> itemSets, ItemSet itemSet,
                           int minConf)
        {
            if (i == n)
            {
                printTheArray(arr, n,ref stringarr, itemSets, itemSet, minConf);
                return;
            }

           
            arr[i] = 0;
            generateAllBinaryStrings(n, arr, i + 1, ref stringarr, itemSets, itemSet, minConf);

           
            arr[i] = 1;
            generateAllBinaryStrings(n, arr, i + 1, ref stringarr, itemSets, itemSet, minConf);
        }
    }
    
}
