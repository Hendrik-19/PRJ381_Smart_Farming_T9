using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Smart_Farming.DataAccess
{
    [Table("ClimateArea_Crops")] // this is the schema for the ClimateArea_Crops table in our sqlite database
    public class ClimateAreaCropsTable
    {
        [PrimaryKey, AutoIncrement]
        public int LinkID { get; set; }

        //[ForeignKey(typeof(CropTable))] we neet to figure this out
        public int CropID { get; set; }

        //[ForeignKey(typeof(CropTable))] we neet to figure this out
        public int ClimateID { get; set; }
    }
}
