using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLData;
using Project_QLDSV.Mon_Hoc;
using Project_QLDSV.GiaoTac_Table;
using Project_QLDSV.DataMiner;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Project_QLDSV
{
    static class Program
    {
        public static System.IO.StreamWriter file;
        public static DataRepository dataRepository = new DataRepository();
        //Student table
        public static MonHocTable MonHocTable;
        public static MonHocAdapter MonHocAdapter;
        public static GiaoTacTable GiaoTacTable;
        public static GiaoTacAdapter GiaoTacAdapter;
        public static FormMain FormMain;
        public static AprioriSet AprioriSet;
        public static int MinSupport = 25;
        public static void SetupServices()
        {
            dynamic server = JObject.Parse(File.ReadAllText("../../appsettings.json"));
            file = new System.IO.StreamWriter((string)server.logfile, true);
            dataRepository.Server = server.server;
            dataRepository.DataBase = server.database;
            dataRepository.LoginName = "sa";
            dataRepository.Password = "123";
            dataRepository.NewSqlConnection();
            MonHocTable = new MonHocTable();
            MonHocAdapter = new MonHocAdapter(MonHocTable, dataRepository.sqlConnection);
            GiaoTacTable = new GiaoTacTable();
            GiaoTacAdapter = new GiaoTacAdapter(GiaoTacTable, dataRepository.sqlConnection) {
                TimeoutLimit = 180
            };
            FormMain = new FormMain(MonHocTable, MonHocAdapter, GiaoTacTable, GiaoTacAdapter);
        }
        public static void StartServices()
        {  
            dataRepository.ConnectServer();
            MonHocAdapter.Fill();
            //GiaoTacAdapter.SP_Fill(MinSupport);
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetupServices();
            StartServices();
            file.WriteLine("int:::");
            Application.Run(FormMain);
            file.Close();
        }
    }
}
