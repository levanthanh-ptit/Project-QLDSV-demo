using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLData;
namespace Project_QLDSV
{
    class StudentTable : Table<Student>
    {
        public StudentTable(string tableName, long length = 100) : base(tableName, length)
        {
            AddEventHandler();
        }
        protected override void AddEventHandler()
        {
            RowAdded += StudentTable_RowAdded;
            RowDeleted += StudentTable_RowDeleted;
        }

        private void StudentTable_RowDeleted(object sender, RowEventArgs<Student> e)
        {
            throw new NotImplementedException();
        }

        private void StudentTable_RowAdded(object sender, RowEventArgs<Student> e)
        {
            MessageBox.Show(e.row.ToString());
        }

        public override int ItemKeyCompare(Student t1, Student t2)
        {
            return t1.MASV == t2.MASV ? 0 : 1;
        }
    }
}
