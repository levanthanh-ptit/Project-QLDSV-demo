using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLData;

namespace Project_QLDSV
{
    class StudentTableAdapter : TableAdapter<Student>
    {
        public StudentTableAdapter(Table<Student> table, SqlConnection connection) : base(table, ref connection)
        {
        }

        public override Student NewRowFromReader(SqlDataReader reader)
        {
            Student sv;
            string MASV = reader.GetString(0);
            sv = new Student(MASV);
            sv.HO = reader.GetString(1);
            sv.TEN = reader.GetString(2);
            return sv;
        }
    }
}
