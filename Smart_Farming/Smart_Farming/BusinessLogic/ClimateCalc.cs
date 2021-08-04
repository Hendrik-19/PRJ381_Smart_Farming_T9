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

            /*
             * 1: Loop climate list
             * 2: Compare current location vals to indexed climate vals
             * 3: If location vals are within a certain variance of indexed climate -> assign indexed climate id to location.climateId
             */

            foreach (var climate in climateList)
            {
                //TODO: When testing, reduce variance if climate zones conflict

                //TODO: make percipitation criteria

                //Climate assignment criteria:
                // (climate.min - variance < min < climate.min + variance) AND ( climate.max - varience < max < climate.max + variance) AND (persipitation stuff)
                
                if ((climate.AvgMinTemp - 6.55 <= loc.AvgMinTemp || loc.AvgMinTemp <= climate.AvgMinTemp + 6.55) && (climate.AvgMaxTemp - 8.45 <= loc.AvgMaxTemp || loc.AvgMaxTemp <= climate.AvgMaxTemp + 8.45) /*&& (Persipitation stuff) */) 
                {
                    LocationClimateID = climate.ClimateId;//Climate assigned
                }
            }

            if (LocationClimateID == 0)//no climate was assigned
            {
                App.Current.MainPage.DisplayAlert("Alert","Could not assign climate","OK");
            }

            return LocationClimateID;
        }
        #endregion
    }
}
