using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.DataAccess;
using System.Data; // this is to use a datatable

namespace Smart_Farming.BusinessLogic
{
    class CropSuggestion
    {
        /*
         * 1: Use the climate assigned to the location to populate a crop list
         * 2: Return the crop list to be displayed to user
         */
        #region Functionality
        public List<Crop> getCrops(Location loc)
        {
            Datahandler handler = new Datahandler();
            Convertion convert = new Convertion();
            //crop selection query
            string query = $"SELECT Crops.CropID, Crops.CropName, Crops.Sowtime, Crops.HarvestTime, Crops.IrrigationAmount, Crops.Pests, Crops.CropImage FROM Crops INNER JOIN ClimateArea_Crops ON ClimateArea_Crops.CropID = Crops.CropID WHERE ClimateArea_Crops.Climate_ID = {loc.ClimateID}"; 

            DataTable temp = new DataTable();
            temp = handler.getData(query);

            List<Crop> crops = new List<Crop>();
            crops = convert.ConvertDataTable<Crop>(temp);

            return crops;
        }
        #endregion
    }
}
