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

namespace Project_QLDSV
{
    public partial class Form1 : Form, ITableEventInterface
    {
        private MonHocTable MonHocTable;
        private MonHocAdapter MonHocAdapter;
        private GiaoTacTable GiaoTacTable;
        private GiaoTacAdapter GiaoTacAdapter;
        public Form1(MonHocTable MonHocTable, MonHocAdapter MonHocAdapter, GiaoTacTable GiaoTacTable, GiaoTacAdapter GiaoTacAdapter)
        {
            this.MonHocTable = MonHocTable;
            this.MonHocAdapter = MonHocAdapter;
            this.GiaoTacTable = GiaoTacTable;
            this.GiaoTacAdapter = GiaoTacAdapter;
            InitializeComponent();
            AddEventHandler();
        }

        public void AddEventHandler()
        {
            MonHocTable.RowAdded += MonHocTable_RowAdded;
            MonHocTable.RowDeleted += MonHocTable_RowDeleted;
            GiaoTacTable.TableFilled += GiaoTacTable_TableFilled;
        }

        private void GiaoTacTable_TableFilled(object sender, EventArgs e)
        {
            dataGridViewGiaotac.Rows.Clear();
            dataGridViewGiaotac.Columns.Clear();
            dataGridViewGiaotac.Columns.Add(new DataGridViewTextBoxColumn() { Name = "MASVCol", HeaderText = "Mã SV" });
            DataGridViewColumn[] columns = new DataGridViewColumn[GiaoTacTable.DynamicFeildLabels.Length];
            for (int i = 0; i < GiaoTacTable.DynamicFeildLabels.Length; i++)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn()
                {
                    Name = $"{GiaoTacTable.DynamicFeildLabels[i]}Col",
                    HeaderText = GiaoTacTable.DynamicFeildLabels[i]
                };
                columns[i] = column;
            }
            dataGridViewGiaotac.Columns.AddRange(columns);
            foreach (GiaoTac gt in GiaoTacTable.DataList)
            {
                dataGridViewGiaotac.Rows.Add(gt.ToRowObject());
            }
        }

        private void MonHocTable_RowDeleted(object sender, RowEventArgs<MonHoc> e)
        {

        }

        private void MonHocTable_RowAdded(object sender, RowEventArgs<Mon_Hoc.MonHoc> e)
        {
            dataGridViewMonHoc.Rows.Add(e.Row.ToRowObject());
        }

        private void trackBarMinSup_Scroll(object sender, EventArgs e)
        {
            labelMinSup.Text = trackBarMinSup.Value.ToString() + "%";
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoTacAdapter.SP_Fill(trackBarMinSup.Value);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
