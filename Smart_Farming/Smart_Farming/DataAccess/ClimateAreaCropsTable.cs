using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Smart_Farming.DataAccess
{
    
    public class ClimateAreaCropsTable
    {
        [ForeignKey(typeof(CropTable))]
        public int CropID { get; set; }

        [ForeignKey(typeof(CropTable))]
        public int ClimateID { get; set; }
    }
}
