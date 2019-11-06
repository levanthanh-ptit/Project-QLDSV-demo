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
        public FormGenLaw()
        {
            InitializeComponent();
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
            GenLaw generateLaw = new GenLaw();
            //GenerateLaw generateLaw = new GenerateLaw();
            
            List<DataLaw> myCollection = new List<DataLaw>();
            List<ItemSet> listL = getListL(Program.AprioriSet);
            for (int i = 0; i < listL.Count; i++)
            {
                if (listL.ElementAt(i).Count > 1)
                {
                    int n = listL.ElementAt(i).Count;
                    int[] arr = new int[n];
                    generateLaw.generateAllBinaryStrings(n, arr, 0, ref myCollection, listL, listL.ElementAt(i), minConf);
                   //generateLaw.generateAllBinaryStrings(ref myCollection, listL, listL.ElementAt(i),minConf);
                }
            }
            if (myCollection.Count == 0)
            {
                MessageBox.Show("Kết quả tìm luật rỗng !");
            }
            foreach (DataLaw l in myCollection)
            {
                dataGridLaw.Rows.Add(l.Law, string.Format("{0:n2} %", l.minConf));
            }
            // count running time
            watch.Stop();
            Console.Out.WriteLine("Generate Law:::" + watch.ElapsedMilliseconds);
        }

   
    }
}
