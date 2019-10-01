using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLData;

namespace Project_QLDSV
{
    static class Program
    {
        public static DataRepository dataRepository = new DataRepository();
        //Student table
        public static StudentTable dSSV = new StudentTable("SINHVIEN");
        public static StudentTableAdapter studentTableAdapter;
        public static void SetupServices()
        {
            dataRepository.Server = "DESKTOP-1VI1ATV";
            dataRepository.DataBase = "QLDSV";
            dataRepository.LoginName = "sa";
            dataRepository.Password = "123";
            dataRepository.NewSqlConnection();
            studentTableAdapter = new StudentTableAdapter(dSSV, dataRepository.sqlConnection);
        }
        public static void StartServices()
        {  
            dataRepository.ConnectServer();
            studentTableAdapter.Fill();
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetupServices();
            StartServices();           
        }
    }
}
