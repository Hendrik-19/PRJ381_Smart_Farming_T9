using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.DataAccess;
using System.Data; //  needed to create a datatable

namespace Smart_Farming.BusinessLogic
{
    class ClimateCalc
    {
        /*
         * 1: Populate climate list from database
         * 2: Calculate avg values for location
         * 3: Loop through climate list and find the climate with values closest to location values
         * 4: Assign detected climate to location
         */

        #region Functionality
        public int assignClimate(Location loc)
        {
            int LocationClimateID = 0;
            string query = $"SELECT * FROM Climates";

            Datahandler handler = new Datahandler();
            Convertion convert = new Convertion();

            DataTable temp = new DataTable();
            temp = handler.getData(query);

            List<Climates> climateList = new List<Climates>();
            climateList  = convert.ConvertDataTable<Climates>(temp);

            //logic //TODO: complete logic


            return LocationClimateID;
        }
        #endregion
    }
}
