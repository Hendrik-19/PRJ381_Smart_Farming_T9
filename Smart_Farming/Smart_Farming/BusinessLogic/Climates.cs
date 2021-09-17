using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms; // if we need some popup messages
using System.Net.Http;//base class to perform http functions
using Newtonsoft.Json;//nuget package to convert json files

namespace Smart_Farming.BusinessLogic
{
    class Climates
    {
        #region Climate
        int climateId;
        string climateName;
        double avgMaxTemp, avgMinTemp, avgPercipitation;

        List<double> averages = new List<double>();

        public Climates(int climateId, string climateName, double avgMaxTemp, double avgMinTemp, double avgPercipitation)
        {
            ClimateId = climateId;
            ClimateName = climateName;
            AvgMaxTemp = avgMaxTemp;
            AvgMinTemp = avgMinTemp;
            AvgPercipitation = avgPercipitation;
        }

        public Climates () { }

        public int ClimateId { get => climateId; set => climateId = value; }
        public string ClimateName { get => climateName; set => climateName = value; }
        public double AvgMaxTemp { get => avgMaxTemp; set => avgMaxTemp = value; }
        public double AvgMinTemp { get => avgMinTemp; set => avgMinTemp = value; }
        public double AvgPercipitation { get => avgPercipitation; set => avgPercipitation = value; }

        public override bool Equals(object obj)
        {
            return obj is Climates climates &&
                   climateId == climates.climateId &&
                   climateName == climates.climateName &&
                   avgMaxTemp == climates.avgMaxTemp &&
                   avgMinTemp == climates.avgMinTemp &&
                   avgPercipitation == climates.avgPercipitation;
        }

        public override int GetHashCode()
        {
            int hashCode = 1697169136;
            hashCode = hashCode * -1521134295 + climateId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(climateName);
            hashCode = hashCode * -1521134295 + avgMaxTemp.GetHashCode();
            hashCode = hashCode * -1521134295 + avgMinTemp.GetHashCode();
            hashCode = hashCode * -1521134295 + avgPercipitation.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Functionality
        public async void getWebResponse(double Latitude, double Longitude)
        {

            List<double> ave = new List<double>();
            WeatherCalc wc = new WeatherCalc();

            using (var client = new HttpClient())//the Weather, WebResponse and webData classes work alongside this block of code
            {

                // send a GET request  
                var uri = "https://api.troposphere.io/climate/" + Latitude + "," + Longitude + "?token=d9d3ad8690f331dbe20920fcaa9837f40607b6c1b274eae389";//url to get the yearly average data from api
                var result = await client.GetStringAsync(uri);

                //handling the answer  
                var posts = JsonConvert.DeserializeObject<WebResponse>(result);

                //takes list as parameter to calculate average values
                ave.Add(wc.getAvgMaxTemp(posts.Data.Monthly));
                ave.Add(wc.getAvgMinTemp(posts.Data.Monthly));
                ave.Add(wc.getAvgPrecipitation(posts.Data.Monthly));
            }

             //Assign ave list to averages list so that it can be returned
             averages = ave;
        }

        public List<double> getWeatherStats(double Latitude, double Longitude)
        {
            getWebResponse(Latitude,Longitude);

            //Return averages
            return averages;
        }
        #endregion
    }
}