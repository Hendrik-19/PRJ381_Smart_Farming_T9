using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.DataAccess;

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

        public int assignClimate(Location loc)
        {
            Datahandler handler = new Datahandler();
            List<Climates> climateList = new List<Climates>();
            int LocationClimateID = 0;
            string query = $"";//TODO:complete query

            //climateList.AddRange(handler.getData(query)); //TODO:Implement Datatable to list conversion
            
            //logic //TODO: complete logic


            return LocationClimateID;
        }
    }
}
