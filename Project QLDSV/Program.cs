﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLData;
using Project_QLDSV.Mon_Hoc;
using Project_QLDSV.GiaoTac_Table;
using Project_QLDSV.DataMiner;

namespace Project_QLDSV
{
    static class Program
    {
        public static DataRepository dataRepository = new DataRepository();
        //Student table
        public static MonHocTable MonHocTable;
        public static MonHocAdapter MonHocAdapter;
        public static GiaoTacTable GiaoTacTable;
        public static GiaoTacAdapter GiaoTacAdapter;
        public static FormMain FormMain;
        public static AprioriSet AprioriSet;
        public static int MinSupport = 0;
        public static void SetupServices()
        {
            dataRepository.Server = "DESKTOP-EBVE71U\\LOUISSQLSERVER";
            dataRepository.DataBase = "QLDSV";
            dataRepository.LoginName = "sa";
            dataRepository.Password = "123";
            dataRepository.NewSqlConnection();
            MonHocTable = new MonHocTable();
            MonHocAdapter = new MonHocAdapter(MonHocTable, dataRepository.sqlConnection);
            GiaoTacTable = new GiaoTacTable();
            GiaoTacAdapter = new GiaoTacAdapter(GiaoTacTable, dataRepository.sqlConnection);
            FormMain = new FormMain(MonHocTable, MonHocAdapter, GiaoTacTable, GiaoTacAdapter, AprioriSet);
        }
        public static void StartServices()
        {  
            dataRepository.ConnectServer();
            MonHocAdapter.Fill();
            GiaoTacAdapter.SP_Fill(0);
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetupServices();
            StartServices();
            Application.Run(FormMain);
        }
    }
}
