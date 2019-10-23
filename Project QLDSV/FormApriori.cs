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
        public FormApriori(AprioriSet aprioriSet)
        {
            AprioriSet = aprioriSet;
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            AprioriSet.NextStep();
        }
    }
}
