using Project_QLDSV.DataMiner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLDSV
{
    public partial class FormApriori : Form
    {
        private AprioriSet AprioriSet;
        private int K = 0;
        public FormApriori(AprioriSet AprioriSet, int K)
        {
            this.AprioriSet = AprioriSet;
            this.K = K;
            InitializeComponent();
            AddEventHandler();
            this.txtListF.Text = "Tập F" + K;
            this.txtListL.Text = "Tập L" + K;
        }
        public void AddEventHandler()
        {
            this.CollectionF_Filled();
            this.CollectionL_Filled();
        }
        private void CollectionF_Filled()
        {
            foreach (F_Item f_item in AprioriSet[K-1].F_List)
            {
                dataGridViewListF.Rows.Add(f_item.TID, f_item.ToString());
            }
        }
        private void CollectionL_Filled()
        {
            foreach (ItemSet itemSet in AprioriSet[K-1].L_List)
            {
                dataGridViewListL.Rows.Add(itemSet.ToString(),itemSet.Support);
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AprioriSet.BackStep(K);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            
            AprioriSet.NextStep(K);
            this.Hide();
        }
    }
}
