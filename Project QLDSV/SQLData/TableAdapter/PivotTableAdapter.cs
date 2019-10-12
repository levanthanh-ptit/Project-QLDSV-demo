using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLData.Table;

namespace SQLData.TableAdapter
{
    public abstract class PivotTableAdapter<T> : TableAdapter<T> where T : Row.Row, new()
    {
        PivotTable<T> DataTable { get; set; }
        public PivotTableAdapter(PivotTable<T> table, SqlConnection connection) : base(table, connection)
        {
            DataTable = table;
        }
        private new void Fill() { }
        public new void SP_Fill(string SPString)
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                try
                {
                    DataTable.Clear();
                    string sql = $"DECLARE @return_value int EXEC @return_value = {SPString} SELECT 'Return Value' = @return_value";
                    SqlCommand command = new SqlCommand(sql, Connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    int VisableFields = new T().VisablePropertiesCount();
                    DataTable.DynamicFeildLabels = new string[dataReader.FieldCount - VisableFields];
                    for (int i = VisableFields; i < dataReader.FieldCount; i++)
                    {
                        DataTable.DynamicFeildLabels[i - VisableFields] = dataReader.GetName(i);
                    }
                    while (dataReader.Read())
                    {
                        DataTable.Add(NewRowFromReader(dataReader));
                    }       
                    dataReader.Close();
                    ///
                    ///Table Event
                    ///
                    DataTable.OnTableFilled();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
        }
    }
}
