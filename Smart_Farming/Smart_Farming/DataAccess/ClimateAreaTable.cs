using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Smart_Farming.DataAccess
{
    [Table("ClimateArea")] // this is the schema for the ClimateArea table in our sqlite database
    public class ClimateAreaTable
    {
        [PrimaryKey, AutoIncrement]
        public int ClimateID { get; set; }

        [MaxLength(50)]
        public string ClimateName { get; set; }

        public double AvgMinTemp { get; set; }

        public double avgMaxTemp { get; set; }

        public double MinPercip { get; set; }

        public double MaxPercip { get; set; }
    }
}
