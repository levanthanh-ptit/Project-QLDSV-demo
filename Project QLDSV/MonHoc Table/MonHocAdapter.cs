using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLData;
using SQLData.Table;
using SQLData.TableAdapter;

namespace Project_QLDSV.Mon_Hoc
{
    public class MonHocAdapter : TableAdapter<MonHoc>
    {
        public MonHocAdapter(Table<MonHoc> table, SqlConnection connection) : base(table, connection)
        {
        }
        public override MonHoc NewRowFromReader(SqlDataReader reader)
        {
            string maMH = reader.GetString(0);
            MonHoc monHoc = new MonHoc(maMH);
            monHoc.TenMH = reader.GetString(1);
            return monHoc;
        }
    }
}
