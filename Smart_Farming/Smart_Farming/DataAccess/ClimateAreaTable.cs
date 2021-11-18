using System;
using System.Collections.Generic;
using System.Text;
using SQLite; // used to access the SQLite database
using SQLiteNetExtensions.Attributes; // used to create a one to many relationship

namespace Smart_Farming.DataAccess
{
    // This class is used to create a table in the database for the climate data
    #region Climate_Table
    [Table("ClimateArea")] // this is the schema for the ClimateArea table in our sqlite database
    public class ClimateAreaTable
    {
        [PrimaryKey, AutoIncrement, OneToMany]
        public int ClimateID { get; set; }

        [MaxLength(50)]
        public string ClimateName { get; set; }

        public double AvgMinTemp { get; set; }

        public double avgMaxTemp { get; set; }

        public double MinPercip { get; set; }

        public double MaxPercip { get; set; }
    }
    #endregion
}
