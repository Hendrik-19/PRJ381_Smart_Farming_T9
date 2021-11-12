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
            Datahandler_2 handler = new Datahandler_2();
            
            List<Crop> crops = new List<Crop>();
            crops = handler.getCropList();

            List<Crop> locationCrops = new List<Crop>();

            foreach (var crop in crops)
            {
                if (crop.ClimateID == loc.ClimateID)
                {
                    locationCrops.Add(crop);
                }
            }

            return locationCrops;
        }
        #endregion
    }
}
