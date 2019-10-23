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
        private AprioriSet aprioriSet;
        public FormApriori(GiaoTac_Table.GiaoTacTable giaoTacs)
        {
            InitializeComponent();
            aprioriSet = new AprioriSet(giaoTacs);

        }
        public FormApriori(int k)
        {
            InitializeComponent();

        }
        private void CollectionF_Filled(object sender, EventArgs e)
        {
            dataGridViewListF.DataSource = aprioriSet[0].F_List;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            List<int> a = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> b = new List<int>() { 1,2,7 };
            if (a.Any(item => b.Contains(item)))
            {
                Console.WriteLine("B NAM TRONG A");
            }
            else
            {
                Console.WriteLine("B ko NAM TRONG A");
            }
        }

       
    }
}
