using SQLData.Table;
using SQLData.TableAdapter;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.GiaoTac_Table
{
    public class GiaoTacAdapter : PivotTableAdapter<GiaoTac>
    {
        public GiaoTacAdapter(PivotTable<GiaoTac> table, SqlConnection connection) : base(table, connection)
        {
        }
        public override GiaoTac NewRowFromReader(SqlDataReader reader)
        {
            GiaoTac giaoTac = new GiaoTac(reader.GetString(0));
            for(int i = 1; i < reader.FieldCount; i++)
            {
                try
                {
                    giaoTac.Pass.Add(reader.GetInt32(i));
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    giaoTac.Pass.Add(-1);
                }
            }
            return giaoTac;
        }
        public void SP_Fill(int minSup)
        {
            base.SP_Fill($"SP_GIAOTAC @minsup = {minSup}");
        }
    }
}
