using System;
using System.Collections.Generic;
using System.Text;
using SQLite; // used access the SQLite database
using SQLiteNetExtensions.Attributes; // Used to create a foreign key link with the climate table

namespace Smart_Farming.DataAccess
{
    // This class is used to create a table in the SQLite database for the crop data.
    #region Crop_Table
    [Table("Crops")] // this is the schema for the crop table in our sqlite database
    public class CropTable
    {
        [PrimaryKey, AutoIncrement]
        public int CropID { get; set; }

        [ForeignKey(typeof(ClimateAreaTable))]
        public int ClimateID { get; set; }

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
    #endregion
}
