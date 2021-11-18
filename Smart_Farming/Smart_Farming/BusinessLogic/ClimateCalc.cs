using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.DataAccess; // needed to access the dataAccess folder
using System.Data; //needed to create a datatable

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
        List<Climates> climateList = new List<Climates>();

        public async void GetClimateData()
        {
            SmartFarmingBD db = new SmartFarmingBD();

            var data = await db.GetClimateAsync(); 

            foreach (ClimateAreaTable item in data)
            {
                climateList.Add(new Climates(item.ClimateID, item.ClimateName, item.avgMaxTemp, item.AvgMinTemp, item.MinPercip, item.MaxPercip));
            } 
        }

        public int assignClimate(double maxTemp, double minTemp, double avePercipitation)
        {
            int LocationClimateID = 0;
            GetClimateData();
            /*
             * 1: Loop climate list
             * 2: Compare current location values to indexed climate vals
             * 3: If location values are within a certain variance of indexed climate -> assign indexed climate id to location.climateId
             * 4: Else continue looping
             */

            try
            {
                foreach (var climate in climateList)
                {
                    //Climate assignment criteria:
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
