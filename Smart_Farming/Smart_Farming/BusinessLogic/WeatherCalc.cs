using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    class WeatherCalc
    {
        /*
         * 1:Use list of 12 months data recieved from API to calculate avg values for location
         * 2:Return calculated avg values
         */
        #region Functionality
        public double getAvgMaxTemp(List<Weather> weath)
        {
            double locMaxAvg = 0;

            //logic
            foreach (var data in weath)
            {
                locMaxAvg += data.TemperatureMax;
            }

            locMaxAvg = locMaxAvg / 12;

            return locMaxAvg;
        }

        public double getAvgMinTemp(List<Weather> weath)
        {
            double locMinAvg = 0;

            //logic
            foreach (var data in weath)
            {
                locMinAvg += data.TemperatureMin;
            }

            locMinAvg = locMinAvg / 12;

            return locMinAvg;
        }

        public double getAvgPrecipitation(List<Weather> weath)
        {
            double locPrecAvg = 0;

            //logic
            foreach (var data in weath)
            {
                locPrecAvg = data.TotalPrecipitation;
            }

            locPrecAvg = locPrecAvg / 12;

            return locPrecAvg;
        }
        #endregion
    }
}
