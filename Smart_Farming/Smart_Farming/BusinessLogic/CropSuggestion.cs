using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.DataAccess;

namespace Smart_Farming.BusinessLogic
{
    class CropSuggestion
    {
        /*
         * 1: Use the climate assigned to the location to populate a crop list
         * 2: Return the crop list to be displayed to user
         */

        public List<Crop> getCrops(Location loc) //TODO: Edit query as needed and fix list filling logic
        {
            Datahandler handler = new Datahandler();
            List<Crop> crops = new List<Crop>();
            //example query, could change if database gets changed. Could be incorrect, I'm no DBA
            string query = $"SELECT * FROM Crops JOIN Climate ON Climate.Climate_ID = Crops.Climate_ID WHERE Crops.Climate_ID = {loc.ClimateID}";

            //logic
            //Execute query to fill crops.
            //crops.AddRange(handler.getData(query)); //TODO: Implement datatable to list conversion

            return crops;
        }
    }
}
