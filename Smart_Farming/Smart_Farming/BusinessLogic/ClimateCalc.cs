using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.DataAccess;
using System.Data; //needed to create a datatable
using System.Threading.Tasks;

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
        public int assignClimate(double maxTemp, double minTemp, double avePercipitation)
        {
            int LocationClimateID = 0;

            Datahandler_2 datahandler = new Datahandler_2();

            List<Climates> climateList = new List<Climates>();

            climateList = datahandler.getClimateList();

            //logic 
            //TODO: Tweak Algorithm as needed
            /*
             * 1: Loop climate list
             * 2: Compare current location vals to indexed climate vals
             * 3: If location vals are within a certain variance of indexed climate -> assign indexed climate id to location.climateId
             * 4: Else continue looping
             */

            try
            {
                foreach (var climate in climateList)//TODO:Look at ways to handle edge cases as needed
                {
                    //Climate assignment criteria:
                    // (climate.min <= min <= climate.min) AND ( climate.max <= max <= climate.max) AND (climate.minPercipitation <= percipitation <= climate.maxPercipitation)

                    if ((climate.AvgMinTemp <= minTemp) && (maxTemp <= climate.AvgMaxTemp) && (climate.MinPercipitation <= avePercipitation) && (avePercipitation <= climate.MaxPercipitation))
                    {
                        LocationClimateID = climate.ClimateId;//Climate assigned
                    }
                }

                if (LocationClimateID == 0)//no climate was assigned
                {
                    App.Current.MainPage.DisplayAlert("Alert", "Could not assign climate to your location", "OK");
                }
            }
            catch (Exception e)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Could not connect to the database :" + e.Message, "OK");
            }
            return LocationClimateID;
        }
        #endregion
    }
}
