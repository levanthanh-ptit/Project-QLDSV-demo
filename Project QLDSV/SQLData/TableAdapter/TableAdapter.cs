﻿using SQLData.Table;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.TableAdapter
{
    public abstract class TableAdapter<T> where T : Row.Row, new()
    {
        private Table<T> DataTable { get; set; }
        public SqlConnection Connection { get; set; }
        public string Fillter { get; set; } = "";
        public TableAdapter(Table<T> table, SqlConnection connection)
        {
            DataTable = table;
            Connection = connection;
        }

        public abstract T NewRowFromReader(SqlDataReader reader);

        protected void AddEventHandler() { }

        public void Fill()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                string queryString = $"SELECT TOP 100 * FROM {DataTable.TableName}";
                if (Fillter != "") queryString += $" WHERE {Fillter}";
                SqlCommand command = new SqlCommand(queryString, Connection);
                SqlDataReader dataReader = command.ExecuteReader();
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
        }
        public void SP_Fill(string SPString)
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                string sql = $"DECLARE @return_value int EXEC @return_value = {SPString} SELECT 'Return Value' = @return_value";
                SqlCommand command = new SqlCommand(sql, Connection);
                SqlDataReader dataReader = command.ExecuteReader();
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
        }
        public void UpdateTable()
        {

        }
    }
}
