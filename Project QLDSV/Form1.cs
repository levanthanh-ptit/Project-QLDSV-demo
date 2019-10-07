using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLData;
using SQLData.Table;

namespace Project_QLDSV
{
    public partial class Form1 : Form, ITableEventInterface
    {
        bool edited = false;
        public Form1()
        {
            InitializeComponent();
            AddEventHandler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.dSSV.Remove(st);
        }

        public void AddEventHandler()
        {
            Program.dSSV.RowAdded += DSSV_RowAdded;
            Program.dSSV.RowDeleted += DSSV_RowDeleted;
        }

        private void DSSV_RowDeleted(object sender, RowEventArgs<Student> e)
        {
            dataGridView1.Rows.RemoveAt(e.Row.Index);
        }

        private void DSSV_RowAdded(object sender, RowEventArgs<Student> e)
        {
            dataGridView1.Rows.Add(e.Row.ToRowObject());
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView view = (DataGridView)sender;
            if (edited)
            {
                Program.dSSV.UpdateRow(new Student(
                                    e.RowIndex,
                                    view.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                    view.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                    view.Rows[e.RowIndex].Cells[2].Value.ToString()
                                    ));
                edited = false;
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.dSSV.State == TableState.Filled) edited = true;
        }
    }
}
