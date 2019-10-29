﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLDSV.DataMiner
{
    public class AprioriSet : List<Apriori>
    {
        public bool EndFlag { get; private set; } = false;
        public event EventHandler<EventArgs> OnAprioriEnd;
        public AprioriSet(GiaoTac_Table.GiaoTacTable giaoTacs)
        {
            // count running time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // start
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
            // count running time
            watch.Stop();
            Console.Out.WriteLine("AprioriSet Constructor:::" + watch.ElapsedMilliseconds);
        }
        public int GetIndex(int K)
        {
            if (this[K - 1] == null) return -1;
            else return K - 1;
        }
        public Apriori GetItem(int K)
        {
            if (this[K - 1] != null) return this[K - 1];
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
                    if (PrefixEqual(l_Current[i], l_Current[j]))
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
            // count running time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // start
            Apriori apriori = GetItem(Count);
            List<ItemSet> c_List = AprioriGen(Count);
            if (c_List.Count == 0)
            {
                OnAprioriEnd.Invoke(this, new EventArgs());
                EndFlag = true;
                // count running time
                watch.Stop();
                Console.Out.WriteLine("AprioriSet NextStep:::{0}:::{1}", Count, watch.ElapsedMilliseconds);
                return;
            }
            Apriori aprioriNext = new Apriori(Count + 1);
            for (int i = 0; i < c_List.Count; i++) //O(n)
            {
                foreach (F_Item f_item in apriori.F_List) // O(n^3)
                {
                    if (ContainsList(f_item, c_List[i], c_List[i].Count - 1) && ContainsList(f_item, c_List[i], c_List[i].Count - 2)) //O(n^2)
                    {
                        c_List[i].Support++;
                        bool notExistTID = true;
                        for (int j = 0; j < aprioriNext.F_List.Count; j++) //O(n)
                        {
                            if (aprioriNext.F_List[j].TID == f_item.TID)
                            {
                                aprioriNext.F_List[j].Add(c_List[i]);
                                notExistTID = false;
                                break;
                            }
                        }
                        if (notExistTID)
                        {
                            F_Item f = new F_Item();
                            f.TID = f_item.TID;
                            f.Add(c_List[i]);
                            aprioriNext.F_List.Add(f);
                        }
                    }
                }
            }
            float minSup = ((float)Program.MinSupport / 100) * aprioriNext.F_List.Count;
            for (int j = 0; j < c_List.Count; j++) //O(n)
            {
                if (c_List[j].Support >= minSup)
                {
                    ItemSet item = new ItemSet();
                    item.Support = c_List[j].Support;
                    item.AddRange(c_List[j]);
                    aprioriNext.L_List.Add(item);
                }
            }
            Add(aprioriNext);
            // count running time
            watch.Stop();
            Console.Out.WriteLine("AprioriSet NextStep:::{0}:::{1}", Count, watch.ElapsedMilliseconds);
            Program.file.WriteLine($"{Count}:{watch.ElapsedMilliseconds}");
        }
        public bool ContainsList(List<List<int>> listParent, List<int> listChild)
        {
            foreach (List<int> itemParent in listParent)
            {
                if (itemParent.SequenceEqual(listChild))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ContainsList(List<List<int>> f_list, List<int> c_list, int ignoreIndex)
        {
            foreach (List<int> itemParent in f_list)
            {
                if (itemParent.Count != c_list.Count - 1) continue;
                bool isEqual = true;
                int i = 0;
                int j = 0;
                while (i < itemParent.Count)
                {
                    if (j == ignoreIndex) j++;
                    if (itemParent[i] != c_list[j])
                    {
                        isEqual = false;
                        break;
                    }
                    i++;
                    j++;
                }
                if (isEqual) return true;
            }
            return false;
        }
    }
}
