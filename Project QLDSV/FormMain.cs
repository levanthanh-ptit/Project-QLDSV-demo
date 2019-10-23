﻿using System;
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
        private AprioriSet AprioriSet;
        public FormMain(MonHocTable MonHocTable, MonHocAdapter MonHocAdapter, GiaoTacTable GiaoTacTable, GiaoTacAdapter GiaoTacAdapter, AprioriSet AprioriSet)
        {
            this.MonHocTable = MonHocTable;
            this.MonHocAdapter = MonHocAdapter;
            this.GiaoTacTable = GiaoTacTable;
            this.GiaoTacAdapter = GiaoTacAdapter;
            this.AprioriSet = AprioriSet;
            InitializeComponent();
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
            AprioriSet = new AprioriSet(GiaoTacTable);
            AprioriSet.NextStep();
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
                minSupCache = trackBarMinSup.Value;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                trackBarMinSup.Value = minSupCache;
            }
        }

        private void BtnGenItemset_Click(object sender, EventArgs e)
        {
            
            FormApriori formApriori = new FormApriori(AprioriSet);
            formApriori.Show();
        }
    }
}