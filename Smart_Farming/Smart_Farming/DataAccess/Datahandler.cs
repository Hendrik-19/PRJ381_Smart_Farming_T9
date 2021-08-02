using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; // <--added a NuGet Package for this
using Xamarin.Forms;

namespace Smart_Farming.DataAccess
{
    class Datahandler
    {
        private string connection = @""; // connection string goes here

        SqlConnection conn; // used establish a connection to the SQL server database
        SqlDataAdapter adapter; // used to convert the data from the database to a datatable

        public DataTable getData(string query)
        {
			DataTable table = new DataTable(); // datatable to store the data from the database
			conn = new SqlConnection(connection); // opens the connection to the database

			try
			{
				adapter = new SqlDataAdapter(query, conn); // will try to execute the query 
				adapter.Fill(table); // will fill the table with the data received from the database if the execution was successful
			}
			catch (Exception e)
			{
				App.Current.MainPage.DisplayAlert("Alert", "Could not find results...", "OK"); // Error message that will display on the main form, Not sure what the App.Current.MainPage part does.
			}
			finally
			{
				conn.Close(); // will ultimatly close the connection to the database once everything has been done
			}

			return table;
		}

    }
}
