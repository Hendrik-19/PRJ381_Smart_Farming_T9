using System;
using System.Collections.Generic;
using System.Text;

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
            List<Climates> climateList = new List<Climates>();
            int LocationClimateID = 0;
            //logic

            return LocationClimateID;
        }
    }
}
