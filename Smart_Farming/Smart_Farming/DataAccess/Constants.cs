﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Smart_Farming.DataAccess
{
    public static class Constants
    {
        #region DatabaseCreationAccess
        public const string DatabaseFilename = "SmartFarmingDB.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // Open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
        #endregion
    }
}
