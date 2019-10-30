using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QLDSV.Mon_Hoc;
using SQLData.Table;
using Project_QLDSV.GiaoTac_Table;
using System.Data.SqlClient;
using Project_QLDSV.DataMiner;

namespace Project_QLDSV
{
    public partial class FormMain : Form, ITableEventInterface
    {
        private int minSupCache;
        private MonHocTable MonHocTable;
        private MonHocAdapter MonHocAdapter;
        private GiaoTacTable GiaoTacTable;
        private GiaoTacAdapter GiaoTacAdapter;
        public FormMain(MonHocTable MonHocTable, MonHocAdapter MonHocAdapter, GiaoTacTable GiaoTacTable, GiaoTacAdapter GiaoTacAdapter)
        {
            this.MonHocTable = MonHocTable;
            this.MonHocAdapter = MonHocAdapter;
            this.GiaoTacTable = GiaoTacTable;
            this.GiaoTacAdapter = GiaoTacAdapter;
            InitializeComponent();
            trackBarMinSup.Value = Program.MinSupport;
            labelMinSup.Text = Program.MinSupport + "%";
            minSupCache = trackBarMinSup.Value;
            AddEventHandler();
        }
        public void AddEventHandler()
        {
            MonHocTable.TableFilled += MonHocTable_TableFilled;
            GiaoTacTable.TableFilled += GiaoTacTable_TableFilled;
        }
        private void MonHocTable_TableFilled(object sender, EventArgs e)
        {
            dataGridViewMonHoc.Rows.Clear();
            foreach (MonHoc m in MonHocTable)
            {
                dataGridViewMonHoc.Rows.Add(m.GetFieldObjectArray());
            }
        }
        private void GiaoTacTable_TableFilled(object sender, EventArgs e)
        {
            dataGridViewGiaotac.Rows.Clear();
            dataGridViewGiaotac.Columns.Clear();
            dataGridViewGiaotac.Columns.Add(new DataGridViewTextBoxColumn() { Name = "MASVCol", HeaderText = "Mã SV" });
            DataGridViewColumn[] columns = new DataGridViewColumn[GiaoTacTable.DynamicFeildLabels.Count];

            dataGridViewEncode.Rows.Clear();
            foreach(object[] el in GiaoTacTable.EndcodeList())
            {
                dataGridViewEncode.Rows.Add(el);
            }

            for (int i = 0; i < GiaoTacTable.DynamicFeildLabels.Count; i++)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn()
                {
                    Name = $"{GiaoTacTable.DynamicFeildLabels[i]}Col",
                    HeaderText = GiaoTacTable.DynamicFeildLabels[i]
                };
                columns[i] = column;
            }
            dataGridViewGiaotac.Columns.AddRange(columns);
            foreach (GiaoTac gt in GiaoTacTable)
            {
                dataGridViewGiaotac.Rows.Add(gt.GetFieldObjectArray());
            }
            
        }
        private void trackBarMinSup_Scroll(object sender, EventArgs e)
        {
            labelMinSup.Text = trackBarMinSup.Value.ToString() + "%";
            Program.MinSupport = trackBarMinSup.Value;
        }
        private void btnRefill_Click(object sender, EventArgs e)
        {
            btnRefill.Enabled = false;
            btnGenItemset.Enabled = false;
            UseWaitCursor = true;
            try
            {
                GiaoTacAdapter.SP_Fill(trackBarMinSup.Value);
                minSupCache = trackBarMinSup.Value;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                trackBarMinSup.Value = minSupCache;
            }
            btnRefill.Enabled = true;
            btnGenItemset.Enabled = true;
            UseWaitCursor = false;
        }

        private void BtnGenItemset_Click(object sender, EventArgs e)
        {
            FormApriori formApriori = new FormApriori();
            formApriori.Show();
        }
    }
}
