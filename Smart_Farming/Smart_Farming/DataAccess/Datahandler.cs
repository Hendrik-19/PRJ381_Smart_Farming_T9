using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; // <--added a NuGet Package for this

namespace Smart_Farming.DataAccess
{
    class Datahandler
    {
        private string connectionString = @"";

        public static DataTable GetDataTable(string Query)
        {
            DataTable data = new DataTable();

            //database stuff goes here wheewe figure it out later

            //using (MySqlConnection conn = new MySqlConnection(connStr))
            //{
            //    try
            //    {
            //        conn.Open();
            //        MySqlDataAdapter adapter = new MySqlDataAdapter(Query, conn);
            //        adapter.Fill(data);
            //    }
            //    catch (Exception e)
            //    {
            //        //Console.WriteLine(e.StackTrace);
            //        MessageBox.Show(string.Format("Error: {0}\n\rSQL: {1}", e.Message, Query), "SQL ERROR");
            //    }
            //}

            return data;
        }

    }
}
