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
        private int K;

        public FormApriori(int K = 1)
        {
            AprioriSet = Program.AprioriSet;
            AprioriSet = new AprioriSet(Program.GiaoTacTable);
            this.K = K;
            InitializeComponent();
            Refill();
            this.txtListF.Text = "Tập F" + K;
            this.txtListL.Text = "Tập L" + K;
            AprioriSet.OnAprioriEnd += AprioriSet_OnAprioriEnd;
        }

        private void SetK(int K)
        {
            this.K = K;
            if (K == 1) btnBack.Enabled = false;
            else btnBack.Enabled = true;
            if (K == AprioriSet.Count && AprioriSet.EndFlag) btnNext.Enabled = false;
            else btnNext.Enabled = true;
        }

        private void AprioriSet_OnAprioriEnd(object sender, EventArgs e)
        {
            Program.AprioriSet = AprioriSet;
            FormGenLaw formGenLaw = new FormGenLaw();
            formGenLaw.Show();
        }

        public void Refill()
        {
            this.CollectionF_Filled();
            this.CollectionL_Filled();
        }
        private void CollectionF_Filled()
        {
            dataGridViewListF.Rows.Clear();
            this.txtTapF.Text = AprioriSet[K - 1].F_List.Count.ToString();
            foreach (F_Item f_item in AprioriSet[K - 1].F_List)
            {
                dataGridViewListF.Rows.Add(f_item.TID, f_item.ToString());
            }
        }
        private void CollectionL_Filled()
        {
            dataGridViewListL.Rows.Clear();
            this.txtTapL.Text = AprioriSet[K - 1].L_List.Count.ToString();
            foreach (ItemSet itemSet in AprioriSet[K - 1].L_List)
            {
                dataGridViewListL.Rows.Add(itemSet.ToString(), itemSet.Support);
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            SetK(K - 1);
            if (K == 1) btnBack.Enabled = false;
            Refill();

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!AprioriSet.EndFlag && K + 1 > AprioriSet.Count) AprioriSet.NextStep();
            if (K < AprioriSet.Count) SetK(K + 1);
            else SetK(K);
            Refill();
        }
    }
}
