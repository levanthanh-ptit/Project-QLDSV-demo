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
        private const int LOAD_LIMIT = 10;
        private AprioriSet AprioriSet;
        private int K;
        public FormApriori(int K = 1)
        {
            AprioriSet = Program.AprioriSet;
            AprioriSet = new AprioriSet(Program.GiaoTacTable);
            this.K = K;
            InitializeComponent();
            Refill();
           
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
            this.txtListF.Text = "Tập F" + K;
            this.txtListL.Text = "Tập L" + K;
        }
        private void CollectionF_Filled()
        {

            dataGridViewListF.Rows.Clear();
            txtCountF.Text = AprioriSet[K - 1].F_List.Count.ToString();
            for (int i = 0; i < Math.Min(LOAD_LIMIT, AprioriSet[K - 1].F_List.Count); i++)
            {
                F_Item f_item = AprioriSet[K - 1].F_List[i];
                dataGridViewListF.Rows.Add(f_item.TID, f_item.ToString());
            }
        }
        private void LoadMore_F()
        {
            int currentRows = dataGridViewListF.Rows.Count;
            for (int i = currentRows; i < Math.Min(currentRows + LOAD_LIMIT, AprioriSet[K - 1].F_List.Count); i++)
            {
                F_Item f_item = AprioriSet[K - 1].F_List[i];
                dataGridViewListF.Rows.Add(f_item.TID, f_item.ToString());
            }
        }
        private void CollectionL_Filled()
        {
            dataGridViewListL.Rows.Clear();
            txtCountL.Text = AprioriSet[K - 1].L_List.Count.ToString();
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

        private void dataGridViewListF_Scroll(object sender, ScrollEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            if (e.Type == ScrollEventType.SmallIncrement)
                if (dataGrid.DisplayedRowCount(false) + dataGrid.FirstDisplayedScrollingRowIndex >= dataGrid.RowCount)
                {
                    LoadMore_F();
                }
        }
    }
}
