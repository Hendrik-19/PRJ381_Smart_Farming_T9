using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.DataAccess;
using System.Data; // this is to use a datatable
using System.Threading.Tasks;
using System.Linq;

namespace Smart_Farming.BusinessLogic
{
    class CropSuggestion
    {
        /*
         * 1: Use the climate assigned to the location to populate a crop list
         * 2: Return the crop list to be displayed to user
         */
        #region Functionality
        public async Task<List<Crop>> getCrops(Location loc)
        {
            Datahandler handler = new Datahandler();
            
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

            var temp = locationCrops; 

            return temp.ToList();
        }
        #endregion
    }
}
