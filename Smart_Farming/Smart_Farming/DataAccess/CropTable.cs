using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Smart_Farming.DataAccess
{
    [Table("Crops")] // this is the schema for the crop table in our sqlite database
    
    public class CropTable
    {
        [PrimaryKey, AutoIncrement]
        public int CropID { get; set; }

        [MaxLength(50)]
        public string CropName { get; set; }

        [MaxLength(50)]
        public string SowTime { get; set; }

        public double HarvestTime { get; set; }

        public double IrrigationAmount { get; set; }

        [MaxLength(50)]
        public string Pests { get; set; }

        // we need a image too but will figure that out soon ...
    }
}
