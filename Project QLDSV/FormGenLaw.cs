using Project_QLDSV.DataMiner;
using Project_QLDSV.FuncGenerateLaw;
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
    public partial class FormGenLaw : Form
    {
        private int minConf = 0;
        private const int LOAD_LIMIT = 50;
        private List<DataLaw> myCollection = new List<DataLaw>();
        private List<ItemSet> listL;
        public FormGenLaw()
        {
            InitializeComponent();
            listL = getListL(Program.AprioriSet);
        }

        private void TbarMinConf_Scroll(object sender, EventArgs e)
        {
            textMinConf.Text = tbarMinConf.Value.ToString();
            this.minConf = tbarMinConf.Value;
        }

        private List<ItemSet> getListL(AprioriSet aprioriSet)
        {
            List<ItemSet> listL = new List<ItemSet>();
            foreach(Apriori apriori in aprioriSet)
            {
                listL.AddRange(apriori.L_List);
            }
            return listL;
        }

        private void BtnSINHLUAT_Click(object sender, EventArgs e)
        {
            // count running time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // start
            dataGridLaw.Rows.Clear();
            myCollection.Clear();
           // GenLaw generateLaw = new GenLaw();
            GenerateLaw generateLaw = new GenerateLaw();
           
            for (int i = 0; i < listL.Count; i++)
            {
                if (listL.ElementAt(i).Count > 1)
                {
                   // int n = listL.ElementAt(i).Count;
                   // int[] arr = new int[n];
                   // generateLaw.generateAllBinaryStrings(n, arr, 0, ref myCollection, listL, listL.ElementAt(i), minConf);
                   generateLaw.generateAllBinaryStrings(ref myCollection, listL, listL.ElementAt(i),minConf);
                }
            }
            if (myCollection.Count == 0)
            {
                MessageBox.Show("Kết quả tìm luật rỗng !");
            }
            // count running time
            watch.Stop();
            Console.Out.WriteLine("Generate Law:::" + watch.ElapsedMilliseconds);
            txtRecordLaw.Text = myCollection.Count.ToString();
            for (int i = 0; i < Math.Min(LOAD_LIMIT, myCollection.Count); i++)
            {
                dataGridLaw.Rows.Add(myCollection[i].Law, string.Format("{0:n2} %", myCollection[i].minConf));
            }
        }

        private void LoadMore_Law()
        {
            int currentRows = dataGridLaw.Rows.Count;
            for (int i = currentRows; i < Math.Min(currentRows + LOAD_LIMIT, myCollection.Count); i++)
            {
                dataGridLaw.Rows.Add(myCollection[i].Law, string.Format("{0:n2} %", myCollection[i].minConf));
            }
        }
        private void dataGridLaw_Scroll(object sender, ScrollEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            if (e.Type == ScrollEventType.SmallIncrement)
                if (dataGrid.DisplayedRowCount(false) + dataGrid.FirstDisplayedScrollingRowIndex >= dataGrid.RowCount)
                {
                    LoadMore_Law();
                }
        }
    }
}
