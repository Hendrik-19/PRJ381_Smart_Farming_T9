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
            //TODO:Think of ways to handle edge cases
            //example query, could change if database gets changed. Could be incorrect, I'm no DBA
            string query = $"SELECT * FROM Crops JOIN Climate ON Climate.Climate_ID = Crops.Climate_ID WHERE Crops.Climate_ID = {loc.ClimateID}"; // TODO: fix query if needed

            DataTable temp = new DataTable();
            temp = handler.getData(query);

            List<Crop> crops = new List<Crop>();
            crops = convert.ConvertDataTable<Crop>(temp);

            return crops;
        }
        #endregion
    }
}
