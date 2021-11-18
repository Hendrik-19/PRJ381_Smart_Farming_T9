using System;
using System.Collections.Generic;
using System.Text;


namespace Smart_Farming.BusinessLogic
{
    public class Weather
    {
        // The Weather, webData and WebResponse classes are used to map the API JSON response to C# variables
        #region Weather
        int month;
        double temperatureMin, temperatureMax, totalPrecipitation, cloudCover, sunshineHours;

        public int Month { get => month; set => month = value; }
        public double TemperatureMin { get => temperatureMin; set => temperatureMin = value; }
        public double TemperatureMax { get => temperatureMax; set => temperatureMax = value; }
        public double TotalPrecipitation { get => totalPrecipitation; set => totalPrecipitation = value; }
        public double CloudCover { get => cloudCover; set => cloudCover = value; }
        public double SunshineHours { get => sunshineHours; set => sunshineHours = value; }

        public Weather(int month, double temperatureMin, double temperatureMax, double totalPrecipitation, double cloudCover, double sunshineHours)
        {
            this.month = month;
            this.temperatureMin = temperatureMin;
            this.temperatureMax = temperatureMax;
            this.totalPrecipitation = totalPrecipitation;
            this.cloudCover = cloudCover;
            this.sunshineHours = sunshineHours;
        }

        public Weather() { }

        public override bool Equals(object obj)
        {
            return obj is Weather weather &&
                   month == weather.month &&
                   temperatureMin == weather.temperatureMin &&
                   temperatureMax == weather.temperatureMax &&
                   totalPrecipitation == weather.totalPrecipitation &&
                   cloudCover == weather.cloudCover &&
                   sunshineHours == weather.sunshineHours;
        }

        public override int GetHashCode()
        {
            int hashCode = 183572641;
            hashCode = hashCode * -1521134295 + month.GetHashCode();
            hashCode = hashCode * -1521134295 + temperatureMin.GetHashCode();
            hashCode = hashCode * -1521134295 + temperatureMax.GetHashCode();
            hashCode = hashCode * -1521134295 + totalPrecipitation.GetHashCode();
            hashCode = hashCode * -1521134295 + cloudCover.GetHashCode();
            hashCode = hashCode * -1521134295 + sunshineHours.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
