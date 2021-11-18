using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms; // used for pop up messages
using System.Net.Http; // base class to perform http functions
using Newtonsoft.Json; // nuget package to convert json files
using System.Threading.Tasks; // Multithreading.

namespace Smart_Farming.BusinessLogic
{
    class Climates
    {
        #region Climate
        int climateId;
        string climateName;
        double avgMaxTemp, avgMinTemp, minPercipitation, maxPercipitation;

        List<double> averages = new List<double>();

        public int ClimateId { get => climateId; set => climateId = value; }
        public string ClimateName { get => climateName; set => climateName = value; }
        public double AvgMaxTemp { get => avgMaxTemp; set => avgMaxTemp = value; }
        public double AvgMinTemp { get => avgMinTemp; set => avgMinTemp = value; }
        public double MinPercipitation { get => minPercipitation; set => minPercipitation = value; }
        public double MaxPercipitation { get => maxPercipitation; set => maxPercipitation = value; }

        public Climates () { }

        public Climates(int climateId, string climateName, double avgMaxTemp, double avgMinTemp, double minPercipitation, double maxPercipitation)
        {
            ClimateId = climateId;
            ClimateName = climateName;
            AvgMaxTemp = avgMaxTemp;
            AvgMinTemp = avgMinTemp;
            MinPercipitation = minPercipitation;
            MaxPercipitation = maxPercipitation;
        }

        public override bool Equals(object obj)
        {
            return obj is Climates climates &&
                   ClimateId == climates.ClimateId &&
                   ClimateName == climates.ClimateName &&
                   AvgMaxTemp == climates.AvgMaxTemp &&
                   AvgMinTemp == climates.AvgMinTemp &&
                   MinPercipitation == climates.MinPercipitation &&
                   MaxPercipitation == climates.MaxPercipitation;
        }

        public override int GetHashCode()
        {
            int hashCode = 712991018;
            hashCode = hashCode * -1521134295 + ClimateId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClimateName);
            hashCode = hashCode * -1521134295 + AvgMaxTemp.GetHashCode();
            hashCode = hashCode * -1521134295 + AvgMinTemp.GetHashCode();
            hashCode = hashCode * -1521134295 + MinPercipitation.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxPercipitation.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Functionality
        public async Task<List<double>> getWebResponse(double Latitude, double Longitude)
        {
            List<double> ave = new List<double>();
            WeatherCalc wc = new WeatherCalc();

            using (var client = new HttpClient())//the Weather, WebResponse and webData classes work alongside this block of code
            {

                // send a GET request  
                var uri = "https://api.troposphere.io/climate/" + Latitude + "," + Longitude + "?token=d9d3ad8690f331dbe20920fcaa9837f40607b6c1b274eae389";//url to get the yearly average data from api
                var result = await client.GetStringAsync(uri);

                // handling the answer  
                var posts = JsonConvert.DeserializeObject<WebResponse>(result);

                // takes list as parameter to calculate average values
                ave.Add(wc.getAvgMaxTemp(posts.Data.Monthly));
                ave.Add(wc.getAvgMinTemp(posts.Data.Monthly));
                ave.Add(wc.getAvgPrecipitation(posts.Data.Monthly));
            }

            //Assign ave list to averages list so that it can be returned
            var temp = ave;

            return temp.ToList();
        }
        #endregion
    }
}