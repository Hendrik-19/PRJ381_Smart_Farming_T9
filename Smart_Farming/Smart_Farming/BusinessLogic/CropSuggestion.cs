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
        List<Crop> crops = new List<Crop>();

        public async void GetCropData(Location loc)
        {
            SmartFarmingBD db = new SmartFarmingBD();
            string query = $"SELECT Crops.CropID, Crops.CropName, Crops.Sowtime, Crops.HarvestTime, Crops.IrrigationAmount, Crops.Pests, Crops.CropImage FROM Crops INNER JOIN ClimateArea_Crops ON ClimateArea_Crops.CropID = Crops.CropID WHERE ClimateArea_Crops.Climate_ID = {loc.ClimateID}";

            var data = await db.GetCropItemsNotDoneAsync(query);

            foreach (CropTable item in data)
            {
                crops.Add(new Crop(item.CropID, item.CropName, item.SowTime, item.HarvestTime, item.IrrigationAmount, item.Pests));
            }
        }

        public List<Crop> getCrops(Location loc)
        {
            GetCropData(loc);

            return crops;
        }
        #endregion
    }
}
